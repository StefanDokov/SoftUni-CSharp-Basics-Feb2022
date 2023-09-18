



Stack<char> parensis = new Stack<char>();

string input = Console.ReadLine();

foreach (char skobi in input)
{
    if (skobi == '{' || skobi == '[' || skobi == '(')
    {
        parensis.Push(skobi);
        continue;
    } 
    if (parensis.Count == 0)
    {
        parensis.Push(skobi);
        break;
    }
    if (skobi == '}')
    {
        char see = parensis.Peek();
        if (see == '{')
        {
            parensis.Pop();
        }
        
    }
    if (skobi == ']')
    {
        char see = parensis.Peek();
        if (see == '[')
        {
            parensis.Pop();
        }
        
    }
    if (skobi == ')')
    {
        char see = parensis.Peek();
        if (see == '(')
        {
            parensis.Pop();
        }
        
    }

}

if (parensis.Count > 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}


