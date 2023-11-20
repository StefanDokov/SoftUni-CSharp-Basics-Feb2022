

string[] first = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

string[] second = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

foreach (var item in second)
{
    foreach (var item2 in first)
    {
        if (item.CompareTo(item2) == 0)
        {
            Console.Write(item + " ");
        }
    }
}

Console.WriteLine();