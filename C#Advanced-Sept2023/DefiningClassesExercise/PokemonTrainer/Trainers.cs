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
			Creatures = new();
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

		public void AddPokemonIntoCollection(Pokemon pokemon)
		{
			Creatures.Add(pokemon.Name, pokemon);
		}

		public Dictionary<string, Pokemon> Checker(string element)
		{
			bool haveIt = false;
			foreach (var pokemon in Creatures)
			{
				if (pokemon.Value.Element == element)
				{
					Badges++;
					haveIt = true;
					break;
				}
				

			}
			if (!haveIt)
			{
                foreach (var pokemon in Creatures)
                {
                    pokemon.Value.Health -= 10;
					if (pokemon.Value.Health <= 0)
					{
						Creatures.Remove(pokemon.Key);
					}


                }
            }
			return Creatures;
		}

	}
}
