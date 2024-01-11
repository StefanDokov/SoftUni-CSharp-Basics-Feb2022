


string input = Console.ReadLine();

int[] numbers = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

Dictionary<int, int> occurrences = new Dictionary<int, int>();

foreach (int num in numbers)
{
    if (occurrences.ContainsKey(num))
    {
        occurrences[num]++;
    }
    else
    {
        occurrences[num] = 1;
    }
}

var sortedOccurrences = occurrences.OrderBy(pair => pair.Key);

foreach (var pair in sortedOccurrences)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}