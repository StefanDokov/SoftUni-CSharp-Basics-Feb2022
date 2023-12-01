

string input = Console.ReadLine();


string result = Printera(input);

Console.WriteLine(result);

static string Printera(string input)
{
    string result;


    if (input.Length % 2 != 0)
    {
        int res;

        res = input.Length / 2;

        result = $"{input[res]}";
    }
    else
    {
        int res;

        res = input.Length / 2;

        result = $"{input[res - 1]}{input[res]}";
    }


    return result;

}