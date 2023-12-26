﻿


List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

string command;
while ((command = Console.ReadLine()) != "End")
{
    string[] tokens = command.Split(' ');

    switch (tokens[0])
    {
        case "Add":
            int numberToAdd = int.Parse(tokens[1]);
            numbers.Add(numberToAdd);
            break;

        case "Insert":
            int numberToInsert = int.Parse(tokens[1]);
            int indexToInsert = int.Parse(tokens[2]);

            if (IsValidIndex(indexToInsert, numbers.Count))
            {
                numbers.Insert(indexToInsert, numberToInsert);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;

        case "Remove":
            int indexToRemove = int.Parse(tokens[1]);

            if (IsValidIndex(indexToRemove, numbers.Count))
            {
                numbers.RemoveAt(indexToRemove);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;

        case "Shift":
            int count = int.Parse(tokens[2]);

            if (tokens[1] == "left")
            {
                ShiftLeft(numbers, count);
            }
            else if (tokens[1] == "right")
            {
                ShiftRight(numbers, count);
            }
            break;
    }
}

Console.WriteLine(string.Join(" ", numbers));
    

    static bool IsValidIndex(int index, int length)
{
    return index >= 0 && index < length;
}

static void ShiftLeft(List<int> numbers, int count)
{
    count %= numbers.Count;

    for (int i = 0; i < count; i++)
    {
        int firstNumber = numbers[0];
        numbers.RemoveAt(0);
        numbers.Add(firstNumber);
    }
}

static void ShiftRight(List<int> numbers, int count)
{
    count %= numbers.Count;

    for (int i = 0; i < count; i++)
    {
        int lastNumber = numbers[numbers.Count - 1];
        numbers.RemoveAt(numbers.Count - 1);
        numbers.Insert(0, lastNumber);
    }
}