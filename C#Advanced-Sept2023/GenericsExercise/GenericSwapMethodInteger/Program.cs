


using GenericSwapMethodInteger;

Box<int> boxList = new();


int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    boxList.Add(int.Parse(Console.ReadLine()));

}

int[] swappers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

boxList.Swap(swappers[0], swappers[1]);


Console.WriteLine(boxList.ToString());
