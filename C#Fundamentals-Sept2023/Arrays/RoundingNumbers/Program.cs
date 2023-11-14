

double[] arr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse).ToArray();

foreach (double item in arr)
{
    int rounded = (int)Math.Round(item, MidpointRounding.AwayFromZero);
    Console.WriteLine($"{item} => {rounded}");
}


