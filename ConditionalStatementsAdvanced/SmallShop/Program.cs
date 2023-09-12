using System;

namespace SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double cost = 0;

            switch (city)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            cost = 0.50;
                                break;
                        case "water":
                            cost = 0.80;
                            break;
                        case "beer":
                            cost = 1.20;
                            break;
                        case "sweets":
                            cost = 1.45;
                            break;
                        case "peanuts":
                            cost = 1.60; 
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            cost = 0.40;
                            break;
                        case "water":
                            cost = 0.70;
                            break;
                        case "beer":
                            cost = 1.15;
                            break;
                        case "sweets":
                            cost = 1.30;
                            break;
                        case "peanuts":
                            cost = 1.50;
                            break;
                    }
                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            cost = 0.45;
                            break;
                        case "water":
                            cost = 0.70;
                            break;
                        case "beer":
                            cost = 1.10;
                            break;
                        case "sweets":
                            cost = 1.35;
                            break;
                        case "peanuts":
                            cost = 1.55;
                            break;
                    }
                    break;
            }
            Console.WriteLine(value * cost);
        }
    }
}
