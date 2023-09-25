



int n = int.Parse(Console.ReadLine());

Dictionary<int, int> evenTimes = new Dictionary<int, int>();


while (n > 0)
{
    int checker = int.Parse(Console.ReadLine());


    if (!evenTimes.ContainsKey(checker))
    {
        evenTimes[checker] = 1;
    } 
    else
    {
        evenTimes[checker]++;
    }


   n--;
}

foreach (int checker in evenTimes.Keys)
{
    if (evenTimes[checker] % 2 == 0)
    {
        Console.WriteLine(checker);
    }
}
