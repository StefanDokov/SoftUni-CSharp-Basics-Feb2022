using System;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripExpenses = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double sum = puzzles * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

            int allToys = puzzles + dolls + bears + minions + trucks;

            if (allToys >= 50)
            {
                sum = sum * 0.75;
            }

            sum *= 0.9; 

            if (sum >= tripExpenses)
            {
                Console.WriteLine($"Yes! {sum - tripExpenses:F2} lv left.");
            } else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(tripExpenses - sum):F2} lv needed.");
            }

        }
    }
}
