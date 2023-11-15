


using System.Diagnostics;

int[] firstArr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] secondArr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int sum = 0;
bool areThey = false;

for (int i = 0; i < firstArr.Length; i++)
{
    if (firstArr[i] != secondArr[i])
    {
        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
        areThey = true;
        break;
    }
    else
    {
        sum += firstArr[i];
    }
}

if (!areThey) 
{
    Console.WriteLine($"Arrays are identical. Sum: {sum}");
}