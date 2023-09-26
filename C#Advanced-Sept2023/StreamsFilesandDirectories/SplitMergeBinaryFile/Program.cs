using System;
using System.IO;

namespace SplitMergeBinaryFile
{
    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";
            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            try
            {
                using (FileStream sourceFile = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
                using (FileStream partOneFile = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
                using (FileStream partTwoFile = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
                {
                    long fileSize = sourceFile.Length;
                    int bufferSize = 1024;
                    byte[] buffer = new byte[bufferSize];
                    int bytesRead;

                    long partOneSize = fileSize / 2;
                    long partTwoSize = fileSize - partOneSize;

                    for (long bytesWritten = 0; bytesWritten < fileSize; bytesWritten += bytesRead)
                    {
                        if (bytesWritten + bufferSize > fileSize)
                            bufferSize = (int)(fileSize - bytesWritten);

                        bytesRead = sourceFile.Read(buffer, 0, bufferSize);

                        if (bytesWritten < partOneSize)
                            partOneFile.Write(buffer, 0, bytesRead);
                        else
                            partTwoFile.Write(buffer, 0, bytesRead);
                    }
                }

                Console.WriteLine("Splitting complete.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            try
            {
                using (FileStream partOneFile = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
                using (FileStream partTwoFile = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                using (FileStream joinedFile = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    int bytesRead;

                    while ((bytesRead = partOneFile.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        joinedFile.Write(buffer, 0, bytesRead);
                    }

                    while ((bytesRead = partTwoFile.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        joinedFile.Write(buffer, 0, bytesRead);
                    }
                }

                Console.WriteLine("Merging complete.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}