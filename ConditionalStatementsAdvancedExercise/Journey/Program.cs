using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "";
            string building = "";
            double cost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    building = "Camp";
                    cost = budget * 0.3;
                }
                if (season == "winter")
                {
                    building = "Hotel";
                    cost = budget * 0.7;
                }
            }
            if (budget > 100 && budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    building = "Camp";
                    cost = budget * 0.4;
                }
                if (season == "winter")
                {
                    building = "Hotel";
                    cost = budget * 0.8;
                }
            }
            if (budget > 1000)
            {
                destination = "Europe";
                building = "Hotel";
                cost = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{building} - {cost:f2}");
        }
    }
}
