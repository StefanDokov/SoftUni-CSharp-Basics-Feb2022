



using System.Text;

string input = Console.ReadLine();

string result = passwordChecker(input);

Console.WriteLine(result);

static string passwordChecker(string input)
{
    bool iscool = false;
    StringBuilder sb = new StringBuilder();
    if (input.Length < 6 || input.Length > 10)
    {
        sb.AppendLine("Password must be between 6 and 10 characters");
        iscool = true;
    }
    int count = 0;
    
    foreach (char c in input)
    {
        if (char.IsDigit(c))
        {
            count++;
        }
        if (!char.IsLetter(c) && !char.IsDigit(c)) 
        {
            sb.AppendLine("Password must consist only of letters and digits");
            
            iscool = true;
            break;
        }
    }

    if (count < 2)
    {
        sb.AppendLine("Password must have at least 2 digits");
        iscool = true;
    }
    if (!iscool)
    {
        sb.AppendLine("Password is valid");
    }

    return sb.ToString();


}