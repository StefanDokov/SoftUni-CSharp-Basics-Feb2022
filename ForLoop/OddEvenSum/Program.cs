



int n = int.Parse(Console.ReadLine());
int sumX = 0;
int sumY = 0;

for (int i = 1; i <= n; i++)
{
    int x = int.Parse(Console.ReadLine());
    
    if (i % 2 == 0)
    {
        sumX += x;
    } else
    {
        sumY += x;
    }
}


if (sumX == sumY)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sumY}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sumX - sumY)}");

}