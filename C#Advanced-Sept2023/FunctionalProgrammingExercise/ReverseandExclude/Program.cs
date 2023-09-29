


Func<List<int>, List<int>> reverser = numbers =>
{
    List<int> result = new List<int>();

    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        result.Add(numbers[i]);
    }
    return result;
};


Func<List<int>, Predicate<int>, List<int>> exclude = (numbers, match) =>
{
    List<int> res = new List<int>();


    foreach (int i in numbers)
    {
        if (!match(i))
        {
            res.Add(i);
        }
    }

    return res;
};

List<int> ints = new List<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToList());

int divider = int.Parse(Console.ReadLine());


Predicate<int> chek = num => num % divider == 0;

ints = exclude(ints, chek);
ints = reverser(ints);

Console.WriteLine(string.Join(" ", ints));