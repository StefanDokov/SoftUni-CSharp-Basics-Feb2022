



using System.Text;

Stack<int> fuel = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


Queue<int> consumption = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> altitude = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

bool isOver = false;

int curralt = 1;
List<string> reacher = new();
while (altitude.Count > 0)
{
    int fueler = fuel.Pop();
    int consupter = consumption.Dequeue();

    int currAltitude = altitude.Dequeue();

    int currentFuel = fueler - consupter;

    if (currentFuel < currAltitude)
    {
        
        Console.WriteLine($"John did not reach: Altitude {curralt}");

        isOver = true;
        break;
    }
    else
    {
        Console.WriteLine($"John has reached: Altitude {curralt}");
        reacher.Add($"Altitude {curralt}");
        curralt++;
    }


}

if (isOver)
{
    if (reacher.Count == 0)
    {
        Console.WriteLine("John failed to reach the top.");
        Console.WriteLine("John didn't reach any altitude.");
    }
    else
    {
    Console.WriteLine("John failed to reach the top.");
    Console.WriteLine($"Reached altitudes: {string.Join(", ", reacher).TrimEnd()}");

    }
}
else
{
    Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
}

