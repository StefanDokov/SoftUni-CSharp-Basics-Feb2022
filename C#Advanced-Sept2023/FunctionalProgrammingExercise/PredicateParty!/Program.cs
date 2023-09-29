



using System.IO;

List<string> people = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string comand;
while ((comand = Console.ReadLine()) != "Party!")
{
    string[] tokens = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);

    string action = tokens[0];
    string filter = tokens[1];
    string value = tokens[2];

    if (action == "Remove")
    {
        people.RemoveAll(GetPredicate(filter, value));
    }
    else
    {
        List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));

        foreach (var s in peopleToDouble)
        {
            int index = people.FindIndex(p => p == s);
            people.Insert(index, s);
        }
    }


}

if (people.Any())
{
    Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

static Predicate<string> GetPredicate(string filter, string value)
{
    switch(filter)
    {
        case "StartsWith":
            return p => p.StartsWith(value);
        case "EndsWith":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        default:
            return default;

    }

}

