


string input = Console.ReadLine();

int result = vowelsCounter(input);

Console.WriteLine(result);

static int vowelsCounter(string input)
{
    int count = 0;

    foreach (char i in input)
{
    if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u'
        || i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')
        {
            count++;
        }
}
    return count;
}
