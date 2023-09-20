




int rows = int.Parse(Console.ReadLine());

int[][] jagged = new int[rows][];

for (int i = 0; i < rows; i++)
{
    int[] q = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

    jagged[i] = new int[q.Length];

    for (int j = 0; j < q.Length; j++)
    {
        jagged[i][j] = q[j];
    }
}

string input = Console.ReadLine();

while (input != "END")
{
    Queue<string> qtwo = new Queue<string>(input.Split(" "));

    string cmnd = qtwo.Dequeue();

    if (cmnd == "Add")
    {
        int firstRow = int.Parse(qtwo.Dequeue());
        int firstCol = int.Parse(qtwo.Dequeue());

        if (firstRow >= rows || firstRow < 0 || firstCol < 0 || firstCol >= jagged[firstRow].Length) {
            Console.WriteLine("Invalid coordinates");
            
        } 
        else
        {
            jagged[firstRow][firstCol] += int.Parse(qtwo.Dequeue());
        }

    }
    if (cmnd == "Subtract")
    {
        int firstRow = int.Parse(qtwo.Dequeue());
        int firstCol = int.Parse(qtwo.Dequeue());

        if (firstRow >= rows || firstRow < 0 || firstCol < 0 || firstCol >= jagged[firstRow].Length)
        {
            Console.WriteLine("Invalid coordinates");
            
        }
        else
        {
            jagged[firstRow][firstCol] -= int.Parse(qtwo.Dequeue());
        }

    }




    input = Console.ReadLine();
}

for (int i = 0; i < jagged.Length; i++)
{
    for (int j = 0; j < jagged[i].Length; j++)
    {
        Console.Write(jagged[i][j] + " ");
    }
    Console.WriteLine();
}