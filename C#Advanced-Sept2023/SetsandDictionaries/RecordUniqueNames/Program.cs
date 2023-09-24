



int n = int.Parse(Console.ReadLine());

HashSet<string> result = new HashSet<string>();
while (n > 0)
{
    result.Add(Console.ReadLine());


    n--;
}

foreach (string s in result)
{
    Console.WriteLine(s);
}