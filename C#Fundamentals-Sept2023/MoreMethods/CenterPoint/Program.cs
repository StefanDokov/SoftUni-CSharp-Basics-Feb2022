


double xone = double.Parse(Console.ReadLine());
double yone = double.Parse(Console.ReadLine());

double xtwo = double.Parse(Console.ReadLine());
double ytwo = double.Parse(Console.ReadLine());



double firstDistance = Math.Sqrt(xone * xone + yone * yone);
double secondDistance = Math.Sqrt(xtwo * xtwo + ytwo * ytwo);

if (firstDistance > secondDistance)
{
    Print(xtwo, ytwo);
}
else if (firstDistance <= secondDistance)
{
    Print(xone, yone);
}
        

        static void Print(double x, double y)
{
    Console.WriteLine($"({x}, {y})");
}