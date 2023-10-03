



double n = double.Parse(Console.ReadLine());

double final = 0;
int tasks = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "Finish")
    {
        Console.WriteLine($"Student's final assessment is {final / tasks:f2}.");
        break;
    }
    double middleSum = 0;
    tasks++;
    for (int i = 0; i < n; i++)
    {
        middleSum += double.Parse(Console.ReadLine());
    }
    double halfSum = middleSum / n;
    final += halfSum;
    Console.WriteLine($"{input} - {halfSum:f2}.");



}