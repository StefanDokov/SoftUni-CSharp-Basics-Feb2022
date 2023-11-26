

using System;

class Fibonacci
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 50)
        {
            Console.WriteLine("Invalid input. N should be between 1 and 50.");
        }
        else
        {
            int result = GetFibonacci(n);
            Console.WriteLine(result);
        }
    }

    static int GetFibonacci(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        else
        {
            return GetFibonacci(n - 1) + GetFibonacci(n - 2);
        }
    }
}