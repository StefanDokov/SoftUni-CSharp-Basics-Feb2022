


int first = int.Parse(Console.ReadLine());

int second = int.Parse(Console.ReadLine());

double firstFact = CalculateFactorial(first);
double secondFact = CalculateFactorial(second);

double result = firstFact / secondFact;

Console.WriteLine($"{result:F2}");

    static double CalculateFactorial(int n)
{
    if (n == 0 || n == 1)
        return 1;

    double result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }

    return result;
}