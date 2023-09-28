



decimal change = decimal.Parse(Console.ReadLine());

int coins = 0;

while (change > 0)
{
    if (change >= 2)
    {
        change -= 2;
        coins++;
    } 
    else if (change < 2 && change >= 1)
    {
        change -= 1;
        coins++;
    } 
    else if (change < 1 && change >= 0.50m)
    {
        change -= 0.50m;
        coins++;
    } 
    else if (change < 0.50m && change >= 0.20m)
    {
        change -= 0.20m;
        coins++;
    } 
    else if (change < 0.2m && change >= 0.1m)
    {
        change -= 0.1m;  
        coins++;
    } 
    else if (change < 0.1m && change >= 0.05m)
    {
        change -= 0.05m;
        coins++;
    }
    else if (change < 0.05m && change >= 0.02m)
    {
        change -= 0.02m;
        coins++;
    }
    else if (change < 0.02m && change >= 0.01m)
    {
        change -= 0.01m;
        coins++;
    }


}

Console.WriteLine(coins);