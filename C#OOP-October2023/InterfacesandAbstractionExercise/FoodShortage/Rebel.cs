using FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Rebel : IBuyer, IRebel
    {
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
            Food = 0;
        }

        public int Food {get; private set;}

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Group { get; private set; }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
