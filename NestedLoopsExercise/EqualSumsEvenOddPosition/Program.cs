



string first = Console.ReadLine();
string second = Console.ReadLine();


for (int i = int.Parse(first);i <= int.Parse(second); i++)
{

    int evenSum = 0;
    int oddSum = 0;
   for (int k = 0; k < i.ToString().Length; k++)
    {
        char current = i.ToString()[k];
        int currentNum = int.Parse(current.ToString());
        if (k % 2 == 0)
        {
            evenSum += currentNum;
        }
        else
        {
            oddSum += currentNum;
        }
    }

   if (evenSum == oddSum)
    {
        Console.Write(i + " ");
    }


}
Console.WriteLine();