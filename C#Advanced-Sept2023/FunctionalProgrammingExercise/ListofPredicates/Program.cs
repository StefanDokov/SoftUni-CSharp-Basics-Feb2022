


List<Predicate<int>> predicates = new();

int endRange = int.Parse(Console.ReadLine());

HashSet<int> dividers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToHashSet();


int[] numb = Enumerable.Range(1, endRange).ToArray();

foreach (int div in dividers)
{
    predicates.Add(n => n % div == 0);
}

foreach (int n in numb)
{
    bool isDivisilbe = true;
    foreach (var pred in predicates)
    {
        if (!pred(n))
        {
            isDivisilbe = false;
            break;
        }
        
    }
    if (isDivisilbe)
    {
        Console.Write($"{n} ");
    }
}
