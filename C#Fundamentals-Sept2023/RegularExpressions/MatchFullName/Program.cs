using System;
using System.Text.RegularExpressions;

namespace TechnologyFundamentalsPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            MatchCollection names = Regex.Matches(input, pattern);

            foreach (var name in names)
            {
                Console.Write(name + " ");
            }

            Console.WriteLine();
        }
    }
}