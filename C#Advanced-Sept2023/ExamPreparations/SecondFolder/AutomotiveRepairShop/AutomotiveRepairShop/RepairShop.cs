using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            Capacity = capacity;
			Vehicles = new List<Vehicle>();
        }

        private int capacity;

		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}


		private List<Vehicle> vehicles;

		public List<Vehicle> Vehicles
		{
			get { return vehicles; }
			set { vehicles = value; }
		}

		public void AddVehicle(Vehicle vehiclee) 
		{
			if (Vehicles.Count < Capacity)
			{
				Vehicles.Add(vehiclee);
			}
		}

		public bool RemoveVehicle(string vin)
		{
			Vehicle vehicleToRemove = Vehicles.Where(v => v.VIN == vin).FirstOrDefault();

            if (vehicleToRemove != null)
			{
				Vehicles.Remove(vehicleToRemove);
				return true;
			}
			else 
			{ 
				return false; 
			}

		}

		public int GetCount()
		{
			return Vehicles.Count;
		}

		public Vehicle GetLowestMileage()
		{
			return Vehicles.OrderBy(v => v.Mileage).FirstOrDefault();
		}

		public string Report()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("Vehicles in the preparatory:");

			foreach (Vehicle v in Vehicles)
			{
				sb.AppendLine(v.ToString());
			}

			return sb.ToString().TrimEnd();
		}
	}
}
