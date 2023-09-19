


int greenLight = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

string carType = Console.ReadLine();
Queue<string> cars = new Queue<string>();
int passedCars = 0;
bool isOver = false;
int currentTime = greenLight;
bool bonus = false;

while (carType != "END")
{
    if (carType != "green")
    {
        cars.Enqueue(carType);
    }
    if (carType == "green")
    {
        if (cars.Count == 0)
        {
            break;
        }
        else
        {
            while (cars.Count > 0)
            {
                string car = cars.Dequeue();


                if (car.Length < currentTime && !bonus)
                {
                    currentTime -= car.Length;
                    passedCars++;
                    continue;
                }
                else if (car.Length >= currentTime && !bonus)
                {
                    currentTime += freeWindow;
                    bonus = true;
                }

                if (car.Length > currentTime && bonus)
                {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{car} was hit at {car[currentTime]}.");
                    Environment.Exit(0);
                    break;
                }
                else if (car.Length <= currentTime && bonus)
                {
                    passedCars++;
                    break;
                }

                if (bonus)
                {
                    break;
                }


            }
            currentTime = greenLight;
            bonus = false;


        }


    }


    if (isOver)
    {
        break;
    }

    carType = Console.ReadLine();
}

if (!isOver)
{
    Console.WriteLine("Everyone is safe.");
    Console.WriteLine($"{passedCars} total cars passed the crossroads.");
}