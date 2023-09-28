


int heigth = int.Parse(Console.ReadLine()); 
int weight = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int freeSpace = heigth * weight * length;

while (true)
{
    string boxes = Console.ReadLine();

    if (boxes == "Done")
    {
        Console.WriteLine($"{freeSpace} Cubic meters left.");
        break;
    }

    freeSpace -= int.Parse(boxes);

    if (freeSpace < 0)
    {
        Console.WriteLine($"No more free space! You need {Math.Abs(freeSpace)} Cubic meters more.");
        break;
    }


}
