

int n = int.Parse(Console.ReadLine());

for (int number = 2; number <= n; number++)
{
    string isPrime = IsPrime(number);

    Console.WriteLine($"{number} -> {isPrime}");
}

static string IsPrime(int num)
{
    if (num < 2)
    {
        return "false";
    }

    for (int divisor = 2; divisor < num; divisor++)
    {
        if (num % divisor == 0)
        {
            return "false";
        }
    }

    return "true";
}