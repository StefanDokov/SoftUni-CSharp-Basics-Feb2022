

int[] sides = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


char[,] streets = new char[sides[0], sides[1]];

for (int i = 0; i < sides[0]; i++)
{
    char[] steps = Console.ReadLine()
        .ToArray();

    for (int j = 0; j < steps.Length; j++)
    {
        streets[i, j] = steps[j];
    }

}
int startRow = -1;
int startCol = -1;
int currentRow = -1;
int currentCol = -1;

for (int p = 0; p < sides[0]; p++)
{
    for (int t = 0; t < sides[1]; t++)
    {
        if (streets[p, t] == 'B')
        {
            startRow = p;
            startCol = t;
            currentRow = p;
            currentCol = t;
        }
    }

}
bool isOver = false;
bool isCollected = false;
bool turner = false;
while (true)
{
    string comand = Console.ReadLine();

    if (string.IsNullOrEmpty(comand))
    {
        isOver = true;
    }

    else if (comand == "left")
    {
        int now = currentCol - 1;
        if (now < 0)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            isOver = true;
            streets[startRow, startCol] = ' ';
            

        }
        else
        {
            if (streets[currentRow, now] == '*')
            {
                
                continue;
            }
            else if (streets[currentRow, now] == '-' || streets[currentRow, now] == '.')
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                currentCol = now;
                streets[currentRow, currentCol] = '.';

            }
            else if (streets[currentRow, now] == 'P')
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                isCollected = true;
                currentCol = now;
                streets[currentRow, currentCol] = 'R';

            }
            else if (streets[currentRow, now] == 'A' && isCollected)
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                Console.WriteLine("Pizza is delivered on time! Next order...");
                isOver = true;
                currentCol = now;
                streets[currentRow, currentCol] = 'P';
                streets[startRow, startCol] = 'B';

            }
        }

    }

    if (comand == "right")
    {
        int now = currentCol + 1;
        if (now > sides[1] - 1)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            isOver = true;
            streets[startRow, startCol] = ' ';


        }
        else
        {
            if (streets[currentRow, now] == '*')
            {
                continue;
            }
            else if (streets[currentRow, now] == '-' || streets[currentRow, now] == '.')
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                currentCol = now;
                streets[currentRow, currentCol] = '.';

            }
            else if (streets[currentRow, now] == 'P')
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                isCollected = true;
                currentCol = now;
                streets[currentRow, currentCol] = 'R';

            }
            else if (streets[currentRow, now] == 'A' && isCollected)
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                Console.WriteLine("Pizza is delivered on time! Next order...");
                isOver = true;
                currentCol = now;
                streets[currentRow, currentCol] = 'P';
                streets[startRow, startCol] = 'B';

            }
        }

    }

    if (comand == "up")
    {
        int now = currentRow - 1;
        if (now < 0)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            isOver = true;
            streets[startRow, startCol] = ' ';

        }
        else
        {
            if (streets[now, currentCol] == '*')
            {
                continue;
            }
            else if (streets[now, currentCol] == '-' || streets[now, currentCol] == '.')
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                currentRow = now;
                streets[currentRow, currentCol] = '.';

            }
            else if (streets[now, currentCol] == 'P')
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                isCollected = true;
                currentRow = now;
                streets[currentRow, currentCol] = 'R';

            }
            else if (streets[now, currentCol] == 'A' && isCollected)
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                Console.WriteLine("Pizza is delivered on time! Next order...");
                isOver = true;
                currentRow = now;
                streets[currentRow, currentCol] = 'P';
                streets[startRow, startCol] = 'B';

            }
        }

    }

    if (comand == "down")
    {
        int now = currentRow + 1;
        if (now > sides[0] - 1)
        {
            Console.WriteLine("The delivery is late. Order is canceled.");
            isOver = true;
            streets[startRow, startCol] = ' ';

        }
        else
        {
            if (streets[now, currentCol] == '*')
            {
                continue;
            }
            else if (streets[now, currentCol] == '-' || streets[now, currentCol] == '.')
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                currentRow = now;
                streets[currentRow, currentCol] = '.';

            }
            else if (streets[now, currentCol] == 'P')
            {
                Console.WriteLine("Pizza is collected. 10 minutes for delivery.");
                isCollected = true;
                currentRow = now;
                streets[currentRow, currentCol] = 'R';

            }
            else if (streets[now, currentCol] == 'A' && isCollected)
            {
                if (!turner)
                {
                    streets[startRow, startCol] = '.';
                    turner = true;
                }
                Console.WriteLine("Pizza is delivered on time! Next order...");
                isOver = true;
                currentRow = now;
                streets[currentRow, currentCol] = 'P';
                streets[startRow, startCol] = 'B';

            }
        }

    }



    if (isOver)
    {
        for (int i = 0; i < streets.GetLength(0); i++)
        {
            for (int j = 0; j < streets.GetLength(1); j++)
            {
                Console.Write(streets[i, j]);
            }
            Console.WriteLine();
        }
        break;

    }

}



