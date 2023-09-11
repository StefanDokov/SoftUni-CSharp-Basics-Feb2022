using System;

namespace LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int duration = int.Parse(Console.ReadLine());
            double breakDuration = double.Parse(Console.ReadLine());

            double launch = breakDuration * 1 / 8;
            double rest = breakDuration * 1 / 4;

            double freeTime = breakDuration - launch - rest;

            if (freeTime >= duration)
            {
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(freeTime - duration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {name}, you need {Math.Ceiling(duration - freeTime)} more minutes.");
            }
        }
    }
}
