


Stack<int> output = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

string command = Console.ReadLine().ToLower();

while (command != "end")
{
    string[] splitted = command.Split(' ');
    if (splitted[0] == "add")
    {
        int first = int.Parse(splitted[1]);
        int second = int.Parse(splitted[2]);
        output.Push(first);
        output.Push(second);
    } 
    if (splitted[0] == "remove")
    {
        int n = int.Parse(splitted[1]);

        if (output.Count >= n)
        {
            for (int i = 0; i < n; i++) {
                output.Pop();
            }
        }
    }
    command = Console.ReadLine().ToLower();
}

int sum = 0;

while (output.Count > 0)
{
    sum += output.Pop();
}

Console.WriteLine($"Sum: {sum}");