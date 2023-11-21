


int[] arr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

for (int i = 0; i < arr.Length - 1; i++)
{
    int curr = arr[i];
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (curr <= arr[j])
        {
            break;
        }
        if (j == arr.Length - 1)
        {
            Console.Write(curr + " ");
        }
        
    }
    
}
Console.Write(arr[arr.Length - 1]);
Console.WriteLine();
