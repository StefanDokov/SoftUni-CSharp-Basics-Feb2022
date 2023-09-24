


int n = int.Parse(Console.ReadLine());

if (n == 0)
{
    return;
}

Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

while (n > 0)
{
    string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    if (!students.ContainsKey(names[0]))
    {
        students[names[0]] = new List<decimal>();
    } 
    
        students[names[0]].Add(decimal.Parse(names[1]));
    


    n--;
}

foreach (var (studentName, studentGrades) in students)
{
    var grades = string.Join(" ", studentGrades.Select(x => x.ToString("F2")));

    Console.Write($"{studentName} -> {grades} (avg: {studentGrades.Average():f2})");
    Console.WriteLine();
}


