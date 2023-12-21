

List<int> list1 = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToList();

List<int> list2 = Console.ReadLine()
                        .Split(' ')
                        .Select(int.Parse)
                        .ToList();

List<int> resultList = MergeLists(list1, list2);

Console.WriteLine(string.Join(" ", resultList));
    

    static List<int> MergeLists(List<int> list1, List<int> list2)
{
    List<int> result = new List<int>();

    int length1 = list1.Count;
    int length2 = list2.Count;

    int minLength = Math.Min(length1, length2);

    for (int i = 0; i < minLength; i++)
    {
        result.Add(list1[i]);
        result.Add(list2[i]);
    }

    for (int i = minLength; i < length1; i++)
    {
        result.Add(list1[i]);
    }

    for (int i = minLength; i < length2; i++)
    {
        result.Add(list2[i]);
    }

    return result;
}