


int n = int.Parse(Console.ReadLine());

int y = 1;
for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= y; j++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
    y++;
}