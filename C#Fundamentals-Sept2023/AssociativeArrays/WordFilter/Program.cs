



string[] words = Console.ReadLine().Split(' ');

FilterAndPrintEvenLengthWords(words);

    static void FilterAndPrintEvenLengthWords(string[] words)
{

    foreach (string word in words)
    {
        if (IsEvenLength(word))
        {
            Console.WriteLine(word);
        }
    }
}

static bool IsEvenLength(string word)
{
    return word.Length % 2 == 0;
}