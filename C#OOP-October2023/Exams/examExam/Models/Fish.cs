using NauticalCatchChallenge.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public abstract class Fish : IFish
    {

        public Fish(string name, double points, int timeToCatch)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Fish name should be determined.");
            }
            if (points < 1 || points > 10)
            {
                throw new ArgumentException("Points must be a numeric value, between 1 and 10.");

            }

            Name = name;
            Points = Math.Round(points, 1);
            TimeToCatch = timeToCatch;

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

        private double points;

        public double Points
        {
            get
            {
                return points;
            }
            private set
            {
                points = value;
            }
        }
        private int timeToCatch;

        public int TimeToCatch
        {
            get
            {
                return timeToCatch;
            }
            private set
            {
                timeToCatch = value;
            }
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {Name} [ Points: {Points}, Time to Catch: {TimeToCatch} seconds ]";
        }

    }
}
