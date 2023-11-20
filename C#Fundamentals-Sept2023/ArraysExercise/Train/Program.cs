
int n = int.Parse(Console.ReadLine());


int[] passangers = new int[n];

int sum = 0;
for (int i = 0;i <  n;i++)
{
    passangers[i] = int.Parse(Console.ReadLine());
    sum += passangers[i];
}


Console.WriteLine(string.Join(" ", passangers));
Console.WriteLine(sum);

