
using System;

class PascalTriangle
{
    static void Main()
    {
        int numRows = int.Parse(Console.ReadLine()); 

        GeneratePascalTriangle(numRows);
    }

    static void GeneratePascalTriangle(int numRows)
    {
        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(CalculateBinomialCoefficient(i, j) + " ");
            }

            Console.WriteLine();
        }
    }

    static int CalculateBinomialCoefficient(int n, int k)
    {
        if (k == 0 || k == n)
        {
            return 1;
        }
        else
        {
            return CalculateBinomialCoefficient(n - 1, k - 1) + CalculateBinomialCoefficient(n - 1, k);
        }
    }
}
