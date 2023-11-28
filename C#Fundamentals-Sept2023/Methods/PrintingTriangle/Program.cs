



int n = int.Parse(Console.ReadLine());


treer(n);

static void treer(int n)
{
    
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }

    for (int i = n; i > 1; i--)
    {
        for (int j = 1; j < i; j++)
        {
            Console.Write(j + " ");
        }
        Console.WriteLine();
    }


}