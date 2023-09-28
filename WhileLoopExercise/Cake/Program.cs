



int height = int.Parse(Console.ReadLine()); 
int width = int.Parse(Console.ReadLine());


int wholeCake = height * width;

while (wholeCake > 0)
{
    string piece = Console.ReadLine();

    if (piece == "STOP")
    {
        Console.WriteLine($"{wholeCake} pieces are left.");
        break;
    }

    wholeCake -= int.Parse(piece);

    if (wholeCake < 0)
    {
        Console.WriteLine($"No more cake left! You need {Math.Abs(wholeCake)} pieces more.");
        break;
    }


}