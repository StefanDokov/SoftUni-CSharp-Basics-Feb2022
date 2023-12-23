


List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

bool changesMade = false;

string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] tokens = command.Split();
    string action = tokens[0];

    switch (action)
    {
        case "Add":
            int numberToAdd = int.Parse(tokens[1]);
            numbers.Add(numberToAdd);
            changesMade = true;
            break;

        case "Remove":
            int numberToRemove = int.Parse(tokens[1]);
            numbers.Remove(numberToRemove);
            changesMade = true;
            break;

        case "RemoveAt":
            int indexToRemoveAt = int.Parse(tokens[1]);
            numbers.RemoveAt(indexToRemoveAt);
            changesMade = true;
            break;

        case "Insert":
            int numberToInsert = int.Parse(tokens[1]);
            int indexToInsert = int.Parse(tokens[2]);
            numbers.Insert(indexToInsert, numberToInsert);
            changesMade = true;
            break;

        case "Contains":
            int numberToCheck = int.Parse(tokens[1]);
            Console.WriteLine(numbers.Contains(numberToCheck) ? "Yes" : "No such number");
            break;

        case "PrintEven":
            Console.WriteLine(string.Join(' ', numbers.Where(num => num % 2 == 0)));
            break;

        case "PrintOdd":
            Console.WriteLine(string.Join(' ', numbers.Where(num => num % 2 != 0)));
            break;

        case "GetSum":
            Console.WriteLine(numbers.Sum());
            break;

        case "Filter":
            string condition = tokens[1];
            int filterNumber = int.Parse(tokens[2]);

            switch (condition)
            {
                case ">":
                    Console.WriteLine(string.Join(' ', numbers.Where(num => num > filterNumber)));
                    break;

                case "<":
                    Console.WriteLine(string.Join(' ', numbers.Where(num => num < filterNumber)));
                    break;

                case ">=":
                    Console.WriteLine(string.Join(' ', numbers.Where(num => num >= filterNumber)));
                    break;

                case "<=":
                    Console.WriteLine(string.Join(' ', numbers.Where(num => num <= filterNumber)));
                    break;
            }
            break;
    }
}

if (changesMade)
{
    Console.WriteLine(string.Join(' ', numbers));
}