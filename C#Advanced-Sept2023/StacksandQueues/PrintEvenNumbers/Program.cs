

Queue<int> input = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
bool checkFirst = true;
while (input.Count > 0)
{
    int numba = input.Dequeue();

    if (numba % 2 == 0)
    {
        if (checkFirst)
        {

        Console.Write($"{numba}");
            checkFirst = false;
        } else
        {
            Console.Write($", {numba}");
        }
    }
}