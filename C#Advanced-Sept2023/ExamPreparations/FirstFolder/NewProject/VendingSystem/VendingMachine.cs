using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingSystem
{
    public class VendingMachine
    {

        public VendingMachine(int capacity)
        {
            ButtonCapacity = capacity;
			Drinks = new List<Drink>();
        }

        private int buttonCapacity;

		public int ButtonCapacity
		{
			get { return buttonCapacity; }
			set { buttonCapacity = value; }
		}

		private List<Drink> drinks;

		public List<Drink> Drinks
		{
			get { return drinks; }
			set { drinks = value; }
		}

		private int getCount;

		public int GetCount
		{
			get { return Drinks.Count; }
		}


		public void AddDrink(Drink drink)
		{
			if (Drinks.Count < ButtonCapacity)
			{

			Drinks.Add(drink);
			}
		}

		public bool RemoveDrink(string name)
		{
			foreach (Drink drink in Drinks) 
			{ 
				if (drink.Name == name)
				{
					Drinks.Remove(drink);
					return true;
				}
			}
			return false;
		}

		public Drink GetLongest() 
		{
            Drink longest = Drinks.OrderByDescending(d => d.Volume).First();
			return longest;
		}

		public Drink GetCheapest()
		{
			 
		    Drink cheapest = Drinks.OrderBy(d => d.Price).First();
            return cheapest;
        }

		public string BuyDrink(string name)
		{
			string show = "";
			foreach (Drink drink in Drinks)
			{
				if (drink.Name == name)
				{
					show = drink.ToString().TrimEnd();
				}
			}
			return show;
		}

		public string Report()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Drinks available:");
			foreach(Drink drink in Drinks)
			{
				stringBuilder.AppendLine(drink.ToString());
			}
			
			return stringBuilder.ToString().TrimEnd();
			
		}
	}
}
