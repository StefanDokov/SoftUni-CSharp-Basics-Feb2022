


int n  = int.Parse(Console.ReadLine()); 

int[,] matrix = new int[n, n];

int mainDiagonal = 0;
int oppositeDiagonal = 0;

int h = n - 1;
int g = 0;

for (int i = 0; i < n; i++)
{
    Queue<int> q = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));

    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = q.Dequeue();
    }
}

for (int i = 0;i < n; i++)
{
    for (int j = 0;j < n; j++)
    {
        if (i == j)
        {
            mainDiagonal += matrix[i,j];
        }

       
    }
}

while (h >= 0)
{
    oppositeDiagonal += matrix[g, h];

    h--;
    g++;
}

Console.WriteLine(Math.Abs(mainDiagonal - oppositeDiagonal));