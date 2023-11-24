





int n = int.Parse(Console.ReadLine());

string input;
int bigger = 0;
int best = 0;
int current = 0;
int sum = 0;
string text = ""; 
int bestindex = n + 1;
while ((input = Console.ReadLine()) != "Clone them!")
{
    
    current++;
    int[] arr = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();
    if (text == "")
    {
        text = string.Join(" ", arr);
    }
    int cont = 0;
    int startindex = -1;

    for (int i = 0; i < arr.Length; i++)
    {
       
       if (arr[i] == 1)
        { 
            if (startindex < 0)
            {
                startindex = i;
            }
            cont++;


            if (cont == bigger && startindex < bestindex)
            {
                bestindex = startindex;
                best = current;
                text = string.Join(" ", arr);
                sum = arr.Sum();
            }
            else if (cont == bigger && startindex == bestindex)
            {
                if (arr.Sum() > sum)
                {
                    bestindex = startindex;
                    best = current;
                    sum = arr.Sum();
                    text = string.Join(" ", arr);
                }
            }
            else if (cont > bigger)
            {
                bigger = cont;
                bestindex = startindex;
                best = current;
                text = string.Join(" ", arr);
                sum = arr.Sum();

            }
        }
       else
        {
            cont = 0;
            startindex = -1;
        }



    }
   



}
if (best == 0 && sum == 0)
{
    Console.WriteLine($"Best DNA sample 1 with sum: {sum}.");
    Console.WriteLine(text);

}
else
{

Console.WriteLine($"Best DNA sample {best} with sum: {sum}.");
Console.WriteLine(text);
}