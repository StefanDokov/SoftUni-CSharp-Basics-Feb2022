using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new(personInfo[0], int.Parse(personInfo[1]));
                family.AddMember(person);
            }

            List<Person> list = family.GetMembers();
            
            foreach (Person person in list)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }



    }
}
