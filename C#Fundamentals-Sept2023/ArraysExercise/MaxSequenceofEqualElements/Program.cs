


int[] arr = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();


int counter = 1;
int maxCounter = 1;
int prev = arr[0];
int index = 1;
int best = arr[0];
bool isDiff = false;
if (arr.Length == 1)
{
    Console.WriteLine(arr[0]);
}
else
{
    

while (index < arr.Length)
{
    int curr = arr[index];

    if (curr == prev)
    {
        counter++;
            if (counter > maxCounter)
            {
                maxCounter = counter;
                best = prev;
            }
        }
    else
    {
        isDiff = true;
        if (counter > maxCounter)
        {
            maxCounter = counter;
            best = prev;
            counter = 1;
        } 
        else
        {
            counter = 1;
        }
    }


    prev = curr;
    index++;
}

if (!isDiff)
{
    maxCounter = counter;
}


for (int i = 0; i < maxCounter; i++)
{
    Console.Write(best + " ");
}
Console.WriteLine();



}
