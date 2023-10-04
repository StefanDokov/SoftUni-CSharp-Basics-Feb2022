using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {

		public Car(string model, double fuelamount, double fuelconsume) { 

			Model = model;
			FuelAmount = fuelamount;
			FuelConsumptionPerKilometer = fuelconsume;
			travelledDistance = 0;	
		}

		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private double fuelAmount;

		public double FuelAmount
		{
			get { return fuelAmount; }
			set { fuelAmount = value; }
		}

		private double fuelConsumptionPerKilometer;

		public double FuelConsumptionPerKilometer
		{
			get { return fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }
		}

		private double travelledDistance;

		public double TravelledDistance
		{
			get { return travelledDistance; }
			set { travelledDistance = value; }
		}


		public void IsItEnough(int kms)
		{
			if (this.FuelAmount < FuelConsumptionPerKilometer * kms)
			{
				Console.WriteLine("Insufficient fuel for the drive");
			}
			else
			{
				FuelAmount -= FuelConsumptionPerKilometer * kms;
				TravelledDistance += kms;

            }
		}

	}
}
