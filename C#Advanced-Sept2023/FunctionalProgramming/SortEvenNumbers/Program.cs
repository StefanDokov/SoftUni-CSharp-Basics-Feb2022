



using System.Runtime.InteropServices;

int[] numbers = Console.ReadLine()
    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
    .Select(x => int.Parse(x))
    .Where(x => x % 2 == 0)
    .OrderBy(x => x)
    .ToArray();


string result = String.Join(", ", numbers);
Console.WriteLine(result);