using EDriveRent.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Models
{
    public abstract class Vehicle : IVehicle
    {

        public Vehicle(string brand, string model, double maxMileage,string licensePlateNumber)
        {
            Brand = brand;
            Model = model;
            MaxMileage = maxMileage;
            LicensePlateNumber = licensePlateNumber;
            BatteryLevel = 100;
            IsDamaged = false;
        }
        public string brand;
        public string Brand
        {
            get
            {
                return brand;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Brand cannot be null or whitespace!");
                }
                brand = value;
            }
        }
        public string model;

        public string Model
        {
            get
            {
                return model;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null or whitespace!");
                }
                model = value;
            }
        }

        public double maxMileage;
        public double MaxMileage
        {
            get
            {
                return maxMileage;
            }
            private set
            {
                maxMileage = value;
            }
        }

        public string licensePlateNumber;
        public string LicensePlateNumber
        {
            get
            {
                return licensePlateNumber;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("License plate number is required!");
                }
                licensePlateNumber = value;
            }
        }
        public int batteryLevel;
        public int BatteryLevel
        {
            get
            {
                return batteryLevel;
            }
            private set
            {
                batteryLevel = value;
            }
        }

        public bool isDamaged;
        public bool IsDamaged
        {
            get
            {
                return isDamaged;
            }
            protected set
            {
                isDamaged = value;
            }
        }


        public void ChangeStatus()
        {
            IsDamaged = !IsDamaged;
        }

        public void Drive(double mileage)
        {
            double cost = Math.Round((mileage / maxMileage) * 100);
            if (this.GetType().Name == nameof(CargoVan))
            {
                cost += 5;
            }
            BatteryLevel -= (int)cost;
        }

        public void Recharge()
        {
            BatteryLevel = 100;
        }

        public override string ToString()
        {
            string status = IsDamaged ? "damaged" : "OK";
            return $"{Brand} {Model} License plate: {LicensePlateNumber} Battery: {BatteryLevel}% Status: {status}";

        }
    }
}
