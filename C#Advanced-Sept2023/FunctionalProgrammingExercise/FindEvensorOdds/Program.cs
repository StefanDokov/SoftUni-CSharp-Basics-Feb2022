



Func<int, int, List<int>> generateRange = (start, end) =>
{
    List<int> result = new List<int>();


    for (int i = start; i <= end; i++)
    {
        result.Add(i);
    }

    return result;
};


Func<string, int, bool> checker = (type, num) =>
{
    if (type == "even")
    {
        return num % 2 == 0;
    }
    else
    {
        return num % 2 != 0;
    }
};

int[] range = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToArray();

string type = Console.ReadLine();

List<int> numbers = generateRange(range[0], range[1]);

foreach (int number in numbers)
{
    if (checker(type, number))
    {
        Console.Write($"{number} ");
    }
    
}

Console.WriteLine();