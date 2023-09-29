



HashSet<int> ints = new HashSet<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToHashSet());


Func<HashSet<int>, int> min = numbers =>
{
    int min = int.MaxValue;

    foreach (int i in numbers)
    {
        if (i < min)
        {
            min = i;
        }
    }
    return min;
};


Console.WriteLine(min(ints));