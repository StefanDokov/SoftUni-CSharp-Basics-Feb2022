


int n = int.Parse(Console.ReadLine());
int sumX = 0;
int sumY = 0;

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    sumX += x;
}

for (int i = 0; i < n; i++)
{
    int y = int.Parse(Console.ReadLine());
    sumY += y;
}

if (sumX == sumY)
{
    Console.WriteLine($"Yes, sum = {sumY}");
} else
{
    Console.WriteLine($"No, diff = {Math.Abs(sumX - sumY)}");

}