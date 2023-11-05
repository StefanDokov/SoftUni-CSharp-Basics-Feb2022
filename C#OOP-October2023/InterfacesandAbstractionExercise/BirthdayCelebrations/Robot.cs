using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Robot: IRobot
    {
        public Robot(string model, string id)
        {
            
            this.Model = model;
            this.Id = id;
        }
        public string Model { get; private set; }

        public string Id { get; private set; }

        


    }
}
