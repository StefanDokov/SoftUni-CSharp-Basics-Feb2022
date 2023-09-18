




int operations = int.Parse(Console.ReadLine());
string text = "";
Stack<string[]> undoser = new Stack<string[]>();
Stack<string> textove = new Stack<string>();

for (int i = 0; i < operations; i++)
{
    string[] current = Console.ReadLine().Split() as string[];

    int operationIndex = int.Parse(current[0]);

    if (operationIndex == 1)
    {
        text += current[1];
        undoser.Push(current);
    }
    else if (operationIndex == 2)      
    {
        int lastIndex = int.Parse(current[1]);
        textove.Push(text.Substring(text.Length - lastIndex));
        text = text.Substring(0, text.Length - lastIndex); 
        undoser.Push(current);
    }
    else if (operationIndex == 3)
    {
        int displayIndex = int.Parse(current[1]);
        Console.WriteLine(text[displayIndex - 1]);
    }
    else if (operationIndex == 4)
    {
        string[] whatToDo = undoser.Pop();

        int cmnd = int.Parse(whatToDo[0]);
        if (cmnd == 1)
        {
            int lastIndex = whatToDo[1].Length;
            text = text.Substring(0, text.Length - lastIndex);
        }
        if (cmnd == 2)
        {
            text += textove.Pop();

        }
    }
}