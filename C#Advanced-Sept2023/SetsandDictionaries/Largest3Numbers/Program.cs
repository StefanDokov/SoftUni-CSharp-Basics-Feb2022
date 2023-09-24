




List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();


List<int> largest = numbers.OrderByDescending(x => x).ToList();

int count = 3;

if (largest.Count < 3)
{
    count = largest.Count;
}

List<int> result = largest.Take(3).ToList();


Console.WriteLine(string.Join(" ", result));