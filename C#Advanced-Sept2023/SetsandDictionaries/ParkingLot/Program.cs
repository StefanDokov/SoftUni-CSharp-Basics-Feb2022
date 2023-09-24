




string comand = Console.ReadLine();

HashSet<string> cars = new HashSet<string>();

while (comand != "END")
{
    string[] nextStep = comand.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string operation = nextStep[0];
    string licencePlate = nextStep[1];


    if (operation == "IN")
    {
        cars.Add(licencePlate);
    }
    if (operation == "OUT")
    {
        cars.Remove(licencePlate);
    }


    comand = Console.ReadLine();
}

if (cars.Count > 0)
{
    foreach (string car in cars)
    {
        Console.WriteLine(car);
    }
} 
else
{
    Console.WriteLine("Parking Lot is Empty");
}