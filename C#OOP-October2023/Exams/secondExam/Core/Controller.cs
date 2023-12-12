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
            throw new NotImplementedException();
        }

        public string Report()
        {
            throw new NotImplementedException();
        }

        public string RobotRecovery(string model, int minutes)
        {
            throw new NotImplementedException();
        }

        public string UpgradeRobot(string model, string supplementTypeName)
        {
            throw new NotImplementedException();
        }
    }
}
