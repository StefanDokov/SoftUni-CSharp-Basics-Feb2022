

Queue<string> children = new Queue<string>(Console.ReadLine().Split());

int tossCount = int.Parse(Console.ReadLine());
int toss = 0;

while (children.Count > 1)
{
    toss++;
    string childWithPotato = children.Dequeue();

    if (toss == tossCount)
    {
        toss = 0;
        Console.WriteLine($"Removed {childWithPotato}");
    } 
    else
    {
        children.Enqueue(childWithPotato);
    }

}

Console.WriteLine($"Last is {children.Dequeue()}");