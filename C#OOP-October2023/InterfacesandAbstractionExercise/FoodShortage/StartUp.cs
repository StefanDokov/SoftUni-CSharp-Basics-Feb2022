



using FoodShortage.Models;

namespace FoodShortage;

public class StartUp
{

    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        List<IBuyer> list = new();
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);


            if (input.Length == 3)
            {
                IBuyer person = new Rebel(input[0], int.Parse(input[1]), input[2]);
                list.Add(person);
            }
            else
            {
                IBuyer person = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                list.Add(person);
            }



        }
        string secondInput;

        while ((secondInput = Console.ReadLine()) != "End")
        {

            foreach (IBuyer person in list)
            {
                if (person.Name == secondInput)
                {
                    person.BuyFood();
                }
            }



        }
        

        Console.WriteLine(list.Sum(b => b.Food));
    }

}
