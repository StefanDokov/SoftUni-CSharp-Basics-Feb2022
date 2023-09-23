



int[] n = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

string[,] matrix = new string[n[0], n[1]];

int rows = n[0];
int cols = n[1];

for (int row = 0; row <= rows - 1; row++) 
{
    string[] words = Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    for (int col = 0; col <= cols - 1; col++)
    {
        matrix[row, col] = words[col];
    }
}

string comand = Console.ReadLine();

while (comand != "END")
{
    if (IsValidCommand(comand, rows, cols))
    {
        string[] nextTask = comand.Split(" ");

        string first = matrix[int.Parse(nextTask[1]), int.Parse(nextTask[2])];
        string second = matrix[int.Parse(nextTask[3]), int.Parse(nextTask[4])];

        matrix[int.Parse(nextTask[1]), int.Parse(nextTask[2])] = second;
        matrix[int.Parse(nextTask[3]), int.Parse(nextTask[4])] = first;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();

        }

    }
    else
    {
        Console.WriteLine("Invalid input!");
       
        
    }

    comand = Console.ReadLine();
}


static bool IsValidCommand(String comand, int rows, int cols)
{
    
    string[] nextTask = comand.Split(" "); 

    
    bool isValidName = nextTask[0] == "swap";
    
    bool isValidCountParts = nextTask.Length == 5;

    bool isValidRowsAndCols = false;
    if (isValidName && isValidCountParts)
    {
        int row1 = int.Parse(nextTask[1]); 
        int col1 = int.Parse(nextTask[2]); 
        int row2 = int.Parse(nextTask[3]); 
        int col2 = int.Parse(nextTask[4]); 

        
        isValidRowsAndCols = row1 >= 0 && row1 < rows
                                && col1 >= 0 && col1 < cols
                                && row2 >= 0 && row2 < rows
                                && col2 >= 0 && col2 < cols;
    }
     

    return isValidName && isValidCountParts && isValidRowsAndCols;

}