


double input = double.Parse(Console.ReadLine());

Grader(input);
static void Grader(double n)
{

    if (n >= 2d && n < 3d)
    {
        Console.WriteLine("Fail");
    }
    if (n >= 3d && n < 3.5d)
    {
        Console.WriteLine("Poor");
    }
    if (n >= 3.5d && n < 4.5d)
    {
        Console.WriteLine("Good");

    }
    if (n >= 4.5d && n < 5.5d)
    {
        Console.WriteLine("Very good");
    }
    if (n >= 5.5d && n <= 6d)
    {
        Console.WriteLine("Excellent");
    }




}