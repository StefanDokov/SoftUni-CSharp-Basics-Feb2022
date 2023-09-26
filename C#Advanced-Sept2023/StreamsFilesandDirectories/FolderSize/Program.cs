using System;
using System.IO;

namespace FolderSize
{
    public class FolderSize
    {
        static void Main()
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";
            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            try
            {
                long totalSize = CalculateFolderSize(folderPath);

                // Convert the size to kilobytes
                double sizeInKilobytes = totalSize / 1024.0;

                // Write the result to the output file
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    writer.WriteLine($"Folder Size: {sizeInKilobytes} KB");
                }

                Console.WriteLine($"Folder size calculated and saved to {outputFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private static long CalculateFolderSize(string folderPath)
        {
            long folderSize = 0;

            foreach (string file in Directory.GetFiles(folderPath))
            {
                FileInfo fileInfo = new FileInfo(file);
                folderSize += fileInfo.Length;
            }

            foreach (string subfolder in Directory.GetDirectories(folderPath))
            {
                folderSize += CalculateFolderSize(subfolder);
            }

            return folderSize;
        }
    }
}