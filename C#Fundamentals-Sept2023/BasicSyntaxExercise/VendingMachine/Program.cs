


double money = 0;

string input;

while ((input = Console.ReadLine()) != "Start")
{
    double middle = double.Parse(input);

    if (middle != 1 && middle != 2 && middle != 0.1 && middle != 0.2 && middle != 0.5)
    {
        Console.WriteLine($"Cannot accept {middle}");
    }
    else
    {

    money += middle;
    }
}

while ((input = Console.ReadLine()) != "End")
{
    double cost = 0;
    if (input == "Start")
    {
        continue;
    }
    switch (input)
    {
        case "Nuts":
            cost = 2.0;
            break;
        case "Water":
            cost = 0.7;
            break;
        case "Crisps":
            cost = 1.5;
            break;
        case "Soda":
            cost = 0.8;
            break;
        case "Coke":
            cost = 1.0;
            break;
        default:
            Console.WriteLine("Invalid product");
            cost = -1;
            break;

    }
    if (cost < 0)
    {
        continue;
    }
    if (money >= cost) 
    {
        Console.WriteLine($"Purchased {input.ToLower()}");
        money -= cost;
    }
    else
    {
        Console.WriteLine("Sorry, not enough money");
    }

}

if (input  == "End")
{
    Console.WriteLine($"Change: {money:f2}");
}