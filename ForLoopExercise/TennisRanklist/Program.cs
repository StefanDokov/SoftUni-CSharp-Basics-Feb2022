



int tours = int.Parse(Console.ReadLine());
double scores  = double.Parse(Console.ReadLine());
double avarage = 0;
double wons = 0;
for (int i = 0; i < tours; i++)
{
    string result = Console.ReadLine();

    switch(result)
    {
        case "F":
            scores += 1200;
            avarage += 1200;
            break;
        case "W":
            scores += 2000;
            avarage += 2000;
            wons++;
            break;
        case "SF":
            scores += 720;
            avarage += 720;
            break;
    }
}

Console.WriteLine($"Final points: {scores}");
Console.WriteLine($"Average points: {Math.Truncate(avarage / tours)}");
Console.WriteLine($"{wons / tours * 100:f2}%");
