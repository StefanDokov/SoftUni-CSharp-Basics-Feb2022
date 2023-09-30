





string[] uppers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Where(s => char.IsUpper(s[0]))
    .ToArray();
    

foreach (string word in uppers)
{
    Console.WriteLine(word);
}