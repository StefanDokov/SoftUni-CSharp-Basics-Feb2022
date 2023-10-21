using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothesMagazine
{
    public class Magazine
    {
        public Magazine(string type, int capacity)
        {
			Type = type;
            Capacity = capacity;
			Clothes = new List<Cloth>();
        }

        private string type;

		public string Type
		{
			get { return type; }
			set { type = value; }
		}
		private int capacity;

		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}

		private List<Cloth> clothes;

		public List<Cloth> Clothes
		{
			get { return clothes; }
			set { clothes = value; }
		}

		public void AddCloth(Cloth cloth)
		{
			if (Clothes.Count < Capacity)
			{
				Clothes.Add(cloth);
			}
		}

		public bool RemoveCloth(string color)
		{
			return Clothes.Remove(Clothes.Where(c => c.Color == color).FirstOrDefault());
		}

		public Cloth GetSmallestCloth()
		{
			return Clothes.OrderBy(c => c.Size).FirstOrDefault();
		}

		public Cloth GetCloth(string color)
		{
			return Clothes.Where(c => c.Color == color).FirstOrDefault();
		}

		public int GetClothCount()
		{
			return Clothes.Count;
		}

		public string Report()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine($"{Type} magazine contains:");

			foreach (var clot in Clothes.OrderBy(c => c.Size))
			{
				sb.AppendLine(clot.ToString());
			}

			return sb.ToString().TrimEnd();
		}

	}
}
