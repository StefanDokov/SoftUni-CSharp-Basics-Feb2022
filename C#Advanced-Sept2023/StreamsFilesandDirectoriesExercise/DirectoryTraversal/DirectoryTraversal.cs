using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DirectoryTraversal
{
    public class DirectoryTraversal
    {
        static void Main()
        {
            Console.Write("Enter the directory path: ");
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";
            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);
            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            try
            {
                Dictionary<string, List<FileInfo>> filesByExtension = new Dictionary<string, List<FileInfo>>();
                DirectoryInfo directoryInfo = new DirectoryInfo(inputFolderPath);

                foreach (var fileInfo in directoryInfo.GetFiles("*.*").Where(file => !file.Attributes.HasFlag(FileAttributes.Directory)))
                {
                    string extension = fileInfo.Extension;

                    if (!filesByExtension.ContainsKey(extension))
                    {
                        filesByExtension[extension] = new List<FileInfo>();
                    }

                    filesByExtension[extension].Add(fileInfo);
                }

                StringBuilder report = new StringBuilder();

                foreach (var extensionGroup in filesByExtension.OrderByDescending(kv => kv.Value.Count).ThenBy(kv => kv.Key))
                {
                    report.AppendLine(extensionGroup.Key);

                    foreach (var fileInfo in extensionGroup.Value.OrderBy(file => file.Length))
                    {
                        report.AppendLine($"--{fileInfo.Name} - {fileInfo.Length / 1024.0:F3}KB");
                    }
                }

                return report.ToString();
            }
            catch (Exception ex)
            {
                return $"An error occurred: {ex.Message}";
            }
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string reportFilePath = desktopPath + reportFileName;

            try
            {
                File.WriteAllText(reportFilePath, textContent);
                Console.WriteLine($"Report saved to {reportFilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to write report: {ex.Message}");
            }
        }
    }
}
