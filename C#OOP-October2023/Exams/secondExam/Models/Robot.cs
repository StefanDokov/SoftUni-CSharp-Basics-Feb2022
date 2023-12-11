using RobotService.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public abstract class Robot : IRobot
    {
        public Robot(string model, int batteryCapacity, int convertionCapacityIndex)
        {
            if (string.IsNullOrWhiteSpace(model))
            {
                throw new ArgumentException("Model cannot be null or empty.");
            }
            if (batteryCapacity < 0)
            {
                throw new ArgumentException("Battery capacity cannot drop below zero.");
            }
            Model = model;
            BatteryCapacity = batteryCapacity;
            BatteryLevel = BatteryCapacity;
            ConvertionCapacityIndex = convertionCapacityIndex;
            
        }

        public string model;
        public string Model
        {
            get { return model; }
            private set { model = value; }
        }

        public int batteryCapacity;
        public int BatteryCapacity
        {
            get { return batteryCapacity; }
            private set { batteryCapacity = value; }
        }

        
        public int batteryLevel;
        public int BatteryLevel
        {
            get { return batteryLevel; }
            private set { batteryLevel = value; }
        }



        public int convertionCapacityIndex;
        public int ConvertionCapacityIndex
        {
            get { return convertionCapacityIndex; }
            private set { convertionCapacityIndex = value; }
        }
        public IReadOnlyCollection<int> InterfaceStandards { get; private set; } = new List<int>();

        public void Eating(int minutes)
        {
            int energyProduced = ConvertionCapacityIndex * minutes;

            BatteryLevel += energyProduced;

            if (BatteryLevel >= BatteryCapacity)
            {
                BatteryLevel = BatteryCapacity;

            }
            
        }

        public bool ExecuteService(int consumedEnergy)
        {
            if (BatteryLevel >= consumedEnergy)
            {
                BatteryLevel -= consumedEnergy;

                BatteryLevel = Math.Max(0, BatteryLevel);

                return true;
            }
            else
            {
                return false;
            }
        }

        public void InstallSupplement(ISupplement supplement)
        {
            InterfaceStandards = new List<int>(InterfaceStandards) {supplement.InterfaceStandard };

            BatteryCapacity -= supplement.BatteryUsage;

            BatteryLevel -= supplement.BatteryUsage;

            BatteryCapacity = Math.Max(0, BatteryCapacity);
            BatteryLevel = Math.Max(0, BatteryLevel);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine($"{GetType().Name} {Model}:");
        stringBuilder.AppendLine($"--Maximum battery capacity: {BatteryCapacity}");
        stringBuilder.AppendLine($"--Current battery level: {BatteryLevel}");

        if (InterfaceStandards.Count > 0)
        {
            stringBuilder.Append("--Supplements installed: ");
            stringBuilder.Append(string.Join(" ", InterfaceStandards));
        }
        else
        {
            stringBuilder.Append("--Supplements installed: none");
        }

        return stringBuilder.ToString();
        }
    }
}
