



int n = int.Parse(Console.ReadLine());

int result = 0;

for (int i = 1; i <= n; i++)
{
    int adder = int.Parse(Console.ReadLine());
    result += adder;
}

Console.WriteLine(result);