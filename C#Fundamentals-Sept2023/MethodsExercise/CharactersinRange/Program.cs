


char first = char.Parse(Console.ReadLine());
char second = char.Parse(Console.ReadLine());

if (first > second)
{
    char mid = first;
    first = second; 
    second = mid;
}


for (int i = (int)first + 1; i < (int)second; i++)
{
    Console.Write((char)i + " ");
}

Console.WriteLine();

