using System;

namespace Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string monthIn = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double studiofullCost = 0;
            double appartmentfullCost = 0;

            if (monthIn == "May" || monthIn == "October")
            {

                studiofullCost = 50 * nights;
                appartmentfullCost = 65 * nights;

                if (nights > 7 && nights <= 14)
                {
                    studiofullCost *= 0.95;

                }
                if (nights > 14)
                {
                    studiofullCost *= 0.7;
                }

            }
            if (monthIn == "June" || monthIn == "September")
            {

                studiofullCost = 75.20 * nights;
                appartmentfullCost = 68.70 * nights;

                if (nights > 14)
                {
                    studiofullCost *= 0.8;
                }
            }
            if (monthIn == "July" || monthIn == "August")
            {

                studiofullCost = 76 * nights;
                appartmentfullCost = 77 * nights;
            }

            if (nights > 14)
            {
                appartmentfullCost *= 0.9;
            }

            Console.WriteLine($"Apartment: {appartmentfullCost:f2} lv.");
            Console.WriteLine($"Studio: {studiofullCost:f2} lv.");
        }
    }
}
