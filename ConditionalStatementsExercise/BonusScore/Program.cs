using System;

namespace BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bonusPoints = int.Parse(Console.ReadLine());
            double percent = 0;

            if (bonusPoints <= 100)
            {
                percent = 5;
                
            }
            if (bonusPoints > 100 && bonusPoints <= 1000)
            {
                percent = bonusPoints * 0.2;
            }
            if (bonusPoints > 1000)
            {
                percent = bonusPoints * 0.1;
            }

            if (bonusPoints % 2 == 0)
            {
                percent += 1;
            }
            if ((bonusPoints - 5) % 10 == 0)
            {
                percent += 2;
            }

            Console.WriteLine(percent.ToString());
            Console.WriteLine(bonusPoints + percent);
        }
    }
}
