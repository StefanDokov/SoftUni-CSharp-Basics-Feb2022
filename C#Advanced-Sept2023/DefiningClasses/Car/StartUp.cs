using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] inputs)
        {
           Car car = new Car();

            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 2006;


            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}

