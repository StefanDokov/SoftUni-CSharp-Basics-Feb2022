



int start = int.Parse(Console.ReadLine());
int down = 0;
while (down < start)
{
    int nextNum = int.Parse(Console.ReadLine());

    down += nextNum;
}

Console.WriteLine(down);