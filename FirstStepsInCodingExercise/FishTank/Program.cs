using System;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());


            double obem = length * width * height;

            double waterOnly = obem - ((obem * percent) / 100);
            Console.WriteLine($"{waterOnly / 1000}");
        }
    }
}
