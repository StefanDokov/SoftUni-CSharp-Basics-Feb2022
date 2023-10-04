using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        

        private List<Person> people;

        public Family()
        {
            people = new List<Person>();
        }

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public void AddMember(Person member)
        {
            this.People.Add(member);
        }
        
        public Person GetOldestMember() {
            return this.People.MaxBy(p => p.Age);
        }

        public List<Person> GetMembers()
        {
            return this.People
                .OrderBy(p => p.Name)
                .Where(p => p.Age > 30)
                .ToList();
        }

    }
}
