using System;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double cost = 0;

            if (season == "Spring")
            {
                cost += 3000;
            }
            if (season == "Summer" || season == "Autumn")
            {
                cost += 4200;
            }
            if (season == "Winter")
            {
                cost += 2600;
            }

            if (fishermen <= 6)
            {
                cost *= 0.9;
            }
            if (fishermen >= 7 && fishermen <= 11) 
            {
                cost *= 0.85;
            }
            if (fishermen >= 12) 
                {
                cost *= 0.75;
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                cost *= 0.95;
            }

            if (cost <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - cost:f2} leva left.");
            } else
            {
                Console.WriteLine($"Not enough money! You need {cost - budget:f2} leva.");
            }

        }
    }
}
