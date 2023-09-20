


int rowscols = int.Parse(Console.ReadLine());


int[,] matrix = new int[rowscols, rowscols];

int sum = 0;

for (int i = 0; i < rowscols; i++)
{
    Queue<int> els = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

    for (int j = 0; j < rowscols; j++)
    {
        matrix[i, j] = els.Dequeue();
    }
}

for (int i = 0; i < rowscols; i++)
{
    sum += matrix[i, i];
}

Console.WriteLine(sum);