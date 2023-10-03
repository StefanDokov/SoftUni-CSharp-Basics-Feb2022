
using System.Net.Sockets;

int students = 0;
int standard = 0;
int kid = 0;
double allTickets = 0;
bool isOver = false;

while (true)
{

    string movie = Console.ReadLine();
    if (movie == "Finish")
    {
        isOver = true;
        break;
    }

    int seats = int.Parse(Console.ReadLine());
    double movieTickets = 0;


    while (true)
    {
        string ticket = Console.ReadLine();
        switch (ticket)
        {
            case "student":
                students++;
                break;
            case "standard":
                standard++;
                break;
            case "kid":
                kid++; 
                break;
        }
        

    if (ticket  == "End")
        {
        double percentMovie = movieTickets / seats * 100;
        Console.WriteLine($"{movie} - {percentMovie:f2}% full.");
        break;
    }
        


        if (ticket == "Finish")
    {
        isOver = true;
        break;
    }

        allTickets++;
        movieTickets++;

        if (movieTickets == seats)
        {
            double percentMovie = movieTickets / seats * 100;
            Console.WriteLine($"{movie} - {percentMovie:f2}% full.");
            break;
        }


    }

    if (isOver)
    {
        
        break;
    }
}
if (isOver)
{
    Console.WriteLine($"Total tickets: {allTickets}");
    Console.WriteLine($"{students / allTickets * 100:f2}% student tickets.");
    Console.WriteLine($"{standard / allTickets * 100:f2}% standard tickets.");
    Console.WriteLine($"{kid / allTickets * 100:f2}% kids tickets.");
}