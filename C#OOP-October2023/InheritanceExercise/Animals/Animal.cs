using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        protected Animal(string name, int age, string gender)
        {
            
            if (!IsValidFormat(name) || !IsValidFormat(gender) || age <= 0) 
            {
                throw new ArgumentException("Invalid input!");
             }
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }

        public abstract string ProduceSound();

        private bool IsValidFormat(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
        public override string ToString()
       => $"{Name} {Age} {Gender}{Environment.NewLine}" +
       $"{ProduceSound()}";
    }
}
