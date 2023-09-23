

int rows = int.Parse(Console.ReadLine());

int[][] jagged = new int[rows][];


for (int i = 0; i < rows; i++)
{
    int[] q = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    jagged[i] = new int[q.Length];

    for (int j = 0; j < q.Length; j++)
    {
        jagged[i][j] = q[j];
    }
}


for (int k = 0; k < jagged.Length - 1; k++)
{
    if (jagged[k].Length == jagged[k + 1].Length)
    {
        for (int j = 0; j < jagged[k].Length; j++)
        {
            jagged[k][j] *= 2;
            jagged[k + 1][j] *= 2;

        }
        
    } 
    else
    {
        for (int j = 0; j < jagged[k].Length; j++)
        {
            jagged[k][j] /= 2;
            
        }
        for (int s = 0; s < jagged[k + 1].Length; s++)
        {
            jagged[k + 1][s] /= 2;
        }
    }
}

string comand = Console.ReadLine();

while (comand != "End")
{
    string[] nextTask = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

    int row = int.Parse(nextTask[1]);
    int col = int.Parse(nextTask[2]);
    int value = int.Parse(nextTask[3]);

    if (ValidateCell(row, col, jagged))
    {


    if (nextTask[0] == "Add")
    {
        
        jagged[row][col] += value; 

        
    }
    if (nextTask[0] == "Subtract")
    {
        
            jagged[row][col] -= value;

        
    }
    }


    comand = Console.ReadLine();
}


for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write(jagged[i][j] + " ");
    }
    Console.WriteLine();
}

static bool ValidateCell(int row, int col, int[][] jaggedArray)
{
    return
        row >= 0
        && row < jaggedArray.Length
        && col >= 0
        && col < jaggedArray[row].Length;
}