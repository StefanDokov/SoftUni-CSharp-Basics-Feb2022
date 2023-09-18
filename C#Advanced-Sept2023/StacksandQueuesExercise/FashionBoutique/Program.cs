



Stack<int> boxes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

int sum = int.Parse(Console.ReadLine());
int racks = 1;
int currSum = 0;

while (boxes.Count > 0)
{
    int currBox = boxes.Pop();

    if (currSum + currBox > sum)
    {
        racks++;
        currSum = currBox;
    } else
    {
        currSum += currBox;
    }

}

Console.WriteLine(racks);