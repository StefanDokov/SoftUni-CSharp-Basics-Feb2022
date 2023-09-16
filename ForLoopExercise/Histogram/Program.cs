

int n = int.Parse(Console.ReadLine());
double p1 = 0; 
double p2 = 0; 
double p3 = 0; 
double p4 = 0; 
double p5 = 0;

for  (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());

    if (currentNum < 200)
    {
        p1++;
    }
    else if (currentNum >= 200 && currentNum <= 399)
    {
        p2++;
    }
    else if (currentNum >= 400 && currentNum <= 599)
    {
        p3++;
    }
    else if (currentNum >= 600 && currentNum <= 799)
    {
        p4++;
    }
    else if (currentNum >= 800)
    {
        p5++;
    }

}
p1 = (p1 / n) * 100;

Console.WriteLine($"{p1:f2}%");
Console.WriteLine($"{(p2 / n) * 100:f2}%");
Console.WriteLine($"{(p3 / n) * 100:f2}%");
Console.WriteLine($"{(p4 / n) * 100:f2}%");
Console.WriteLine($"{(p5 / n) * 100:f2}%");