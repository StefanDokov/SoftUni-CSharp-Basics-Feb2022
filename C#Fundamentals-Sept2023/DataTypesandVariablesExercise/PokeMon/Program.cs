


int power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int exhaust = int.Parse(Console.ReadLine());

int pokes = 0;
double half = power / 2;
while (power >= distance)
{
    power -= distance;
    pokes++;

    if (power == half && exhaust != 0)
    {
        power /= exhaust;
    }
}

Console.WriteLine(power);
Console.WriteLine(pokes);
