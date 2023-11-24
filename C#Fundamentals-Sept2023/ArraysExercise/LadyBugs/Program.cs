



int n = int.Parse(Console.ReadLine());


int[] bugs = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int[] field = new int[n];


foreach (int b in bugs)
{
    if (b >= 0 && b < n)
    {

       field[b] = 1;
    }
}


string input;

while ((input = Console.ReadLine()) != "end")
{

    string[] actions = input
        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int firstIndex = int.Parse(actions[0]);

    string move = actions[1];

    int secondIndex = int.Parse(actions[2]);

    if (firstIndex < 0 || firstIndex >= n || field[firstIndex] == 0)
    {
        continue;
    }
    
    
        
        field[firstIndex] = 0;


        if (move == "left")
        {

            secondIndex *= -1;
        }

        while (true)
        {

            firstIndex += secondIndex;

            if (firstIndex >= n || firstIndex < 0)
            {
                break;

            }

            if (field[firstIndex] == 0)
            {
                field[firstIndex] = 1;
                break;
            }


        }



}

Console.WriteLine(string.Join(" ", field));

