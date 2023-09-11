using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yards = double.Parse(Console.ReadLine());

            double sqareMcost = 7.61;
            double priceWithoutDiscount = yards * sqareMcost;
            Console.WriteLine($"The final price is: {priceWithoutDiscount - ((priceWithoutDiscount * 18) / 100)} lv.");
            Console.WriteLine($"The discount is: {(priceWithoutDiscount * 18) / 100} lv.");
        }
    }
}
