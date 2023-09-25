



int n = int.Parse(Console.ReadLine());

SortedSet<string> result = new SortedSet<string>();
while (n > 0)
{
    string[] elements = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    foreach (string element in elements)
    {
        result.Add(element);
    }



    n--;
}

Console.WriteLine(string.Join(" ", result));