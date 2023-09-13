using System;

namespace SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string grade = Console.ReadLine();
            double cost = 0;

            switch (typeRoom)
            {
                case "room for one person":
                    cost = (days - 1) * 18;
                    
                    break;
                case "apartment":
                    cost = (days - 1) * 25;
                    if (days < 10)
                    {
                        cost *= 0.7;
                    }
                    if (days >= 10 && days <= 15)
                    {
                        cost *= 0.65;
                    }
                    if (days > 15)
                    {
                        cost *= 0.5;
                    }
                    break;
                case "president apartment":
                    cost = (days - 1) * 35;
                    if (days < 10)
                    {
                        cost *= 0.9;
                    }
                    if (days >= 10 && days <= 15)
                    {
                        cost *= 0.85;
                    }
                    if (days > 15)
                    {
                        cost *= 0.8;
                    }
                    break;
            }
            if (grade == "positive")
            {
                cost *= 1.25;
            }
            if (grade == "negative")
            {
                cost *= 0.9;
            }
            Console.WriteLine($"{cost:f2}");
        }
    }
}
