




int price = int.Parse(Console.ReadLine());
int sizeOfBullet = int.Parse(Console.ReadLine());
Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
int money = int.Parse(Console.ReadLine());
bool outOfBullets = false;
int bulletCount = 0;

while (locks.Count > 0)
{
    int bullet = bullets.Pop();
    int locker = locks.Peek();

    

    if (bullet <= locker)
    {
        locks.Dequeue();
        Console.WriteLine("Bang!");
        bulletCount++;
    } else
    {
        Console.WriteLine("Ping!");
        bulletCount++;
    }

    if (bulletCount % sizeOfBullet == 0 && bullets.Count > 0)
    {
        Console.WriteLine("Reloading!");
    }

    if (bullets.Count == 0 && locks.Count > 0)
    {
        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
        outOfBullets = true;
        break;
    }
}
if (!outOfBullets && locks.Count == 0)
{
    Console.WriteLine($"{bullets.Count} bullets left. Earned ${money - (bulletCount * price)}");
}