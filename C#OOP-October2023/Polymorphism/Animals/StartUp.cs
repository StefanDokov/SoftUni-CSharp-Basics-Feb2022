
namespace Animals
{
    public class StartUp
    {
        static void Main()
        {

            Animal animal = new Dog("sharo", "proplan");
            Explain(animal);
            animal = new Cat("misho", "fish");
            Explain(animal);


        }
        static void Explain(Animal animal)
        {
            Console.WriteLine(animal.ExplainSelf());
        }
    }
}
