using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainers
    {
        public Trainers(string name)
        {
			Badges = 0;
			Name = name;
        }

        

        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int badges;

		public int Badges
		{
			get { return badges; }
			set { badges = value; }
		}

		private Dictionary<string, Pokemon> creatures;

		public Dictionary<string, Pokemon> Creatures
		{
			get { return creatures; }
			set { creatures = value; }
		}


	}
}
