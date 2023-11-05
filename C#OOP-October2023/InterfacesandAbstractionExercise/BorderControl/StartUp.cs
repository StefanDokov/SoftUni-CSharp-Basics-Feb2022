


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

            if(inputArr.Length == 3)
            {
                ICheckable person = new Person(inputArr[0], int.Parse(inputArr[1]), inputArr[2]);
                list.Add(person);
            }

            if (inputArr.Length == 2) 
            {
                ICheckable person = new Robot(inputArr[0], inputArr[1]);
                list.Add(person);

            }


        }
        input = Console.ReadLine();
        foreach (ICheckable person in list)
        {
            person.CheckId(input);
        }
        
    }

}
