

string[] arr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToArray();


arr = arr.Reverse().ToArray();

Console.WriteLine(string.Join(" ", arr));