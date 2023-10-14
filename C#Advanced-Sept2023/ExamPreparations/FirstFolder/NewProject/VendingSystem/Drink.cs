
namespace VendingSystem
{
    public class Drink
    {

        public Drink(string name, decimal price, int volume)
        {
			Name = name;
			Price = price;
			Volume = volume;
        }

        private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private decimal price;

		public decimal Price
		{
			get { return price; }
			set { price = value; }
		}

		private int volume;

		public int Volume
		{
			get { return volume; }
			set { volume = value; }
		}

        public override string ToString()
        {
			return $"Name: {Name}, Price: ${Price}, Volume: {Volume} ml";
        }


    }
}
