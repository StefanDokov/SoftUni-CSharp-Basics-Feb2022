


int input = int.Parse(Console.ReadLine());

Printer(input);



static void Printer(int n)
{

    if (n == 0)
    {
        Console.WriteLine($"The number {n} is zero.");
    }

    if (n > 0)
    {
        Console.WriteLine($"The number {n} is positive.");

    }

    if (n < 0 )
    {
        Console.WriteLine($"The number {n} is negative.");
    }




}