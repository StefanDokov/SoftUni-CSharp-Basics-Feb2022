


Action<string[]> print = (string[] strings) =>
{
    foreach (string s in strings)
    {
        Console.WriteLine(s);
    }
};

string[] strings = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


print(strings);