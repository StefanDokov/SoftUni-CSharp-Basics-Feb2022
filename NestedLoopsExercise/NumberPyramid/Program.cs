

int n = int.Parse(Console.ReadLine());

int swift = 0;

bool isBul = false;

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(++swift + " ");
        if (swift == n)
        {
            Console.WriteLine();
            isBul = true;
            break;
        }
    }
    
    if (isBul)
    {
        break;
    }
    Console.WriteLine();
}