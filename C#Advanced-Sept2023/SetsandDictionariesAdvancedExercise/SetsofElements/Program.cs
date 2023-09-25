

int[] setLenghths = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();
HashSet<int> set = new HashSet<int>();

for (int i = 0; i < setLenghths[0];i++)
{
    int value = int.Parse(Console.ReadLine());
    firstSet.Add(value);
}

for (int i = 0; i < setLenghths[1]; i++)
{
    int value = int.Parse(Console.ReadLine());
    secondSet.Add(value);
}

if (firstSet.Count >= secondSet.Count)
{
    foreach (int value in secondSet)
    {
        if (firstSet.Contains(value))
        {
            set.Add(value);
        }
    }

}
else
{
    foreach (int value in firstSet)
    {
        if (secondSet.Contains(value))
        {
            set.Add(value);
        }
    }

}

Console.WriteLine(string.Join(" ", set));