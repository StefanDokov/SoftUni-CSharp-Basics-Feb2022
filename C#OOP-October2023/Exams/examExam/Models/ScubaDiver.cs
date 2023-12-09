using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    internal class ScubaDiver : Diver
    {
        public ScubaDiver(string name): base(name, 540)
        {
            
        }
        public override void Miss(int timeToCatch)
        {
            double oxygenDecr = 0.3 * timeToCatch;
            OxygenLevel -= (int)Math.Round(oxygenDecr, MidpointRounding.AwayFromZero);
            if (OxygenLevel < 0)
            {
                OxygenLevel = 0;

            }
        }

        public override void RenewOxy()
        {
            OxygenLevel = 540;
        }
    }
}
