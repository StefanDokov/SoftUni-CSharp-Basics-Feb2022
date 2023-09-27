using System;
using System.IO;
using System.IO.Compression;

namespace ZipAndExtract
{
    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = "copyMe.png";
            string zipArchiveFile = "archive.zip";
            string extractedFile = "extracted.png";

            // Zip the input file
            ZipFileToArchive(inputFile, zipArchiveFile);

            // Extract the file from the archive
            ExtractFileFromArchive(zipArchiveFile, inputFile, extractedFile);

            Console.WriteLine("ZIP and extraction complete.");
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            try
            {
                using (FileStream input = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                using (FileStream output = new FileStream(zipArchiveFilePath, FileMode.Create, FileAccess.Write))
                using (ZipArchive archive = new ZipArchive(output, ZipArchiveMode.Create))
                {
                    ZipArchiveEntry entry = archive.CreateEntry(Path.GetFileName(inputFilePath));
                    using (Stream entryStream = entry.Open())
                    {
                        input.CopyTo(entryStream);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during zipping: " + ex.Message);
            }
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            try
            {
                using (FileStream archiveStream = new FileStream(zipArchiveFilePath, FileMode.Open, FileAccess.Read))
                using (ZipArchive archive = new ZipArchive(archiveStream, ZipArchiveMode.Read))
                {
                    foreach (ZipArchiveEntry entry in archive.Entries)
                    {
                        if (entry.Name == fileName)
                        {
                            using (Stream entryStream = entry.Open())
                            using (FileStream output = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                            {
                                entryStream.CopyTo(output);
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during extraction: " + ex.Message);
            }
        }
    }
}
