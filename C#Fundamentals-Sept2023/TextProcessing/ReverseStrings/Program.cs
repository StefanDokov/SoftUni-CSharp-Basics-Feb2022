


while (true)
{
    string input = Console.ReadLine();

    if (input == "end")
    {
        break;
    }

    string reversed = ReverseString(input);
    Console.WriteLine($"{input} = {reversed}");
}
    

     string ReverseString(string input)
{
    char[] charArray = input.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}