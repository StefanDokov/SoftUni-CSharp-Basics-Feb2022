



double basePoint = double.Parse(Console.ReadLine());

double power  = double.Parse(Console.ReadLine());


double result = Raiser(basePoint, power);

Console.WriteLine(result);


static double Raiser(double x, double y)
{
    
    double starter = 1;
    double num = x;

    while (starter < y)
    {

        num *= x;

        starter++;
    }


    return num;

}