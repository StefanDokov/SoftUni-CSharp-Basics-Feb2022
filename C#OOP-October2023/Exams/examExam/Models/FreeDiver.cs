using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public class FreeDiver : Diver
    {
        public FreeDiver(string name): base(name, 120)
        {
            
        }
        public override void Miss(int timeToCatch)
        {
            double oxygenDecr = 0.6 * timeToCatch;
            OxygenLevel -= (int)Math.Round(oxygenDecr, MidpointRounding.AwayFromZero);
            if (OxygenLevel < 0)
            {
                OxygenLevel = 0;
            }
        }

        public override void RenewOxy()
        {
            OxygenLevel = 120;
        }
    }
}
