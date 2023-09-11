using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videoSum = videoCards * 250;
            double processPrice = videoSum * 0.35;
            double ramPrice = videoSum * 0.1;

            double sum = videoSum + processors * processPrice + ram * ramPrice;
            
            if (videoCards > processors)
            {
                sum *= 0.85;
            }

            if (sum <= budget)
            {
                Console.WriteLine($"You have {budget - sum:f2} leva left!");
            } else
            {
                Console.WriteLine($"Not enough money! You need {sum - budget:f2} leva more!");
            }
        }
    }
}
