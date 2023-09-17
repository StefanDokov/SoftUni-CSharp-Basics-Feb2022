


string input = Console.ReadLine();
int max = int.MinValue;
while (input != "Stop")
{
    int checker = int.Parse(input);
    if (checker > max)
    {
        max = checker;
    }


    input = Console.ReadLine();
}

Console.WriteLine(max);