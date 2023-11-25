




using System.Text;

int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    arr[i] = sumerer(input);

    
}

arr = arr.OrderBy(x => x).ToArray();

StringBuilder sb = new StringBuilder();
foreach (int i in arr)
{
    sb.AppendLine(i.ToString());
}

Console.WriteLine(sb.ToString().Trim());
static int sumerer(string name)
{
    int sum = 0;
    foreach(char c in name)
    {
        
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
            || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
        {
            sum += (int)c * name.Length;
        }
        else
        {
            sum += (int)c / name.Length;
        }
        
    }
    return sum;
}

