





int[] arr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int index = 0;
int firstSum = 0;
int secondSum = 0;
bool isOver = false;
while (index < arr.Length)
{

    for (int i = 0; i < index; i++)
    {
        firstSum += arr[i];

    }
    for (int j = index + 1; j < arr.Length; j++)
    {
        secondSum += arr[j];
    }
    if (firstSum == secondSum)
    {
        Console.WriteLine(index);
        isOver = true;
        break;
    }

    index++;
    firstSum = 0; 
    secondSum = 0;
}

if (!isOver)
{
    Console.WriteLine("no");
}
