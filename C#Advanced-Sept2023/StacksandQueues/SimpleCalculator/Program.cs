

string[] splitted = Console.ReadLine().Split(' ');
Stack<string> output = new Stack<string>();

for(int i = splitted.Length - 1; i >= 0;i--)
{
    output.Push(splitted[i]);
}

int result = int.Parse(output.Pop());

while (output.Count > 0)
{
    string operand = output.Pop();
    int visual = int.Parse(output.Pop());

    if (operand == "+")
    {
     
        result += visual;
        
    } 
    if (operand == "-")
    {
     
        result -= visual;
        
    }
}

Console.WriteLine(result);