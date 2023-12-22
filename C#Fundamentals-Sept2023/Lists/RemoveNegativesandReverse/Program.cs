



List<int> list = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();


list.RemoveAll(n  => n < 0);

list.Reverse();

if (list.Count == 0)
{
    Console.WriteLine("empty");
}
else
{


    Console.WriteLine(string.Join(" ", list));
}