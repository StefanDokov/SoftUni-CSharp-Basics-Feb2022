


double xone = double.Parse(Console.ReadLine());
double yone = double.Parse(Console.ReadLine());
double xtwo = double.Parse(Console.ReadLine());
double ytwo = double.Parse(Console.ReadLine());
double xthree = double.Parse(Console.ReadLine());
double ythree = double.Parse(Console.ReadLine());
double xfour = double.Parse(Console.ReadLine());
double yfour = double.Parse(Console.ReadLine());

Longer(xone, yone, xtwo, ytwo, xthree, ythree, xfour, yfour);

static void Closer(double x, double y, double z, double w) 
{
    if (x * x + y * y <= z * z + w * w)
        Console.WriteLine($"({x}, {y})({z}, {w})");
    else
        Console.WriteLine($"({z}, {w})({x}, {y})");
}

static void Longer(double a1, double b1, double a2, double b2, double a3, double b3, double a4, double b4)
{
    double firstRes = Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2); 
    double secondRes = Math.Pow(a3 - a4, 2) + Math.Pow(b3 - b4, 2); 

    if (firstRes >= secondRes)
        Closer(a1, b1, a2, b2);
    else
        Closer(a3, b3, a4, b4);


}