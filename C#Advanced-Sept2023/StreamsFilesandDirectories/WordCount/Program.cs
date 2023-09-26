


namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string
       textFilePath, string outputFilePath)
        {
            using(StreamReader sr = new StreamReader(wordsFilePath))
            {
                string[] wordsWeHave = sr.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Dictionary<string, int> wordsValus = new Dictionary<string, int>();

                foreach (string word in wordsWeHave)
                {
                    wordsValus.Add(word, 0);
                }

                using(StreamReader sentances = new StreamReader(textFilePath))
                {

                    while(!sentances.EndOfStream) 
                    {
                      string[] sentance = sentances.ReadLine().Split(new string[] {"-", " ", ", ", "?!", "?", "...","."},StringSplitOptions.RemoveEmptyEntries);

                      foreach (string word in sentance)
                        {
                            foreach(string wordd in wordsValus.Keys) 
                            { 
                                if (word.ToLower() == wordd)
                                {
                                    wordsValus[wordd]++;
                                }
                            }
                        }

                    }
                    using(StreamWriter streamWriter = new StreamWriter(outputFilePath))
                    {
                        foreach (var word in wordsValus.OrderByDescending(wv => wv.Value))
                        {
                            streamWriter.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                }

            }







        }
    }
}