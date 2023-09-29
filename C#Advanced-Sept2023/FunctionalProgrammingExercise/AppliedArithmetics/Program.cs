


Func<string, List<int>, List<int>> calc = (command, numbers) =>
{
    List<int> result = new List<int>();

    foreach (int number in numbers)
    {
        switch (command)
        {
            case "add":
                result.Add(number + 1); 
                break;
            case "multiply":
                result.Add(number * 2);
                break;
            case "subtract": 
                result.Add(number -1);
                break;
        }
    }


    return result;
};

Action<List<int>> print = ints => Console.WriteLine(string.Join(" ", ints));
   
List<int> numbs = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

string command;

while ((command = Console.ReadLine()) != "end")
{
    if (command == "print")
    {
        print(numbs);
    }
    else
    {
       numbs = calc(command, numbs);
    }


}