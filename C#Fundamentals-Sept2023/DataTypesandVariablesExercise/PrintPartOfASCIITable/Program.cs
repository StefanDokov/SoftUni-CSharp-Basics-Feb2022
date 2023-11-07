


using System.Text;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

StringBuilder sb = new StringBuilder();
for (int i = a; i <= b; i++)
{
    sb.Append($"{(char)i} ");
}
Console.WriteLine(sb.ToString().Trim());