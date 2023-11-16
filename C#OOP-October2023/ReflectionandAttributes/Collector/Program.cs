


namespace Stealer;

class Program
{
    static void Main(string[] args)
    {
        Spy spy = new Spy();
        string className = "Stealer.Hacker";

        spy.PrintGettersAndSetters(className);
    }
}