


string typeR = Console.ReadLine();


string first = Console.ReadLine();

string second = Console.ReadLine(); 


string result = Maxer(typeR, first, second);

Console.WriteLine(result);

static string Maxer(string value, string x, string y)
{
    string result = "";
    switch(value)
    {

        case "int":

            result = Math.Max(int.Parse(x), int.Parse(y)).ToString();
            break;
            case "char":

            if (char.Parse(x) >= char.Parse(y))
            {
                result = x;
            } else
            { 
                result = y; 
            }
            break;
        case "string":
            int res = x.CompareTo(y);
            if (res >= 0)
            {
                result = x;
            }
            else
            {
                result = y;
            }
            break;


    }
    return result;

}