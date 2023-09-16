


int lilsAge = int.Parse(Console.ReadLine());
double washersCost = double.Parse(Console.ReadLine());
int toysPrice = int.Parse(Console.ReadLine());

int toys = 0;
int moneyCollected = 0;

for (int i = 1; i <= lilsAge; i++)
{
    if (i % 2 != 0)
    {
        toys++;
    }
    else
    {
        moneyCollected += i / 2 * 10 - 1;
    }
}

int fullMoney = moneyCollected + toys * toysPrice;

if (fullMoney >= washersCost)
{
    Console.WriteLine($"Yes! {fullMoney - washersCost:f2}");
}
else
{
    Console.WriteLine($"No! {washersCost - fullMoney:f2}");
}