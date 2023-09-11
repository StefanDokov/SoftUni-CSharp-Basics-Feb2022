using System;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double percentPerYear = double.Parse(Console.ReadLine());

            double result = deposit + term * ((deposit * percentPerYear / 100) / 12);

            Console.WriteLine(result);
        }
    }
}
