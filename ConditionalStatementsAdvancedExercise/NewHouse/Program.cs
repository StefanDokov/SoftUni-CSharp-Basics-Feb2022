using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double cost = 0;
            double currentSum = 0;

            switch (type)
            {
                case "Roses":
                    cost = 5;
                    currentSum = amount * cost;
                    if (amount > 80)
                    {
                        currentSum *= 0.9;
                    }
                    break;
                case "Dahlias":
                    cost = 3.80;
                    currentSum = amount * cost;
                    if (amount > 90)
                    {
                        currentSum *= 0.85;
                    }
                    break;
                case "Tulips":
                    cost = 2.80;
                    currentSum = amount * cost;
                    if (amount > 80)
                    {
                        currentSum *= 0.85;
                    }
                    break;
                case "Narcissus":
                    cost = 3;
                    currentSum = amount * cost;
                    if (amount < 120)
                    {
                        currentSum *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    cost = 2.50;
                    currentSum = amount * cost;
                    if (amount < 80)
                    {
                        currentSum *= 1.20;
                    }
                    break;
            }

            if (currentSum <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {type} and {budget - currentSum:f2} leva left.");
            } else
            {
                Console.WriteLine($"Not enough money, you need {currentSum - budget:f2} leva more.");
            }

        }
    }
}
