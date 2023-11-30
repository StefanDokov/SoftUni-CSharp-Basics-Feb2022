


List<int> biggest = new();


for (int i = 0;i < 3; i++)
{
    biggest.Add(int.Parse(Console.ReadLine()));
}

int best = biggest.OrderBy(n => n).FirstOrDefault();

Console.WriteLine(best);