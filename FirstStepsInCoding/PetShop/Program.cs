using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogsPackeges = int.Parse(Console.ReadLine());
            int catsPackeges = int.Parse(Console.ReadLine());

            double dogsCost = 2.5;
            double catsCost = 4;

            double allCosts = (dogsPackeges * dogsCost) + (catsPackeges * catsCost);

            Console.WriteLine(allCosts + " lv.");
        }
    }
}
