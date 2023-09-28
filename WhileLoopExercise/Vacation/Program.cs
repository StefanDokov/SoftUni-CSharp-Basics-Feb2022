



double cost = double.Parse(Console.ReadLine());
double wallet = double.Parse(Console.ReadLine());

int daysPased = 0;
int spending = 0;

while (wallet < cost)
{
    daysPased++;
    string biding = Console.ReadLine();

    double amount = double.Parse(Console.ReadLine());

    if (biding == "spend")
    {
        wallet -= amount;
        if (wallet < 0)
        {
            wallet = 0;
        }
        spending++;
    }
    if (spending == 5)
    {
        Console.WriteLine($"You can't save the money.");
        Console.WriteLine(daysPased);
        break;
    }
    if (biding == "save")
    {
        wallet += amount;
        spending = 0;
    }



    
}
if (spending < 5)
{
    Console.WriteLine($"You saved the money for {daysPased} days.");
}