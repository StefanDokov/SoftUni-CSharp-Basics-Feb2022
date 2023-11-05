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
        
        public Person(string name, int age, string id) { 
            this.Name = name;
            this.Age = age;
            this.Id = id;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public void CheckId(string input)
        {
            if (this.Id.EndsWith(input))
            {
                Console.WriteLine($"{this.Id}");
            }
        }

    }
}
