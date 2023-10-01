


int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magic  = int.Parse(Console.ReadLine());

int combination = 0;

bool stopper = false;

for (int i = start; i <= end;i++)
{
    for (int j = start; j <= end; j++)
    {
        combination++;
        if (i +  j == magic)
        {
            Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magic})");
            stopper = true;
            break;
        }
    }
    if (stopper)
    {
        break;
    }
    
}

if (!stopper)
{
    
     Console.WriteLine($"{combination} combinations - neither equals {magic}");
    
}