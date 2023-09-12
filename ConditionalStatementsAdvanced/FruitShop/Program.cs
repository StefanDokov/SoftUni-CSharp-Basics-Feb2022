using System;

namespace FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double cost = 0;

            switch (product)
            {
                case "banana":
                    
                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            cost = 2.50;
                            break;
                        case "Saturday":
                        case "Sunday":
                            cost = 2.70;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }

                    break;
                case "apple":

                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            cost = 1.20;
                            break;
                        case "Saturday":
                        case "Sunday":
                            cost = 1.25;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "orange":

                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            cost = 0.85;
                            break;
                        case "Saturday":
                        case "Sunday":
                            cost = 0.90;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapefruit":

                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            cost = 1.45;
                            break;
                        case "Saturday":
                        case "Sunday":
                            cost = 1.60;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "kiwi":

                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            cost = 2.70;
                            break;
                        case "Saturday":
                        case "Sunday":
                            cost = 3.00;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "pineapple":

                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            cost = 5.50;
                            break;
                        case "Saturday":
                        case "Sunday":
                            cost = 5.60;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                case "grapes":

                    switch (day)
                    {
                        case "Monday":
                        case "Tuesday":
                        case "Wednesday":
                        case "Thursday":
                        case "Friday":
                            cost = 3.85;
                            break;
                        case "Saturday":
                        case "Sunday":
                            cost = 4.20;
                            break;
                        default:
                            Console.WriteLine("error");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
            if (cost != 0) { 
              Console.WriteLine($"{cost * amount:f2}");

            }
        }
    }
}
