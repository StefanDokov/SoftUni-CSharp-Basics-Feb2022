


string input = Console.ReadLine();

string[] words = input.Split(' ');

Dictionary<string, int> occurrences = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

foreach (string word in words)
{
    if (occurrences.ContainsKey(word))
    {
        occurrences[word]++;
    }
    else
    {
        occurrences[word] = 1;
    }
}

var oddOccurrences = occurrences.Where(pair => pair.Value % 2 != 0);

foreach (var pair in oddOccurrences)
{
    Console.Write($"{pair.Key.ToLower()} ");
}