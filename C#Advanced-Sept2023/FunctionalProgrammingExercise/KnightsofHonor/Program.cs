




Action<string[]> print = strings =>
{
    foreach (string item in strings)
    {
        Console.WriteLine($"Sir {item}");
    }
};

string[] people = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

print(people);