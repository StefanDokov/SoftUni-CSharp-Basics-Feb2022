



int n = int.Parse(Console.ReadLine());

double musala = 0;
double monblant = 0;
double kilimandjaro = 0;
double ktwo = 0;
double everest = 0;
double allClimbers = 0;


for (int i = 0; i < n; i++)
{
    int personi = int.Parse(Console.ReadLine());
    allClimbers += personi;
    if (personi <= 5)
    {
        musala += personi;
    }
    if (personi >= 6 && personi <= 12)
    {
        monblant += personi;
    }
    if (personi >= 13 && personi <= 25)
    {
        kilimandjaro += personi;
    }
    if (personi >= 26 && personi <= 40)
    {
        ktwo += personi;
    }
    if (personi >= 41)
    {
        everest += personi;
    }
}

Console.WriteLine($"{musala / allClimbers * 100:f2}%");
Console.WriteLine($"{monblant / allClimbers * 100:f2}%");
Console.WriteLine($"{kilimandjaro / allClimbers * 100:f2}%");
Console.WriteLine($"{ktwo / allClimbers * 100:f2}%");
Console.WriteLine($"{everest / allClimbers * 100:f2}%");