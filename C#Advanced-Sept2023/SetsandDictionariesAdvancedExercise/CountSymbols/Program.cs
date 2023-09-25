



string texter = Console.ReadLine();


char[] text = texter.ToCharArray();

SortedDictionary<char, int> appearances = new SortedDictionary<char, int>();


foreach (char c in text)
{
    if (!appearances.ContainsKey(c))
    {
        appearances.Add(c, 1);
    } 
    else
    {
        appearances[c]++;
    }
}

foreach (char c in appearances.Keys)
{
    Console.WriteLine($"{c}: {appearances[c]} time/s");
}