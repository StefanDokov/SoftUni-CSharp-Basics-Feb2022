


int stepsTaken = 0;
bool going = false;
while (true)
{
    string steps = Console.ReadLine();

    if (steps == "Going home")
    {
        int lastSteps = int.Parse(Console.ReadLine());

        stepsTaken += lastSteps;

       going = true;
       

    } else
    {
        stepsTaken += int.Parse(steps);
    }

    if (stepsTaken < 10000 && going)
    {
        Console.WriteLine($"{10000 - stepsTaken} more steps to reach goal.");
        break;
    }
    
    if (stepsTaken >= 10000)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{stepsTaken - 10000} steps over the goal!");
        break;
    }



}