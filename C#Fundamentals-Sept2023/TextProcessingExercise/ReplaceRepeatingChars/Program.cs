using System.Text;

string input = Console.ReadLine();

string result = ReplaceConsecutiveDuplicates(input);

Console.WriteLine(result);
    

    static string ReplaceConsecutiveDuplicates(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return input;
    }

    StringBuilder resultBuilder = new StringBuilder();

    char currentChar = input[0];
    resultBuilder.Append(currentChar);

    for (int i = 1; i < input.Length; i++)
    {
        if (input[i] != currentChar)
        {
            resultBuilder.Append(input[i]);

            currentChar = input[i];
        }
    }

    return resultBuilder.ToString();
}