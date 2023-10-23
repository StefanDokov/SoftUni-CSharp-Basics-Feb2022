

int n = int.Parse(Console.ReadLine());
double superSum = 0;
for (int i = 0; i < n; i++)
{
    double pricePer = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsules = int.Parse(Console.ReadLine());

    double sum = (days * capsules) * pricePer;
    superSum += sum;
    Console.WriteLine($"The price for the coffee is: ${sum:f2}");


}
Console.WriteLine($"Total: ${superSum:f2}");