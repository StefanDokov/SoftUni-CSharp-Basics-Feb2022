


string operation = Console.ReadLine();
double sum = 0;

while (operation != "NoMoreMoney")
{
    double adder = double.Parse(operation);
    if (adder < 0)
    {
        Console.WriteLine($"Invalid operation!");
        break;
    }
    sum += adder;
    Console.WriteLine($"Increase: {adder:f2}");
    operation = Console.ReadLine();
}
Console.WriteLine($"Total: {sum:f2}");