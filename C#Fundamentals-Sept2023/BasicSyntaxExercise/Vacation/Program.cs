

int peopleN = int.Parse(Console.ReadLine());    

string type = Console.ReadLine();

string day = Console.ReadLine();

double price = 0;
switch (type)
{
    case "Students":
        if (day == "Friday")
        {
            price = 8.45;

        }
        else if(day == "Saturday")
        {
            price = 9.80;
        }
        else if (day == "Sunday")
        {
            price = 10.46;
        }
        break;
    case "Business":
        if (day == "Friday")
        {
            price = 10.90;

        }
        else if (day == "Saturday")
        {
            price = 15.60;
        }
        else if (day == "Sunday")
        {
            price = 16;
        }
        break;

    case "Regular":
        if (day == "Friday")
        {
            price = 15;

        }
        else if (day == "Saturday")
        {
            price = 20;
        }
        else if (day == "Sunday")
        {
            price = 22.50;
        }
        break;
}
double fullPrice = peopleN * price;
if (type == "Students" && peopleN >= 30)
{
    fullPrice *= 0.85;
}
if (type == "Business" && peopleN >= 100)
{
    fullPrice -= 10 * price;
}
if (type == "Regular" && peopleN >= 10 && peopleN <= 20)
{
    fullPrice *= 0.95;
}



Console.WriteLine($"Total price: {fullPrice:f2}");