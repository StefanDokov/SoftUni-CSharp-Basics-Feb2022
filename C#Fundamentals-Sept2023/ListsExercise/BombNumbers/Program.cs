



List<int> numbers = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

int[] bombData = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int bombNumber = bombData[0];
int bombPower = bombData[1];

DetonateBomb(numbers, bombNumber, bombPower);

Console.WriteLine(numbers.Sum());
    

    static void DetonateBomb(List<int> numbers, int bombNumber, int bombPower)
{
    while (numbers.Contains(bombNumber))
    {
        int bombIndex = numbers.IndexOf(bombNumber);

        int leftBound = Math.Max(0, bombIndex - bombPower);
        int rightBound = Math.Min(numbers.Count - 1, bombIndex + bombPower);

        int countToRemove = rightBound - leftBound + 1;

        numbers.RemoveRange(leftBound, countToRemove);
    }
}