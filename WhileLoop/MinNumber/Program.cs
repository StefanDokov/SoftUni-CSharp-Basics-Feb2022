



string input = Console.ReadLine();
int min = int.MaxValue;
while (input != "Stop")
{
    int checker = int.Parse(input);
    if (checker < min)
    {
        min = checker;
    }


    input = Console.ReadLine();
}

Console.WriteLine(min);