using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chicken = 10.35;
            double fish = 12.40;
            double vegan = 8.15;


            int chickMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veganMenus = int.Parse(Console.ReadLine());

            double desert = (chicken * chickMenus + fish * fishMenus + vegan * veganMenus) * 0.20;
            Console.WriteLine(desert * 5 + desert + 2.50);
        }
    }
}
