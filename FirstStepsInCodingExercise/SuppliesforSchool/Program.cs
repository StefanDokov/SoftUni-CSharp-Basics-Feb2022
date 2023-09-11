using System;

namespace SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPackets = int.Parse(Console.ReadLine());
            int markerPackets = int.Parse(Console.ReadLine());  
            int litersCleaner = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double pensCost = 5.80;
            double markersCost = 7.20;
            double cleanerCostperLiter = 1.20;


            double costs = (pensCost * penPackets + markersCost * markerPackets + litersCleaner * cleanerCostperLiter);
            Console.WriteLine(costs - costs * percentDiscount / 100);
        }
    }
}
