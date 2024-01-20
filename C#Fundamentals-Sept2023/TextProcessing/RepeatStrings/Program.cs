



using System.Text;

string input = Console.ReadLine();

string[] stringsArray = input.Split(' ');

foreach (string str in stringsArray)
{
    string repeatedString = RepeatString(str);
    Console.Write(repeatedString);
}
    

    static string RepeatString(string str)
{
    int length = str.Length;
    StringBuilder repeatedStringBuilder = new StringBuilder(length * length);

    for (int i = 0; i < length; i++)
    {
        repeatedStringBuilder.Append(str);
    }

    return repeatedStringBuilder.ToString();
}