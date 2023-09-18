



int n = int.Parse(Console.ReadLine());
Queue<int[]> routes = new Queue<int[]>();
int wholeFuel = 0;
int turns = n;

for (int i = 0; i < n; i++)
{ 
   
    routes.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
}
int pump = 0;
bool isOver = false;

while (pump <= n - 1)
{
    

    foreach (int[] route in routes)
    {


    int fuel = route[0];
    int distance = route[1];
    wholeFuel += fuel;

    

    if (wholeFuel < distance)
    {
        routes.Enqueue(routes.Dequeue());
        turns = n;
        wholeFuel = 0;
        pump++;
        break;
    } 
    else
    {
        wholeFuel -= distance;
        turns--;
    }
    

    if (turns == 0)
    {
        isOver = true;
        break;
    }
    }

    if (isOver)
    {
        Console.WriteLine(pump);
        break;
    }
}