



string[] banList = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

string text = Console.ReadLine();

foreach (string banWord in banList)
{
    string replacement = new string('*', banWord.Length);
    text = text.Replace(banWord, replacement);
}

Console.WriteLine(text);