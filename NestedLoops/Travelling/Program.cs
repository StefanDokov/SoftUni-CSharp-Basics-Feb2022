
string destination = string.Empty;
double cost = 0;
double n;
while (true)
{
    
    string nextStep = Console.ReadLine();
    bool isNum = double.TryParse(nextStep, out n);

    if (!isNum)
    {
        destination = nextStep;
        if (destination == "End")
        {
            break;
        }
        cost = double.Parse(Console.ReadLine());
    } 
    else
    {
        cost -= n;
    }
    if (cost <= 0) {
        Console.WriteLine($"Going to {destination}!");
        
    }



}