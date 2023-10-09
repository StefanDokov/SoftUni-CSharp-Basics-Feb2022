



string dayType = Console.ReadLine();
int age = int.Parse(Console.ReadLine());


int ticket = 0;


if (age < 0 || age > 122)
{
    Console.WriteLine("Error!");
}
else
{
    switch (dayType)
    {
        case "Weekday":
            if (age >= 0 && age <= 18)
            {
                ticket = 12;
            }
            else if (age > 18 && age <= 64)
            {
                ticket = 18;
            }
            else if (age > 64 && age <= 122)
            {
                ticket = 12;
            }
            break;
        case "Weekend":
            if (age >= 0 && age <= 18)
            {
                ticket = 15;
            }
            else if (age > 18 && age <= 64)
            {
                ticket = 20;
            }
            else if (age > 64 && age <= 122)
            {
                ticket = 15;
            }
            break;
        case "Holiday":
            if (age >= 0 && age <= 18)
            {
                ticket = 5;
            }
            else if (age > 18 && age <= 64)
            {
                ticket = 12;
            }
            else if (age > 64 && age <= 122)
            {
                ticket = 10;
            }
            break;
    }

    Console.WriteLine($"{ticket}$");
}