namespace MergeFiles
{
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";
            MergeTextFiles(firstInputFilePath, secondInputFilePath,
           outputFilePath);
        }
        public static void MergeTextFiles(string firstInputFilePath, string
       secondInputFilePath, string outputFilePath)
        {
            using (StreamWriter writer = File.AppendText(outputFilePath))
            {
                
                using (StreamReader reader1 = File.OpenText(firstInputFilePath))
                {
 
                using (StreamReader reader2 = File.OpenText(secondInputFilePath))
                {
                   while (!reader1.EndOfStream || !reader2.EndOfStream)
                        {
                            if (!reader1.EndOfStream)
                            {
                                writer.WriteLine(reader1.ReadLine());
                            }
                            if (!reader2.EndOfStream)
                            {
                                writer.WriteLine(reader2.ReadLine());
                            }
                        }

                    
                }
                }
            }
        }
    }
}
