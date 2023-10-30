






using System;

namespace PersonsInfo
{
    public class StartUp
    {

        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                cmdArgs[1],
               int.Parse(cmdArgs[2]),
               decimal.Parse(cmdArgs[3]));
                persons.Add(person);
            }
            var parcentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(parcentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));

        }



    }

    public class Person
    {
        public Person(string firstname, string lastname, int age, decimal salary)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Salary = salary;
            this.Age = age;
        }
        public string FirstName { get; private set; }

        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        
        
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30)
            {
                this.Salary += this.Salary * percentage / 100;
            }
            else
            {
                this.Salary += this.Salary * percentage / 200;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {Salary:f2} leva.";
        }



    }




}