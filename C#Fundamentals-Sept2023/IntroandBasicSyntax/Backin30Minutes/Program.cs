


int hour = int.Parse(Console.ReadLine());
double minute = double.Parse(Console.ReadLine());

if (minute + 30 >= 60)
{
    hour++;
    if (hour > 23)
    {
        hour = 0;
    }
    minute = (minute + 30) - 60;
    if (minute > 9)
    {
        Console.WriteLine($"{hour}:{minute}");
    }
    else
    {
        Console.WriteLine($"{hour}:0{minute}");
    }
}
else
{
    Console.WriteLine($"{hour}:{minute + 30}");
}
