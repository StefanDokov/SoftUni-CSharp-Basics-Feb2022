﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Pokemon
    {

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string element;

		public string Element
		{
			get { return element; }
			set { element = value; }
		}

		private int health;

		public int Health
		{
			get { return health; }
			set { health = value; }
		}



	}
}
