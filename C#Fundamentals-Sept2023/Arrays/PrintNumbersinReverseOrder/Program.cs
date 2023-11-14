


int n = int.Parse(Console.ReadLine());


int[] ints = new int[n];

for (int i = 0; i < n; i++)
{
    int current = int.Parse(Console.ReadLine());
    ints[i] = current;
}

ints = ints.Reverse().ToArray();

Console.WriteLine(string.Join(" ", ints));