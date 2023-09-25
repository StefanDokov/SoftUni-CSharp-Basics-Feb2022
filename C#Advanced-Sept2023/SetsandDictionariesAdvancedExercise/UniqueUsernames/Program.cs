


int n = int.Parse(Console.ReadLine());

HashSet<string> list = new HashSet<string>();

while (n > 0)
{
    list.Add(Console.ReadLine());

    n--;
}

foreach (string s in list)
{
    Console.WriteLine(s);
}