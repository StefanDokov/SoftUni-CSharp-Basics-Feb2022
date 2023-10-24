



double money = double.Parse(Console.ReadLine());

string game;
bool isOver = false;
double spender = 0;
while ((game = Console.ReadLine()) != "Game Time")
{
    switch (game)
    {
        case "OutFall 4":
            if (money - 39.99 < 0)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                money -= 39.99;
                spender += 39.99;
                Console.WriteLine($"Bought OutFall 4");
            }
            break;
        case "CS: OG":
            if (money - 15.99 < 0)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                money -= 15.99;
                spender += 15.99;

                Console.WriteLine($"Bought CS: OG");
            }
            break;
        case "Zplinter Zell":
            if (money - 19.99 < 0)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                money -= 19.99;
                spender += 19.99;

                Console.WriteLine($"Bought Zplinter Zell");
            }
            break;
        case "Honored 2":
            if (money - 59.99 < 0)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                money -= 59.99;
                spender += 59.99;

                Console.WriteLine($"Bought Honored 2");
            }
            break;
        case "RoverWatch":
            if (money - 29.99 < 0)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                money -= 29.99;
                spender += 29.99;

                Console.WriteLine($"Bought RoverWatch");
            }
            break;
        case "RoverWatch Origins Edition":
            if (money - 39.99 < 0)
            {
                Console.WriteLine("Too Expensive");
            }
            else
            {
                money -= 39.99;
                spender += 39.99;

                Console.WriteLine($"Bought RoverWatch Origins Edition ");
            }
            break;
        default:
            Console.WriteLine("Not Found");
            break;
    }

    if (money == 0)
    {
        Console.WriteLine("Out of money!");
        isOver = true;
        break;
    }

}

if (!isOver)
{
    Console.WriteLine($"Total spent: ${spender:f2}. Remaining: ${money:f2}");
}