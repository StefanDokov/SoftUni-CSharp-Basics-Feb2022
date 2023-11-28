





    string typeOfDrink = Console.ReadLine();

    
    int amountOfDrinks = int.Parse(Console.ReadLine());


    Pricer(typeOfDrink, amountOfDrinks);

    static void Pricer(string kindOfDrink, int amount)
    {
        double price = 0;
        switch (kindOfDrink)
        {

            case "coffee":
                price = 1.50d;
                break;
            case "water":
                price = 1d;
                break;
            case "coke":
                price = 1.40d;
                break;
            case "snacks":
                price = 2d;
                break;



        }

    double result = amount * price;
    Console.WriteLine($"{result:f2}");


    }






