



int size = int.Parse(Console.ReadLine());


char[,] fishingArea = new char[size, size];

int currRow = 0;
int currCol = 0;
int middle = 0;
for (int i = 0; i < size; i++)
{
    char[] positions = Console.ReadLine().ToCharArray();

    for (int j = 0; j < size; j++)
    {
        fishingArea[i, j] = positions[j];
        if (positions[j] == 'S')
        {
            currRow = i;
            currCol = j;
        }
    }
}

string comand;
int tonsCollected = 0;
bool isOver = false;
while ((comand = Console.ReadLine()) != "collect the nets")
{
    if (comand == "up")
    {
        middle = currRow;
        middle--;

        if (middle < 0)
        {
            middle = size - 1;
        }

        if (fishingArea[middle,currCol] == '-')
        {
            fishingArea[currRow,currCol] = '-';
            currRow = middle;
            fishingArea[currRow, currCol] = 'S';
            continue;
        }
        else if (fishingArea[middle, currCol] == 'W')
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{middle},{currCol}]");
            isOver = true;
            break;
        }
        else
        {
            fishingArea[currRow, currCol] = '-';
            int b;
            int.TryParse(fishingArea[middle, currCol].ToString(), out b);
            tonsCollected += b;
            currRow = middle;
            fishingArea[currRow, currCol] = 'S';
        }






    }
    else if (comand == "down")
    {
        middle = currRow;
        middle++;

        if (middle > size - 1)
        {
            middle = 0;
        }

        if (fishingArea[middle, currCol] == '-')
        {
            fishingArea[currRow, currCol] = '-';
            currRow = middle;
            fishingArea[currRow, currCol] = 'S';
            continue;
        }
        else if (fishingArea[middle, currCol] == 'W')
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{middle},{currCol}]");
            isOver = true;
            break;
        }
        else
        {
            fishingArea[currRow, currCol] = '-';
            int b;
            int.TryParse(fishingArea[middle, currCol].ToString(), out b);
            tonsCollected += b;
            currRow = middle;
            fishingArea[currRow, currCol] = 'S';
        }






    }
    else if (comand == "left")
    {
        middle = currCol;
        middle--;

        if (middle < 0)
        {
            middle = size - 1;
        }

        if (fishingArea[currRow, middle] == '-')
        {
            fishingArea[currRow, currCol] = '-';
            currCol = middle;
            fishingArea[currRow, currCol] = 'S';
            continue;
        }
        else if (fishingArea[currRow, middle] == 'W')
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{middle},{currCol}]");
            isOver = true;
            break;
        }
        else
        {
            fishingArea[currRow, currCol] = '-';
            int b;
            int.TryParse(fishingArea[currRow, middle].ToString(), out b);
            tonsCollected += b;
            currCol = middle;
            fishingArea[currRow, currCol] = 'S';
        }






    }
    else if (comand == "right")
    {
        middle = currCol;
        middle++;

        if (middle > size - 1)
        {
            middle = 0;
        }

        if (fishingArea[currRow, middle] == '-')
        {
            fishingArea[currRow, currCol] = '-';
            currCol = middle;
            fishingArea[currRow, currCol] = 'S';
            continue;
        }
        else if (fishingArea[currRow, middle] == 'W')
        {
            Console.WriteLine($"You fell into a whirlpool! The ship sank and you lost the fish you caught. Last coordinates of the ship: [{middle},{currCol}]");
            isOver = true;
            break;
        }
        else
        {
            fishingArea[currRow, currCol] = '-';
            int b;
            int.TryParse(fishingArea[currRow, middle].ToString(), out b);
            tonsCollected += b;
            currCol = middle;
            fishingArea[currRow, currCol] = 'S';
        }






    }




    if (isOver)
    {
        break;
    }

}
if (!isOver)
{
    if (tonsCollected >= 20)
    {
        Console.WriteLine("Success! You managed to reach the quota!");
    }
    else
    {
        Console.WriteLine($"You didn't catch enough fish and didn't reach the quota! You need {20 - tonsCollected} tons of fish more.");

    }
    if (tonsCollected > 0)
    {

    Console.WriteLine($"Amount of fish caught: {tonsCollected} tons.");
    }

    for (int i = 0; i < fishingArea.GetLength(0); i++)
    {
        for (int j = 0;j < fishingArea.GetLength(1); j++)
        {
            Console.Write(fishingArea[i,j]);
        }
        Console.WriteLine();

    }
}