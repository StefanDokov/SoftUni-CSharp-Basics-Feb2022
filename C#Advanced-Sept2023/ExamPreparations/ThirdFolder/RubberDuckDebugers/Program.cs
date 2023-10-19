



Queue<int> sequences = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Stack<int> tasks = new(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int dartvaderduck = 0;
int thorduck = 0;
int bigblueduck = 0;
int smallyellowduck = 0;


while (sequences.Count > 0)
{
     
    int currentSeq = sequences.Dequeue();
    int currentTask = tasks.Pop();
    int result = currentSeq * currentTask;

    if (result >= 0 && result <= 60)
    {
        dartvaderduck++;
    }
    else if (result >= 61 && result <= 120)
    {
        thorduck++;
    }
    else if (result >= 121 && result <= 180)
    {
        bigblueduck++;
    }
    else if (result >= 181 && result <= 240)
    {
        smallyellowduck++;
    }
    else
    {
        currentTask -= 2;
        tasks.Push(currentTask);
        sequences.Enqueue(currentSeq);
    }



}
Console.WriteLine("Congratulations, all tasks have been completed! Rubber ducks rewarded:");
Console.WriteLine($"Darth Vader Ducky: {dartvaderduck}");
Console.WriteLine($"Thor Ducky: {thorduck}");
Console.WriteLine($"Big Blue Rubber Ducky: {bigblueduck}");
Console.WriteLine($"Small Yellow Rubber Ducky: {smallyellowduck}");