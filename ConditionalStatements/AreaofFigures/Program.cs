using System;

namespace AreaofFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine($"{side * side:F3}");
            }
            if (figure == "circle")
            {
                double side = double.Parse(Console.ReadLine());

                Console.WriteLine($"{(side * side) * Math.PI:F3}");
            }
            if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());

                Console.WriteLine($"{sideA * sideB:F3}");
            }
            if (figure == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double heightA = double.Parse(Console.ReadLine());

                Console.WriteLine($"{sideA * heightA / 2:F3}");
            }

        }
    }
}
