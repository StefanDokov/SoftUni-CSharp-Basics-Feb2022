



Action<string[], Predicate<string>> print = (names, match) =>
{
    foreach (string name in names)
    {
        if (match(name))
        {
            Console.WriteLine(name);
        }
    }

};

int n = int.Parse(Console.ReadLine());

Predicate<string> lenghter = (name) => name.Length <= n;

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(names, lenghter);
