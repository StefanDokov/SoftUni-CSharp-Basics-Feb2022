



string[] doubles = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

Dictionary<string, int> counts = new Dictionary<string, int>();

foreach (string el in doubles)
{
    if (!counts.ContainsKey(el))
    {
        counts.Add(el, 1);
    } 
    else
    {
        counts[el]++;
    }
}

string[] interesting = counts.Keys.ToArray();


foreach (string el in interesting)
{
    Console.WriteLine($"{el} - {counts[el]} times");
}