

using System.Text;

int[] arr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

int n = int.Parse(Console.ReadLine());

int b = 0;
StringBuilder sb = new StringBuilder();
while (b < arr.Length - 1)
{
    int first = arr[b];
    for(int i = b + 1; i < arr.Length; i++)
    {

        int second = arr[i];
        if ((first + second) == n)
        {
            sb.AppendLine($"{first} {second}");
        }
    }
    

    b++;
}

Console.WriteLine(sb.ToString().TrimEnd());
