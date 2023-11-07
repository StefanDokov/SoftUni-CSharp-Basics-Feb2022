



int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < n; i++)
{
    char s = char.Parse(Console.ReadLine());

    sum += (int)s;


}

Console.WriteLine($"The sum equals: {sum}");