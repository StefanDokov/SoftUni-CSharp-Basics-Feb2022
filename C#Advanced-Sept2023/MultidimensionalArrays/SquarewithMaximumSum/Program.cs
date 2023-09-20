



int[] rowscols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int rows = rowscols[0];
int cols = rowscols[1];


int[,] matrix = new int[rows, cols];
int[,] bestMatrix = new int[2, 2];

int currentSum = 0;
int maxSum = int.MinValue;

for (int i = 0; i < rows; i++)
{
    Queue<int> els = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));

    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = els.Dequeue();
    }
}
for (int i = 0; i < rows - 1; i++)
{
    for (int j = 0;j < cols - 1; j++)
    {
        currentSum += matrix[i, j];
        currentSum += matrix[i, j + 1];
        currentSum += matrix[i + 1, j];
        currentSum += matrix[i + 1, j + 1];

        if (currentSum > maxSum)
        {
            maxSum = currentSum;
            bestMatrix[0,0] = matrix[i, j];
            bestMatrix[0,1] = matrix[i, j + 1];
            bestMatrix[1,0] = matrix[i + 1, j];
            bestMatrix[1,1] = matrix[i + 1, j + 1];
            
        }
        currentSum = 0;
    }
    

}

for (int i = 0;i < bestMatrix.GetLength(0); i++)
{
    for(int j = 0;j < bestMatrix.GetLength(1); j++)
    {
        Console.Write(bestMatrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(maxSum);