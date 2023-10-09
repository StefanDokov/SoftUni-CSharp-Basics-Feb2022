



while (true)
{
    int n;
    bool isIt = int.TryParse(Console.ReadLine(), out n);

    if (!isIt)
    {
        break;
    }
    else
    {
        if (Math.Abs(n) % 2 == 0)
        {
            Console.WriteLine($"The number is: {Math.Abs(n)}");
        }
        else
        {
            Console.WriteLine("Please write an even number.");
        }
    }

}