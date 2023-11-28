



double width = double.Parse(Console.ReadLine());
double height = double.Parse(Console.ReadLine());


double result = CalculateRectangleArea(width, height);

Console.WriteLine(result);

static double CalculateRectangleArea(double width, double height)
{


    return width * height;

}