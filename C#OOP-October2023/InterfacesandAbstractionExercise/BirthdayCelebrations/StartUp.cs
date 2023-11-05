


using BirthdayCelebrations;
using BorderControl.Models;

namespace BorderControl;

public class StartUp
{

    static void Main(string[] args)
    {

        string input;
        List<ICheckable> list = new();

        while ((input = Console.ReadLine()) != "End") {

            string[] inputArr = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (inputArr[0] == "Citizen")
            {
                ICheckable person = new Person(inputArr[1], int.Parse(inputArr[2]), inputArr[3], inputArr[4]);
                list.Add(person);
            }

            else if (inputArr[0] == "Pet") 
            {
                ICheckable person = new Pet(inputArr[1], inputArr[2]);
                list.Add(person);

            }


        }
        input = Console.ReadLine();
        List<string> nov = new();
        foreach (ICheckable person in list)
        {
            person.CheckBirthdate(input);
        }
       
  
    }

}
