



int num = int.Parse(Console.ReadLine());    



for (int i = 1111; i < 10000; i++)
{
    string checker = i.ToString();

    bool isIt = false;
    foreach (char c in checker)
    {
        
        if (int.Parse(c.ToString()) == 0 || num % int.Parse(c.ToString()) != 0)
        {
            isIt = true;
            break;
        }
    }
    if (!isIt)
    {
        Console.Write(i + " ");
    }


}

Console.WriteLine();