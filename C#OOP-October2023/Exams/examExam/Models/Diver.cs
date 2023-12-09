using NauticalCatchChallenge.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{

    
    public abstract class Diver : IDiver
    {
        public Diver(string name, int oxygenLevell)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Diver's name cannot be null or empty.");
            }
            Name = name;
            OxygenLevel = oxygenLevell;
            CompetitionPoints = 0;
            HasHealthIssues = false;
        }


        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value;
            }
        }


        public int OxygenLevel { get; protected set; }


        public IReadOnlyCollection<string> Catch { get; private set; } = new List<string>();


        private double competitionPoints;

        public double CompetitionPoints
        {
            get
            {
                return competitionPoints;
            }
            private set
            {
                competitionPoints = value;
            }
        }
        private bool hasHealthIssues;

        public bool HasHealthIssues
        {
            get
            {
                return hasHealthIssues;
            }
            private set
            {
                hasHealthIssues = value;
            }
        }
        public void Hit(IFish fish)
        {
            OxygenLevel -= fish.TimeToCatch;
            Catch = new List<string>(Catch) {fish.Name};
            CompetitionPoints = Math.Round(CompetitionPoints + fish.Points, 1);
            if (OxygenLevel < 0)
            {
                OxygenLevel = 0;
            }
        }

        public abstract void Miss(int timeToCatch);


        public abstract void RenewOxy();
        

        public void UpdateHealthStatus()
        {
            HasHealthIssues = !HasHealthIssues;
        }

        public override string ToString()
        {
            return $"Diver [ Name: {Name}, Oxygen left: {OxygenLevel}, Fish caught: {Catch.Count()}, Points earned: {CompetitionPoints} ]";
        }
    }
}
