


while (true)
{
    string input = Console.ReadLine();

    if (input.ToUpper() == "END")
    {
        break;
    }

    if (IsPalindrome(input))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
}

static bool IsPalindrome(string input)
{
    string cleanInput = new string(input.Where(char.IsDigit).ToArray());

    return cleanInput == new string(cleanInput.Reverse().ToArray());
}