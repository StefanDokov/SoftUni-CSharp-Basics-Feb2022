using System;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylonCost = 1.50;
            double paintPerLiter = 14.50;
            double thinnerCost = 5.00;

            int nylonMeters = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double paintCost = paintPerLiter * paint;
            double nylonSum = nylonCost * (nylonMeters + 2);
            double majstori = (paintCost + paintCost * 0.1 + nylonSum + 0.40 + thinner * thinnerCost) * 0.30;

            Console.WriteLine(paintCost + paintCost * 0.1 + nylonSum + 0.40 + thinner * thinnerCost + hours * majstori);
        }
    }
}
