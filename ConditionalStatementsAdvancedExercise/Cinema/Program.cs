using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeTicket = Console.ReadLine();
            double rows = double.Parse(Console.ReadLine());
            double cols = double.Parse(Console.ReadLine());   

            switch (typeTicket)
            {
                case "Premiere":
                    Console.WriteLine($"{rows * cols * 12.00:f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{rows * cols * 7.50:f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{rows * cols * 5.00:f2} leva");
                    break;
            }
        }
    }
}
