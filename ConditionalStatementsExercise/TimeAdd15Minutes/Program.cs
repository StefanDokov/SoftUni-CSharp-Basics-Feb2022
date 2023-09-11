using System;

namespace TimeAdd15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int minsSum = minutes + 15;

            if (minsSum < 60)
            {
                Console.WriteLine($"{hours}:{minsSum}");
            } else
            {
                hours += 1;
                if (hours > 23)
                {
                    hours = 0;
                }
                minsSum -= 60;
                if (minsSum < 10 )
                {
                    Console.WriteLine($"{hours}:0{minsSum}");
                } else
                {
                    Console.WriteLine($"{hours}:{minsSum}");
                }
            }
        }
    }
}
