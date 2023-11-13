

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    long[] numes = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .Select(long.Parse)
        .ToArray();

    long greater = numes.OrderByDescending(x => x = x).First();

    long sum = Sumer(greater);

    Console.WriteLine(sum);

}



long Sumer(long num)
{
    long sum = 0;
    while (num != 0)
    {
        long l = num % 10;
        sum += Math.Abs(l);

        num /= 10;

    }
    return sum;
}