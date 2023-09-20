


int rows = int.Parse(Console.ReadLine());


long[][] q = new long[rows][];


for (int i = 0; i < rows; i++)
{
    q[i] = new long[i + 1];


}
q[0][0] = 1;

for (int i = 1;i < rows; i++)
{
    for (int j = 0; j < q[i].Length; j++)
    {
        if (j - 1 >= 0 && j < q[i - 1].Length)
        {
         q[i][j] = q[i - 1][j] + q[i - 1][j - 1];

        } 
        else if (j - 1 < 0)
        {
            q[i][j] = q[i - 1][j] + 0;
        }
        else if (j >= q[i - 1].Length)
        {
            q[i][j] = q[i - 1][j - 1] + 0;
        }
        
    }
}

for (int i = 0; i < rows; i++)
{
    for(int j = 0;j < q[i].Length; j++)
    {
        Console.Write(q[i][j] + " ");
    }
    Console.WriteLine();
}