


Queue<int> tools = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> substances = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

List<int> challanges = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList());

while (challanges.Count > 0)
{
    int currentTool = tools.Dequeue();
    int currentSubstance = substances.Pop();
    int sum = currentTool * currentSubstance;

    if (challanges.Contains(sum))
    {
        challanges.Remove(sum);

    }
    else
    {
        tools.Enqueue(currentTool + 1);
        if (currentSubstance - 1 > 0)
        {
         substances.Push(currentSubstance - 1);

        }
    }

    if ((tools.Count == 0 || substances.Count == 0) && challanges.Count > 0)
    {
        Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
        break;
    }



}

if (challanges.Count == 0)
{
    Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
}

if (tools.Count > 0)
{
    Console.WriteLine($"Tools: {string.Join(", ", tools)}");
}

if (substances.Count > 0)
{
    Console.WriteLine($"Substances: {string.Join(", ", substances)}");
}

if (challanges.Count > 0)
{
    Console.WriteLine($"Challenges: {string.Join(", ", challanges)}");
}