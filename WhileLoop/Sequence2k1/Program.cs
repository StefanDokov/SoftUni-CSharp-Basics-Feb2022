


int start = int.Parse(Console.ReadLine());
int result = 1;

while (result <= start)
{
    if (result == 1)
    {
        Console.WriteLine(result);
    } 
        result = result * 2 + 1;
    if (result <= start)
    {
        Console.WriteLine(result);

    }

}