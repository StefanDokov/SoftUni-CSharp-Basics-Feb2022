


int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[,] matrix = new int[n[0], n[1]];

int eqalCells = 0;

for (int i = 0; i < n[0]; i++)
{
    Queue<char> q = new Queue<char>(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));

    for (int j = 0; j < n[1]; j++)
    {
        matrix[i, j] = q.Dequeue();
    }
}

for (int i = 0; i < n[0] - 1; i++)
{
    for (int j = 0;j < n[1] - 1; j++)
    {

        if (matrix[i, j] == matrix[i + 1, j] && matrix[i,j] == matrix[i, j+ 1] && matrix[i + 1, j + 1] == matrix[i, j])
        {
            eqalCells++;
        }



    }
}


Console.WriteLine(eqalCells);