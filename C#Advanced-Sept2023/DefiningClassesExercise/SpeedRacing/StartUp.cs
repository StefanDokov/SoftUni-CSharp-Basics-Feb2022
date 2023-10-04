


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());

            List<Car> allCars = new();

            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                Car car = new(carInfo[0], double.Parse(carInfo[1]), double.Parse(carInfo[2]));

                allCars.Add(car);
            }

            while (true)
            {
                string action = Console.ReadLine();

                if (action == "End")
                {
                    foreach (Car car in allCars)
                    {
                        Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
                    }
                    break;
                }

                string[] disedAction = action
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (Car car in allCars)
                {
                    if (car.Model == disedAction[1])
                    {
                        car.IsItEnough(int.Parse(disedAction[2]));
                    }
                }


            }





        }



    }
}
