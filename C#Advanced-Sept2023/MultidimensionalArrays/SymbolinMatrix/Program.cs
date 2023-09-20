



int rowscols = int.Parse(Console.ReadLine());


int[,] matrix = new int[rowscols, rowscols];



for (int i = 0; i < rowscols; i++)
{
    string input = Console.ReadLine();

    Queue<char> els = new Queue<char>(input);

    

    for (int j = 0; j < rowscols; j++)
    {
        matrix[i, j] = els.Dequeue();
    }
}

char symbol = char.Parse(Console.ReadLine());
bool hasIt = false;

for (int i = 0; i < rowscols; i++)
{
    for (int j = 0; j < rowscols; j++)
    {
        if (matrix[i, j] == symbol)
        {
            Console.WriteLine($"({i}, {j})");
            hasIt = true;
            break;
        }
    }
    if (hasIt)
    {
        break;
    }
    
}

if (!hasIt)
{
Console.WriteLine($"{symbol} does not occur in the matrix");

}