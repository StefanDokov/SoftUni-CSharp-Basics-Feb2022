

int n = int.Parse(Console.ReadLine());
int sum = 0;
int bigest = int.MinValue;

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());
    sum += num;
    
    if (num > bigest) 
    {
       bigest = num;
    }
}

int sumWithout = sum - bigest;

if (bigest == sumWithout)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {bigest}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(bigest - sumWithout)}");
}

