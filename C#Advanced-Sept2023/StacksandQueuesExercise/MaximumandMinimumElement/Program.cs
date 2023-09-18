



int n = int.Parse(Console.ReadLine());
Stack<int> into = new Stack<int>();

for (int i = 0; i < n; i++)
{

    int[] see = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    if (see[0] == 1)
    {
        into.Push(see[1]);
    }
    if (see[0] == 2)
    {
        into.Pop();
    }
    if (see[0] == 3)
    {
        if(into.Count == 0)
        {
            continue;
        }
        Console.WriteLine(into.Max());
    }
    if (see[0] == 4)
    {
        if (into.Count == 0)
        {
            continue;
        }
        Console.WriteLine(into.Min());
    }

}
if (into.Count > 0)
{

Console.WriteLine(string.Join(", ", into));
}