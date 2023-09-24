


int n = int.Parse(Console.ReadLine());
Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();


while (n > 0)
{
    string[] location = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
    string continent = location[0];
    string country = location[1];
    string city = location[2];

    if (!continents.ContainsKey(continent))
    {
        continents[continent] = new Dictionary<string, List<string>>();
    }

    if (!continents[continent].ContainsKey(country))
    {
        continents[continent][country] = new List<string>();

    }
    continents[continent][country].Add(city);



    n--;
}

foreach (var el in continents)
{
    Console.WriteLine($"{el.Key}:");
    foreach (var ele in el.Value)
    {
        Console.WriteLine($"  {ele.Key} -> {string.Join(", ", ele.Value)}");
    }
}