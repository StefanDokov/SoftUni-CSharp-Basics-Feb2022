using System;

namespace RadianstoDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radiant = double.Parse(Console.ReadLine());
            Console.WriteLine((radiant * 180) / Math.PI);
        }
    }
}
