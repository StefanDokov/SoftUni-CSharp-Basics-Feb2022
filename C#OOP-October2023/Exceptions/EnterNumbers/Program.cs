


using System;

class Program
{
    static void Main()
    {
        string[] elements = Console.ReadLine().Split(' ');
        int sum = 0;

        foreach (var element in elements)
        {
            try
            {
                int number = int.Parse(element);
                sum += number;
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
            }
            catch (FormatException)
            {

                Console.WriteLine($"The element '{element}' is in wrong format!");
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");

            }
            catch (OverflowException)
            {
                Console.WriteLine($"The element '{element}' is out of range!");
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");

            }
        }

        Console.WriteLine($"The total sum of all integers is: {sum}");
    }
}