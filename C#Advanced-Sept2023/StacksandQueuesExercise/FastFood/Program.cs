



int orders = int.Parse(Console.ReadLine());

Queue<int> waiters = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

Console.WriteLine(waiters.Max());

bool isOver = false;

while (waiters.Count > 0 && orders > 0)
{
    int currentOrder = waiters.Peek();

    if (currentOrder <= orders)
    {
        orders -= currentOrder;
        waiters.Dequeue();
    }
    else
    {
        Console.WriteLine($"Orders left: {string.Join(" ", waiters)}");
        isOver = true;
        break;
    }
}
if (waiters.Count == 0 && orders >= 0 && !isOver)
{
    Console.WriteLine("Orders complete");
}