using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Person : ICitizen, ICheckable
    {
        
        public Person(string name, int age, string id, string date) { 
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = date;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string Birthdate { get; private set; }

        public void CheckBirthdate(string input)
        {
            if (this.Birthdate.EndsWith(input))
            {
                Console.WriteLine($"{this.Birthdate}");
            }
        }

    }
}
