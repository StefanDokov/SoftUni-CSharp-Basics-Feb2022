using System;

namespace VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bookPages = int.Parse(Console.ReadLine());
            int readingSpeed = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine((bookPages / days) / readingSpeed);
        }
    }
}
