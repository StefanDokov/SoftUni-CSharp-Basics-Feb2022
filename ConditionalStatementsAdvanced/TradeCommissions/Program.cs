using System;

namespace TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double percent = 0;
            bool isRight = false;
            switch (city)
            {
                case "Sofia":
                    
                    if (sales >= 0 && sales <= 500)
                    {
                        percent = sales * 0.05;
                    } 
                    if (sales > 500 && sales <= 1000)
                    {
                        percent = sales * 0.07;
                    }
                    if (sales > 1000 && sales <= 10000)
                    {
                        percent = sales * 0.08;
                    }
                    if (sales > 10000)
                    {
                        percent = sales * 0.12;
                    }
                    break;
                case "Varna":

                    if (sales >= 0 && sales <= 500)
                    {
                        percent = sales * 0.045;
                    }
                    if (sales > 500 && sales <= 1000)
                    {
                        percent = sales * 0.075;
                    }
                    if (sales > 1000 && sales <= 10000)
                    {
                        percent = sales * 0.1;
                    }
                    if (sales > 10000)
                    {
                        percent = sales * 0.13;
                    }
                    break;
                case "Plovdiv":

                    if (sales >= 0 && sales <= 500)
                    {
                        percent = sales * 0.055;
                    }
                    if (sales > 500 && sales <= 1000)
                    {
                        percent = sales * 0.08;
                    }
                    if (sales > 1000 && sales <= 10000)
                    {
                        percent = sales * 0.12;
                    }
                    if (sales > 10000)
                    {
                        percent = sales * 0.145;
                    }
                    break;
                    default:
                    isRight = true;
                    break;
            }
            if (isRight || percent == 0)
            {
                Console.WriteLine("error");
            } else
            {
                Console.WriteLine($"{percent:f2}");
            }
        }
    }
}
