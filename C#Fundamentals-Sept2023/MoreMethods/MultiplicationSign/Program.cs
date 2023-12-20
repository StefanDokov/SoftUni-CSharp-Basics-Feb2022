
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

PrintResult(num1, num2, num3);

static void PrintResult(int num1, int num2, int num3)
{
    if (IsZero(num1, num2, num3))
    {
        Console.WriteLine("zero");
    }
    else if (IsNegative(num1, num2, num3))
    {
        Console.WriteLine("negative");
    }
    else
    {
        Console.WriteLine("positive");
    }
}


static bool IsZero(int num1, int num2, int num3)
{
    if (num1 == 0 ||
        num2 == 0 ||
        num3 == 0)
    {
        return true;
    }
    return false;
}

static bool IsNegative(int num1, int num2, int num3)
{
    int[] numbers = new int[] { num1, num2, num3 };
    int counter = 0;
    for (int i = 0; i < 3; i++)
    {
        if (numbers[i] < 0)
        {
            counter++;
        }
    }
    if (counter % 2 == 0)
    {
        return false;
    }
    return true;
}