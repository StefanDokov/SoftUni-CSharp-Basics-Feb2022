int n = int.Parse(Console.ReadLine());
Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(name))
    {
        students[name] = new List<double>();
    }

    students[name].Add(grade);
}

var filteredStudents = students
    .Where(s => s.Value.Average() >= 4.50)
    .ToDictionary(s => s.Key, s => s.Value.Average());

foreach (var student in filteredStudents)
{
    Console.WriteLine($"{student.Key} -> {student.Value:F2}");
}