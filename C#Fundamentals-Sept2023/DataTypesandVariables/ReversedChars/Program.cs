

char[] basicArr = new char[3];

for (int i = 0; i < 3; i++)
{
    basicArr[i] = char.Parse(Console.ReadLine());


}

Array.Reverse(basicArr, 0, 3);

Console.WriteLine(String.Join(" ", basicArr));