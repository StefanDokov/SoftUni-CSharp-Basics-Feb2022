

int sum = 0;
int n = int.Parse(Console.ReadLine());
int days = 0;
while (n >= 100)
{
    sum += n - 26;

    n -= 10;
    days++;
}

sum -= 26;

Console.WriteLine(days);
if (sum > 0)
{

Console.WriteLine(sum);
}
else
{
    Console.WriteLine(0);
}