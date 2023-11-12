


using System.Numerics;

int n = int.Parse(Console.ReadLine());

BigInteger best = 0;
int[] sum = new int[3];

for (int i = 0; i < n; i++)
{
    int sbsnow = int.Parse((Console.ReadLine()));
    int sbtime = int.Parse((Console.ReadLine()));
    int sbquality = int.Parse((Console.ReadLine()));

    
    int half = sbsnow / sbtime;

    BigInteger result = BigInteger.Pow(half, sbquality);

    if (result >= best)
    {
        Array.Clear(sum, 0, 2);
        best = result;
        sum[0] = sbsnow;
        sum[1] = sbtime;
        sum[2] = sbquality;
    }
    



}
Console.WriteLine($"{sum[0]} : {sum[1]} = {best} ({sum[2]})");