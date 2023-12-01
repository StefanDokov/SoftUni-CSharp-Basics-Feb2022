

using System.Text;

int n = int.Parse(Console.ReadLine());

string row = "";
for (int i = 0; i < n; i++)
{
    row += $"{n} ";
}

StringBuilder sb = new StringBuilder();

for (int i = 0; i < n; i++)
{
    sb.AppendLine(row);
}

Console.WriteLine(sb.ToString().Trim());