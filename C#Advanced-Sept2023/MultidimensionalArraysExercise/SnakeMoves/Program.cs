



int[] n = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

char[,] matrix = new char[n[0], n[1]];

int rows = n[0];
int cols = n[1];

string input = Console.ReadLine();

Queue<char> q = new Queue<char>();

foreach (char c in input)
{
    q.Enqueue(c);
}


int counter = 0;

while (counter < rows)
{
    if (counter % 2 == 0)
    {
        for (int i = 0; i < cols; i++)
        {
            char top = q.Dequeue();
            matrix[counter, i] = top;
            q.Enqueue(top);
        }
    } 
    else
    {
        for (int i = cols - 1; i >= 0; i--) {
            char top = q.Dequeue();
            matrix[counter, i] = top;
            q.Enqueue(top);
        }
    }
    counter++;
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j]);
    }
    Console.WriteLine();
}