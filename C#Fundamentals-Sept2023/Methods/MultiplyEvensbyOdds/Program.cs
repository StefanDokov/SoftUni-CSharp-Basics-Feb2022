


using System.Security.Cryptography;

int n = Math.Abs(int.Parse(Console.ReadLine()));


int result = GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);

Console.WriteLine(result);


static int GetSumOfEvenDigits(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int mid = n % 10;

        if (mid % 2 == 0)
        {
            sum += mid;
        }
       

        n /= 10;
    }
    return sum;
}

static int GetSumOfOddDigits(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int mid = n % 10;

        if (mid % 2 != 0)
        {
            sum += mid;
        }


        n /= 10;
    }
    return sum;
}