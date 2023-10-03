

int primeSum = 0;
int nonPrimeSum = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "stop")
    {
        Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
        Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        break;
    }
    int current = int.Parse(input);

    if (current < 0) 
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    if (current == 0 || current == 1)
    {
        nonPrimeSum += current;
    }
    bool isIt = false;
    for (int i = 2; i < current; i++)
    {
        if (current % i == 0)
        {
            nonPrimeSum += current;
            isIt = true;
            break;
        }
    }
    if (!isIt)
    {
        primeSum += current;
    }


}