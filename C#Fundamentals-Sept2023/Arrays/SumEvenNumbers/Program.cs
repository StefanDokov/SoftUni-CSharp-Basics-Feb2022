


int[] arr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int sum = 0;
foreach (int i in arr)
{
    if (i % 2 == 0)
    {
        sum += i;
    }
}

Console.WriteLine(sum);