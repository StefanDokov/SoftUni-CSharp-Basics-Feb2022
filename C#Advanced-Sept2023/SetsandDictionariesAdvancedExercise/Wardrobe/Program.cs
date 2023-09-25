




int n = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, int>> clothes = new();
while (n > 0)
{
    string[] itemi = Console.ReadLine()
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string color = itemi[0];
    string[] parts = itemi[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();

    if (!clothes.ContainsKey(color))
    {
        clothes[color] = new Dictionary<string, int>();
    }
    
    foreach (string part in parts)
    {
        if (!clothes[color].ContainsKey(part))
        {
            clothes[color].Add(part, 1);
        }
        else
        {
            clothes[color][part]++;
        }

    }
    


    n--;
}

string[] searcher = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

string searchColor = searcher[0];
string searchPart = searcher[1];

foreach (var part in clothes)
{
    Console.WriteLine($"{part.Key} clothes:");
    foreach (var dress in part.Value) {
        if (part.Key == searchColor && dress.Key == searchPart && dress.Value > 0) { 
        Console.WriteLine($"* {dress.Key} - {dress.Value} (found!)");
        } 
        else
        {
            Console.WriteLine($"* {dress.Key} - {dress.Value}");

        }

    }
}