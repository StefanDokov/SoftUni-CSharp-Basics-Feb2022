using System;

namespace OnTimefortheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minArrive = int.Parse(Console.ReadLine());

            int examTime = hourExam * 60 + minExam;
            int arriveTime = hourArrive * 60 + minArrive;

            

            if ((examTime - 30) <= arriveTime && arriveTime <= examTime)
            {
                Console.WriteLine("On time");
                if (examTime == arriveTime)
                {
                    
                } 
                else
                {
                Console.WriteLine($"{examTime - arriveTime} minutes before the start");
                }
            } else if (examTime - arriveTime > 30)
            {
                Console.WriteLine("Early");
                if (examTime - arriveTime >= 60)
                {
                    int hr = (examTime - arriveTime) / 60;
                    int mins = (examTime - arriveTime) % 60;

                    if (mins < 10)
                    {
                        Console.WriteLine($"{hr}:0{mins} hours before the start");
                    } else
                    {

                    Console.WriteLine($"{hr}:{mins} hours before the start");
                    }
                } 
                else
                {
                Console.WriteLine($"{examTime - arriveTime} minutes before the start");

                }
            } else if (arriveTime > examTime)
            {
                Console.WriteLine("Late");
                if (arriveTime - examTime >= 60)
                {
                    int hr = (arriveTime - examTime) / 60;
                    int mins = (arriveTime - examTime) % 60;

                    if (mins < 10)
                    {
                        Console.WriteLine($"{hr}:0{mins} hours after the start");
                    }
                    else
                    {

                        Console.WriteLine($"{hr}:{mins} hours after the start");
                    }
                }
                else
                {
                    Console.WriteLine($"{arriveTime - examTime} minutes after the start");

                }

            }
        }
    }
}
