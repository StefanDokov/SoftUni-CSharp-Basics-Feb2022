using RobotService.Core.Contracts;
using RobotService.Models;
using RobotService.Models.Contracts;
using RobotService.Repositories;
using RobotService.Repositories.Contracts;
using RobotService.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Core
{
    public class Controller : IController
    {
        private IRepository<ISupplement> supplements;
        private IRepository<IRobot> robots;

        public Controller()
        {
            supplements = new SupplementRepository();
            robots = new RobotRepository();
        }
        public string CreateRobot(string model, string typeName)
        {
            IRobot roboto;

            
            if (typeName == "DomesticAssistant")
            {
                roboto = new DomesticAssistant(model);
            }
            else if (typeName == "IndustrialAssistant")
            {
                roboto = new IndustrialAssistant(model);
            }
            else
            {
                return string.Format(OutputMessages.RobotCannotBeCreated, typeName);
            }

            robots.AddNew(roboto);
            return string.Format(OutputMessages.RobotCreatedSuccessfully, typeName, model);

        }

        public string CreateSupplement(string typeName)
        {
            ISupplement suplement;

            if (typeName == "SpecializedArm")
            {
                suplement = new SpecializedArm();
            }
            else if (typeName == "LaserRadar")
            {
                suplement = new LaserRadar();
            }
            else
            {
                return string.Format(OutputMessages.SupplementCannotBeCreated, typeName);
            }

            supplements.AddNew(suplement);
            return string.Format(OutputMessages.SupplementCreatedSuccessfully, typeName);

        }

        public string PerformService(string serviceName, int intefaceStandard, int totalPowerNeeded)
        {
            List<IRobot> selectedRobots = robots.Models().Where(r => r.InterfaceStandards.Any(i => i == intefaceStandard)).OrderByDescending(y => y.BatteryLevel).ToList();

            if (selectedRobots.Count() == 0)
            {
                return string.Format(OutputMessages.UnableToPerform, intefaceStandard);
            }

            int powerSum = selectedRobots.Sum(r => r.BatteryLevel);

            if (powerSum < totalPowerNeeded)
            {
                return string.Format(OutputMessages.MorePowerNeeded, serviceName, totalPowerNeeded - powerSum);
            }

            int usedRobotsCount = 0;

            foreach (IRobot robot in selectedRobots)
            {
                usedRobotsCount++;

                if (totalPowerNeeded <= robot.BatteryLevel)
                {
                    robot.ExecuteService(totalPowerNeeded);
                    break;
                }
                else
                {
                    totalPowerNeeded -= robot.BatteryLevel;
                    robot.ExecuteService(robot.BatteryLevel);
                }

            }

            return string.Format(OutputMessages.PerformedSuccessfully, serviceName, usedRobotsCount);

        }

        public string Report()
        {
            throw new NotImplementedException();
        }

        public string RobotRecovery(string model, int minutes)
        {
            List<IRobot> selectedRobots = robots.Models().Where(r =>  r.Model == model && r.BatteryLevel * 2 < r.BatteryCapacity).ToList();
            int robotsFed = 0;

            foreach (IRobot robot in selectedRobots)
            {
                robot.Eating(minutes);
                robotsFed++;
            }

            return string.Format(OutputMessages.RobotsFed, robotsFed);
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            ISupplement supplementa = supplements.Models().FirstOrDefault(m => m.GetType().Name == supplementTypeName);
            List<IRobot> roboti = robots.Models().Where(r => r.Model == model).ToList();
            List<IRobot> robotiFiltered = roboti.Where(r => r.InterfaceStandards.All(s => s != supplementa.InterfaceStandard)).ToList();
            IRobot robotToUpgrade = robotiFiltered.FirstOrDefault();

            if (robotToUpgrade == null)
            {
                return string.Format(OutputMessages.AllModelsUpgraded, model);
            }

            robotToUpgrade.InstallSupplement(supplementa);
            supplements.RemoveByName(supplementTypeName);

            return string.Format(OutputMessages.UpgradeSuccessful, model, supplementTypeName);
        }
    }
}
