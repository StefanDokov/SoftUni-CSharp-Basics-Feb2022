using BirthdayCelebrations.Models;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCelebrations
{
    public class Pet : IPet, ICheckable
    {
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

        public string Name { get; private set; }

        public string Birthdate { get; private set; }

        public void CheckBirthdate(string input)
        {
            if (this.Birthdate.EndsWith(input))
            {
                Console.WriteLine($"{this.Birthdate}");
            }
            ;
        }
    }
}
