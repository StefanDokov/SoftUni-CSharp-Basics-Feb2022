



int[] n = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[,] matrix = new int[n[0], n[1]];

int maxSum = int.MinValue;
int sum = 0;
int[,] middle = new int[3, 3];

int[,] maxMatrix = new int[3, 3];

for (int i = 0; i < n[0]; i++)
{
    Queue<int> q = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

    for (int j = 0; j < n[1]; j++)
    {
        matrix[i, j] = q.Dequeue();
    }
}

for (int i = 0;i < n[0] - 2; i++)
{
    for (int j = 0;j < n[1] - 2; j++)
    {
        for (int k = 0;k < 3; k++)
        {
            for (int s = 0; s < 3; s++) { 
            sum += matrix[i + k, j + s];
            middle[k, s] = matrix[i + k, j + s];
            }
        }
        if (sum > maxSum)
        {
            maxSum = sum;
            maxMatrix = middle;
            middle = new int[3, 3];
        }
        sum = 0;
    }
}



Console.WriteLine($"Sum = {maxSum}");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(maxMatrix[i, j] + " ");
    }
    Console.WriteLine();
}