using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace EvenLines
{
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder result = new StringBuilder();

            try
            {
                using (StreamReader reader = new StreamReader(inputFilePath))
                {
                    int lineNumber = 0;
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (lineNumber % 2 == 0)
                        {
                            // Replace '-', ', ', '. ', '! ', '? ' with '@'
                            line = Regex.Replace(line, @"[-,.\!\?]\s*", "@");

                            // Split the line into words, reverse them, and join them back
                            string[] words = line.Split(' ');
                            Array.Reverse(words);
                            line = string.Join(' ', words);

                            result.AppendLine(line);
                        }

                        lineNumber++;
                    }
                }
            }
            catch (Exception ex)
            {
                result.AppendLine("An error occurred: " + ex.Message);
            }

            return result.ToString();
        }
    }
}
