using NauticalCatchChallenge.Core.Contracts;
using NauticalCatchChallenge.Models;
using NauticalCatchChallenge.Models.Contracts;
using NauticalCatchChallenge.Repositories;
using NauticalCatchChallenge.Repositories.Contracts;
using NauticalCatchChallenge.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Core
{
    public class Controller : IController
    {
        private IRepository<IDiver> divers;
        private IRepository<IFish> fish;

        public Controller()
        {
            divers = new DiverRepository();
            fish = new FishRepository();
        }
        public string ChaseFish(string diverName, string fishName, bool isLucky)
        {
            IDiver divera = divers.GetModel(diverName);
            IFish fishe = fish.GetModel(fishName);
            if (divera == null)
            {
                return string.Format(OutputMessages.DiverNotFound, divers.GetType().Name, diverName);
            }
            if (fishe == null)
            {
                return string.Format(OutputMessages.FishNotAllowed, fishName);
            }

            if (divera.HasHealthIssues == true)
            {
                return string.Format(OutputMessages.DiverHealthCheck, diverName);
            }

            if (divera.OxygenLevel < fishe.TimeToCatch)
            {
                divera.Miss(fishe.TimeToCatch);
                if (divera.OxygenLevel == 0)
                {
                    divera.UpdateHealthStatus();
                }
                return string.Format(OutputMessages.DiverMisses, diverName, fishName);
            }
            if (divera.OxygenLevel == fishe.TimeToCatch)
            {
                if (isLucky == true)
                {
                    divera.Hit(fishe);
                    if (divera.OxygenLevel == 0)
                    {
                        divera.UpdateHealthStatus();
                    }
                    return string.Format(OutputMessages.DiverHitsFish, diverName, fishe.Points, fishName);
                }
                else
                {
                    divera.Miss(fishe.TimeToCatch);
                    if (divera.OxygenLevel == 0)
                    {
                        divera.UpdateHealthStatus();
                    }
                    return string.Format(OutputMessages.DiverMisses, diverName, fishName);
                }
            }
            divera.Hit(fishe);
            if (divera.OxygenLevel == 0)
            {
                divera.UpdateHealthStatus();
            }
            return string.Format(OutputMessages.DiverHitsFish, diverName, fishe.Points, fishName);


        }

        public string CompetitionStatistics()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("**Nautical-Catch-Challenge**");
            List<IDiver> dives = divers.Models.Where(d => d.HasHealthIssues == false).OrderByDescending(d => d.CompetitionPoints).ThenByDescending(d => d.Catch.Count()).ThenBy(d => d.Name).ToList();
        
            foreach (IDiver diver in dives) 
            { 
                stringBuilder.AppendLine(diver.ToString());
            }

            return stringBuilder.ToString().TrimEnd();


        }

        public string DiveIntoCompetition(string diverType, string diverName)
        {
            if (divers.GetModel(diverName) != null)
            {
                return String.Format(OutputMessages.DiverNameDuplication, diverName, "DiverRepository");
            }
            IDiver diver;
            if (diverType == "FreeDiver")
            {
                diver = new FreeDiver(diverName);
            }
            else if (diverType == "ScubaDiver")
            {
                diver = new ScubaDiver(diverName);
            }
            else
            {
                return String.Format(OutputMessages.DiverTypeNotPresented, diverType);
            }

            
            divers.AddModel(diver);
            return String.Format(OutputMessages.DiverRegistered, diverName, "DiverRepository");
            
        }

        public string DiverCatchReport(string diverName)
        {
            IDiver divo = divers.GetModel(diverName);

            StringBuilder sb = new StringBuilder();

            sb.AppendLine(divo.ToString());
            sb.AppendLine("Catch Report:");
            foreach (string name in divo.Catch)
            {
                sb.AppendLine(fish.GetModel(name).ToString());
            }
            return sb.ToString().TrimEnd();
        }

        public string HealthRecovery()
        {
            int cont = 0;

            List<IDiver> diversInDanger = divers.Models.Where(d => d.HasHealthIssues == true).ToList();

            if (diversInDanger.Count > 0)
            {
                foreach (IDiver divo in diversInDanger)
                {
                    divo.UpdateHealthStatus();
                    divo.RenewOxy();
                    cont++;
                }
            }
            return string.Format(OutputMessages.DiversRecovered, cont);
        }

        public string SwimIntoCompetition(string fishType, string fishName, double points)
        {
            if (fish.GetModel(fishName) != null)
            {
                return string.Format(OutputMessages.FishNameDuplication, fishName, "FishRepository");
            }

            IFish fisho;

            if (fishType == "ReefFish")
            {
                fisho = new ReefFish(fishName, points);
            }
            else if (fishType == "DeepSeaFish")
            {
                fisho = new DeepSeaFish(fishName, points);
            }
            else if (fishType == "PredatoryFish")
            {
                fisho = new PredatoryFish(fishName, points);
            }
            else
            {
                return string.Format(OutputMessages.FishTypeNotPresented, fishType);
            }
            
            

            fish.AddModel(fisho);
            return string.Format(OutputMessages.FishCreated, fishName);
            

        }
    }
}
