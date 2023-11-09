

int input = int.Parse(Console.ReadLine());


try
{
    Print(input);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
Console.WriteLine("Goodbye.");

}


static void Print(int input)
{


    if (input >= 0)
    {
        Console.WriteLine(Math.Sqrt(input));
    }
    else
    {
        throw new Exception("Invalid number.");
    }

}