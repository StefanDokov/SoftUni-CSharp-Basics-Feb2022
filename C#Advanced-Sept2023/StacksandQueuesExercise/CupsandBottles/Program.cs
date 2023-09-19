



Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));


int wastedWater = 0;
int currentCup = 0;

bool cupsOver = false;

while (cups.Count > 0)
{
    if (currentCup == 0)
    {
        currentCup = cups.Peek();
    }
    
    int currentBottle = bottles.Pop();

    if (currentCup <= currentBottle)
    {
        cups.Dequeue();
        wastedWater += currentBottle - currentCup;
        currentCup = 0;
    } else
    {
        currentCup -= currentBottle;
    }

    if (bottles.Count == 0)
    {
        string leftovers = string.Join(" ", cups);
        Console.WriteLine($"Cups: {leftovers}");
        Console.WriteLine($"Wasted litters of water: {wastedWater}");
        cupsOver = true;
        break;
    }



}

if (!cupsOver && bottles.Count > 0)
{
    string bottlesLeft = string.Join(" ", bottles);
    Console.WriteLine($"Bottles: {bottlesLeft}");
    Console.WriteLine($"Wasted litters of water: {wastedWater}");
}