


namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string
       bytesFilePath, string outputPath)
        {

            try
            {
                // Read the list of bytes from bytes.txt
                List<byte> bytesInFile = new List<byte>();
                using (StreamReader reader = new StreamReader(bytesFilePath))
                {
                    
                    while (reader.ReadLine() != null)
                    {
                        if (byte.TryParse(reader.ReadLine(), out byte byteValue))
                        {
                            bytesInFile.Add(byteValue);
                        }
                    }
                }

                // Open the input binary file (example.png) and output binary file (output.bin)
                using (FileStream input = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
                using (FileStream output = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    int readbytes;

                    while ((readbytes = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        for (int i = 0; i < readbytes; i++)
                        {
                            if (bytesInFile.Contains(buffer[i]))
                            {
                                // Write the matching byte to the output file
                                output.WriteByte(buffer[i]);
                            }
                        }
                    }
                }

                Console.WriteLine("Extraction complete. Output saved to output.bin");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }



        }
    }
}
