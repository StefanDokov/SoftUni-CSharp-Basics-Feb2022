


int n = int.Parse(Console.ReadLine());

double v = double.MinValue;
string bestKeg = null;

for (int i = 0; i < n; i++)
{
    string model = Console.ReadLine();

    double r = double.Parse(Console.ReadLine());

    int h = int.Parse(Console.ReadLine());

    double mid = Math.PI * (r * r) * h;

    if (mid > v)
    {
        v = mid;
        bestKeg = model;
    }


}

Console.WriteLine(bestKeg);