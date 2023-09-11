using System;

namespace EvenorOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numba = int.Parse(Console.ReadLine());

            if (numba % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
