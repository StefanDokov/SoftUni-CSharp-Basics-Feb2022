using System;

namespace WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordTime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeperm = double.Parse(Console.ReadLine());

            double timer = distance * timeperm;
            double delay = Math.Floor(distance / 15) * 12.5;

            double speed = timer + delay;

            if (speed < recordTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {speed:F2} seconds.");
            } 
            else
            {
                Console.WriteLine($"No, he failed! He was {speed - recordTime:F2} seconds slower.");
            }
        }
    }
}
