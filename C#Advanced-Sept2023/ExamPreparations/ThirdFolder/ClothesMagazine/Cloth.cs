namespace ClothesMagazine
{
    public class Cloth
    {
        public Cloth(string color, int size, string type)
        {
            Color = color;
			Size = size;
			Type = type;
        }

        private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}

		private int size;

		public int Size
		{
			get { return size; }
			set { size = value; }
		}

		private string type;

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

        public override string ToString()
        {
            return $"Product: {Type} with size {Size}, color {Color}";
        }

    }
}
