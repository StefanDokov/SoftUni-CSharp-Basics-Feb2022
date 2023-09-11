using System;

namespace GodzillavsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());
            double dressCost = statists * pricePerStatist;

            if (statists > 150)
            {
                dressCost *= 0.9;
            }
            double sum = dressCost + budget * 0.1;

            if (sum > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {sum - budget:F2} leva more.");
            } else
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budget - sum:F2} leva left.");
            }
        }
    }
}
