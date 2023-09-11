using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annuallyCost = int.Parse(Console.ReadLine());

            double basketShoes = annuallyCost * 0.60;
            double basketTop = basketShoes * 0.80;
            double basketBall = basketTop * 0.25;
            double accesories = basketBall * 0.20;

            Console.WriteLine(basketBall + basketShoes + accesories + basketTop + annuallyCost);
        }
    }
}
