




string textInput = Console.ReadLine();

if (textInput == "int")
{
    int b = int.Parse(Console.ReadLine());  

    Console.WriteLine(b * 2);
}

if (textInput == "real")
{
    double d = double.Parse(Console.ReadLine());

    Console.WriteLine($"{d * 1.5:f2}");
}

if (textInput == "string")
{
    string text = Console.ReadLine();

    Console.WriteLine("$" + text + "$");
}