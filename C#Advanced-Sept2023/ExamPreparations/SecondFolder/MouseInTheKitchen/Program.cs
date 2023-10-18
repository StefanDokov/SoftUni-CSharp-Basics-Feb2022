


int[] coord = Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


char[,] cupboard = new char[coord[0], coord[1]];

for  (int i = 0; i < coord[0]; i++)
{
    char[] road = Console.ReadLine().ToCharArray();

    for (int j = 0; j < coord[1]; j++)
    {
        cupboard[i, j] = road[j];
    }


}

int currentRow = 0;
int currentCol = 0;
int cheeseCount = 0;

for (int i = 0; i < coord[0]; i++)
{
    for (int j = 0;j < coord[1]; j++)
    {
        if (cupboard[i, j] == 'M')
        {
            currentRow = i;
            currentCol = j;
        }
        if (cupboard[i,j] == 'C')
        {
            cheeseCount++;  
        }
    }


}
string comand;
bool isOver = false;
bool isOut = false;
while  (cheeseCount > 0 && (comand = Console.ReadLine()) != "danger")
{
    if (comand == "up")
    {
        if (currentRow - 1 < 0)
        {
            Console.WriteLine("No more cheese for tonight!");
            isOver = true;
            isOut = true;
            
        }
        else { 
        cupboard[currentRow, currentCol] = '*';

        currentRow -= 1;

        if (cupboard[currentRow, currentCol] == 'C')
        {
            cheeseCount--; 
            cupboard[currentRow, currentCol] = 'M';    
        }
        if (cupboard[currentRow, currentCol] == '@')
        {
            currentRow += 1;
            cupboard[currentRow, currentCol] = 'M';
            continue;
        }
        if (cupboard[currentRow, currentCol] == 'T')
        {
            cupboard[currentRow, currentCol] = 'M';
            Console.WriteLine("Mouse is trapped!");
            isOver = true;
            isOut = true;
            break;
        }
        if (cupboard[currentRow, currentCol] == '*')
            {
                
                cupboard[currentRow, currentCol] = 'M';
            }

        }
}
    else if (comand == "down")
    {
        if (currentRow + 1 > coord[0] - 1)
        {
            Console.WriteLine("No more cheese for tonight!");
            isOver = true;
            isOut = true;
            
        }
        else { 
        cupboard[currentRow, currentCol] = '*';

        currentRow += 1;


        if (cupboard[currentRow, currentCol] == 'C')
        {
            cheeseCount--;
            cupboard[currentRow, currentCol] = 'M';

        }
            if (cupboard[currentRow, currentCol] == '@')
        {
                currentRow -= 1;
                cupboard[currentRow, currentCol] = 'M';
                continue;
        }
        if (cupboard[currentRow, currentCol] == 'T')
        {
            cupboard[currentRow, currentCol] = 'M';
            Console.WriteLine("Mouse is trapped!");
            isOver = true;
            isOut = true;
            break;
        }
        if (cupboard[currentRow, currentCol] == '*')
            {

                cupboard[currentRow, currentCol] = 'M';
            }
        }
}
    else if (comand == "left")
        {
            if (currentCol - 1 < 0)
            {
                Console.WriteLine("No more cheese for tonight!");
                isOver = true;
                isOut = true;
                
            }
            else { 
            cupboard[currentRow, currentCol] = '*';

            currentCol -= 1;


            if (cupboard[currentRow, currentCol] == 'C')
            {
                cheeseCount--;
                cupboard[currentRow, currentCol] = 'M';

            }
            if (cupboard[currentRow, currentCol] == '@')
            {
                currentCol += 1;
                cupboard[currentRow, currentCol] = 'M';
                continue;
            }
            if (cupboard[currentRow, currentCol] == 'T')
            {
                cupboard[currentRow, currentCol] = 'M';
                Console.WriteLine("Mouse is trapped!");
                isOver = true;
                isOut = true;
                break;
            }
            if (cupboard[currentRow, currentCol] == '*')
            {

                cupboard[currentRow, currentCol] = 'M';
            }
        }
    }
    else if (comand == "right")
    {
        if (currentCol + 1 > coord[1] - 1)
        {
            Console.WriteLine("No more cheese for tonight!");
            isOver = true;
            isOut = true;

        }
        else { 
        cupboard[currentRow, currentCol] = '*';

        currentCol += 1;


        if (cupboard[currentRow, currentCol] == 'C')
        {
            cheeseCount--; cupboard[currentRow, currentCol] = 'M';

        }
            if (cupboard[currentRow, currentCol] == '@')
        {
             currentCol -= 1;
             cupboard[currentRow, currentCol] = 'M';
             continue;
        }
        if (cupboard[currentRow, currentCol] == 'T')
        {
            cupboard[currentRow, currentCol] = 'M';
            Console.WriteLine("Mouse is trapped!");
            isOver = true;
            isOut = true;
            break;
        }
            if (cupboard[currentRow, currentCol] == '*')
            {

                cupboard[currentRow, currentCol] = 'M';
            }
        }
    }



    if (isOver)
    {
        
        break;
    }


}

if (cheeseCount <= 0)
{
    Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
}
else if (cheeseCount > 0 && !isOut)
{
    Console.WriteLine("Mouse will come back later!");
}

for (int i = 0; i < cupboard.GetLength(0); i++)
{
    for (int j = 0; j < cupboard.GetLength(1); j++)
    {
        Console.Write(cupboard[i, j]);
    }
    Console.WriteLine();
}