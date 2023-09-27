using System;
using System.IO;

namespace CopyDirectory
{
    public class CopyDirectory
    {
        static void Main()
        {
            Console.Write("Enter the input directory path: ");
            string inputPath = Console.ReadLine();
            Console.Write("Enter the output directory path: ");
            string outputPath = Console.ReadLine();

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            try
            {
                if (Directory.Exists(outputPath))
                {
                    // Delete the existing output directory and its content
                    Directory.Delete(outputPath, true);
                }

                Directory.CreateDirectory(outputPath);

                string[] files = Directory.GetFiles(inputPath);

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string destinationFilePath = Path.Combine(outputPath, fileName);
                    File.Copy(file, destinationFilePath);
                }

                Console.WriteLine("Directory copied successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}