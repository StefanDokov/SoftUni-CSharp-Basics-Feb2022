

List<int> sorter = new();
for (int i = 0; i < 3; i++)
{
    sorter.Add(int.Parse(Console.ReadLine()));
}

foreach (int i in sorter.OrderByDescending(i => i))
{
    Console.WriteLine(i);
}