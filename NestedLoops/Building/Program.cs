



int levels = int.Parse(Console.ReadLine());
int rooms = int.Parse(Console.ReadLine());


for (int i = levels; i > 0;i--)
{ 
    for (int j = 0;j < rooms; j++)
    {
        if (i == levels)
        {
            Console.Write($"L{i}{j} ");
        }
        else if (i % 2 != 0)
        {
            Console.Write($"A{i}{j} "); 

        }
        else if (i % 2 == 0)
        {
            Console.Write($"O{i}{j} ");
        }
        

    }
    Console.WriteLine();
}