




int side = int.Parse(Console.ReadLine());

char[,] field = new char[side, side];

Queue<string> directions = new(Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries));


int collect = 0;

int currentRow = 0;
int currentCol = 0;

for (int i = 0; i < side; i++)
{
    char[] steps = Console.ReadLine().ToCharArray();

    for (int j = 0; j < side; j++)
    {
        field[i, j] = steps[j];
        
        if (steps[j] == 's')
        {
            currentRow = i;
            currentCol = j;
        }
    }
}
bool isOut = false;
bool more = false;
while (collect < 3)
{

    if (directions.Count == 0)
    {
        more = true;
        break;
    }
    string walk = directions.Dequeue();

    

    if (walk == "up")
    {
        if (currentRow - 1 < 0)
        {
            isOut = true;
            Console.WriteLine("The squirrel is out of the field.");
            break;
        }
        currentRow--;
        if (field[currentRow, currentCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            isOut = true;
            break;
        }
        if (field[currentRow, currentCol] == 'h')
        {
            collect++;
            field[currentRow, currentCol] = '*';
        }
        if (field[currentRow, currentCol] == '*')
        {
            continue;
        }


    }
    else if (walk == "down")
    {
        if (currentRow + 1 >= field.GetLength(0))
        {
            isOut = true;
            Console.WriteLine("The squirrel is out of the field.");
            break;
        }
        currentRow++;
        if (field[currentRow, currentCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            isOut = true;
            break;
        }
        if (field[currentRow, currentCol] == 'h')
        {
            collect++;
            field[currentRow, currentCol] = '*';
        }
        if (field[currentRow, currentCol] == '*')
        {
            continue;
        }


    }
    else if (walk == "left")
    {
        if (currentCol - 1 < 0)
        {
            isOut = true;
            Console.WriteLine("The squirrel is out of the field.");
            break;
        }
        currentCol--;
        if (field[currentRow, currentCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            isOut = true;
            break;
        }
        if (field[currentRow, currentCol] == 'h')
        {
            collect++;
            field[currentRow, currentCol] = '*';
        }
        if (field[currentRow, currentCol] == '*')
        {
            continue;
        }


    }
    else if (walk == "right")
    {
        if (currentCol + 1 >= field.GetLength(1))
        {
            isOut = true;
            Console.WriteLine("The squirrel is out of the field.");
            break;
        }
        currentCol++;
        if (field[currentRow, currentCol] == 't')
        {
            Console.WriteLine("Unfortunately, the squirrel stepped on a trap...");
            isOut = true;
            break;
        }
        if (field[currentRow, currentCol] == 'h')
        {
            collect++;
            field[currentRow, currentCol] = '*';
        }
        if (field[currentRow, currentCol] == '*')
        {
            continue;
        }


    }


    if (isOut)
    {
        break;
    }


}

if (collect == 3)
{
    Console.WriteLine("Good job! You have collected all hazelnuts!");
}
if (more)
{
    Console.WriteLine("There are more hazelnuts to collect.");
}
Console.WriteLine($"Hazelnuts collected: {collect}");
