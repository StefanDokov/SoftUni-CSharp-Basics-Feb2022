


Queue<string> songs = new Queue<string> (Console.ReadLine().Split(", "));

while(songs.Count > 0)
{
    string[] command = Console.ReadLine().Split(" ").ToArray();

    if (command[0] == "Play")
    {
        songs.Dequeue();
    }
    if (command[0] == "Add")
    {
        if (songs.Contains(String.Join(" ", command.Skip(1))))
        {
            Console.WriteLine($"{String.Join(" ", command.Skip(1))} is already contained!");
            continue;
        }
        songs.Enqueue(String.Join(" ", command.Skip(1)));
    }
    if (command[0] == "Show")
    {
        Console.WriteLine(string.Join(", ", songs));
    }
}

Console.WriteLine("No more songs!");