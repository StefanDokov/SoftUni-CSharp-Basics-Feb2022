

string name = Console.ReadLine();

int rep = int.Parse(Console.ReadLine());

string res = Repeater(name, rep);

Console.WriteLine(res);

static string Repeater(string name, int n)
{

    string result = "";


    for (int i = 0; i < n; i++)
    {

        result += name;

    }

    return result;

}