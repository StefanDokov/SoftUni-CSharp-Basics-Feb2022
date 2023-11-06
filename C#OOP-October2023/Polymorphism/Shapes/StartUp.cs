
namespace Shapes
{
    public class StartUp
    {
        static void Main()
        {

            Shape shape = new Rectangle(3.5d, 5.5d);
            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.Draw());
            shape = new Circle(0.5d);
            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.CalculateArea());
            Console.WriteLine(shape.Draw());
            


        }
        
    }
}
