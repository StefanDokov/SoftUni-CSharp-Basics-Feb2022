

int[] array = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int n = int.Parse(Console.ReadLine());


for (int i = 0; i < n; i++)
{

   int temp = array[0];


    for (int b = 0; b < array.Length - 1; b++)
{
    array[b] = array[b + 1];
}

   array[array.Length - 1] = temp;

}

Console.WriteLine(string.Join(" ", array));

