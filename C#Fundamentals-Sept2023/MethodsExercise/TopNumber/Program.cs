

int n = int.Parse(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    if (IsTopNumber(i))
    {
        Console.WriteLine(i);
    }
}

    static bool IsTopNumber(int number)
{
    int sumOfDigits = 0;
    int num = number;

    while (num > 0)
    {
        sumOfDigits += num % 10;
        num /= 10;
    }

    if (sumOfDigits % 8 != 0)
    {
        return false;
    }

    num = number;

    while (num > 0)
    {
        int digit = num % 10;
        if (digit % 2 != 0)
        {
            return true;
        }

        num /= 10;
    }

    return false;
}