


int capacity = 255;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int current = int.Parse(Console.ReadLine());

    if (capacity - current >= 0)
    {
        capacity -= current;
    }
    else
    {
        Console.WriteLine("Insufficient capacity!");
    }

}

Console.WriteLine(255 - capacity);