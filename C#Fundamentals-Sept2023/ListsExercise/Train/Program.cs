


List<int> wagons = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

int maxCapacity = int.Parse(Console.ReadLine());

string input;
while ((input = Console.ReadLine()) != "end")
{
    string[] command = input.Split();

    if (command[0] == "Add")
    {
        int passengersToAdd = int.Parse(command[1]);
        wagons.Add(passengersToAdd);
    }
    else
    {
        int passengersToBoard = int.Parse(command[0]);

        for (int i = 0; i < wagons.Count; i++)
        {
            if (wagons[i] + passengersToBoard <= maxCapacity)
            {
                wagons[i] += passengersToBoard;
                break;
            }
        }
    }
}

Console.WriteLine(string.Join(" ", wagons));