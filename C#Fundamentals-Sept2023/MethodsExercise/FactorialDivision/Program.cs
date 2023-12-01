


List<string> list = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

list = list.OrderBy(x => x).ToList();
int i = 20;
foreach (var item in list)
{

    Console.WriteLine($"{item} {i++}");
}