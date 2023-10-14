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

		public int GetCount()
		{
			return Drinks.Count;
		}

		public void AddDrink(Drink drink)
		{
			if (Drinks.Count < buttonCapacity)
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
					return true;
				}
			}
			return false;
		}

		public Drink GetLongest() 
		{
            return  Drinks.OrderByDescending(x => x.Volume).FirstOrDefault();
			
		}

		public Drink GetCheapest()
		{
			return Drinks.OrderBy(x => x.Price).FirstOrDefault();

        }

		public string BuyDrink(string name)
		{
			string show = "";
			foreach (Drink drink in Drinks)
			{
				if (drink.Name == name)
				{
					show = drink.ToString();
				}
			}
			return show;
		}

		public StringBuilder Report()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("Drinks available:");
			foreach(Drink drink in Drinks)
			{
				stringBuilder.AppendLine(drink.ToString());
			}
			
			return stringBuilder;
			
		}
	}
}
