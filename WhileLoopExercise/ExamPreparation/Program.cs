


int poorGrades = int.Parse(Console.ReadLine());
int starter = 0;

List<double> allGrades = new List<double>();
Stack<string> stack = new Stack<string>();
while (starter < poorGrades)
{
    string problem = Console.ReadLine();
    if (problem == "Enough")
    {
        break;
    }

    double grade = double.Parse(Console.ReadLine());

    allGrades.Add(grade);

    stack.Push(problem);

    if (grade <= 4)
    {
        starter++;
    }
    
}

if (starter == poorGrades)
{
    Console.WriteLine($"You need a break, {starter} poor grades.");
} 
else
{
    Console.WriteLine($"Average score: {allGrades.Average():f2}");
    Console.WriteLine($"Number of problems: {allGrades.Count}");
    Console.WriteLine($"Last problem: {stack.Peek()}");
}
