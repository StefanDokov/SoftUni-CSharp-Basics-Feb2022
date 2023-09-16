



string actor = Console.ReadLine();
double points = double.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double pointsGiven = double.Parse(Console.ReadLine());

    points += (name.Length * pointsGiven) / 2;

    if (points >= 1250.5)
    {
        Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {points:f1}!");
        break;
    }

}

if (points < 1250.5)
{
    Console.WriteLine($"Sorry, {actor} you need {1250.5 - points:f1} more!");
}