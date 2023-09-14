

int n = int.Parse(Console.ReadLine());

int result = 1;
for (int i = 0; i <= n; i += 2)
{
    Console.WriteLine(result);
    result = result * 2 * 2;
}