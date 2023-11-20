

int n = int.Parse(Console.ReadLine());


int[] first = new int[n];
int[] second = new int[n];

for (int i = 0; i < n; i++)
{
    int[] curr = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    if (i % 2 == 0)
    {

    first[i] = curr[0];
    second[i] = curr[1];
    } else
    {
        second[i] = curr[0];
        first[i] = curr[1];
    }
}


Console.WriteLine(string.Join(" ", first));
Console.WriteLine(string.Join(" ", second));