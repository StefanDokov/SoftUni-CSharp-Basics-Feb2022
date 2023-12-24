


int numbersOfCommand = int.Parse(Console.ReadLine());
List<string> guests = new List<string>();

for (int i = 0; i < numbersOfCommand; i++)
{
    string command = Console.ReadLine();
    string[] commandArray = command.Split().ToArray();
    string name = commandArray[0];

    if (commandArray.Count() == 3)
    {
        if (guests.Contains(name) == false)
        {
            guests.Add(name);
        }

        else
        {
            Console.WriteLine($"{name} is already in the list!");
        }

    }

    else if (commandArray.Count() == 4)
    {
        if (guests.Contains(name))
        {
            guests.Remove(name);

        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }

    }

}

foreach (var item in guests)
{
    Console.WriteLine(item);
}