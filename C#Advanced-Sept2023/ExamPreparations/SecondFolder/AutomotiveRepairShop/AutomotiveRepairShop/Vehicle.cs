namespace AutomotiveRepairShop
{
    public class Vehicle
    {
        public Vehicle(string vin, int mileage, string damage)
        {
            VIN = vin;
			Mileage = mileage;
			Damage = damage;
        }

        private string vin;

		public string VIN
		{
			get { return vin; }
			set { vin = value; }
		}

		private int mileage;

		public int Mileage
		{
			get { return mileage; }
			set { mileage = value; }
		}

		private string damage;

		public string Damage
		{
			get { return damage; }
			set { damage = value; }
		}


        public override string ToString()
        {
            return $"Damage: {damage}, Vehicle: {vin} ({mileage} km)";
        }

    }
}
