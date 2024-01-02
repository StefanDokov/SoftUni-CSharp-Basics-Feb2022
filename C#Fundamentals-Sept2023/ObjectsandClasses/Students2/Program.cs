using System;
using System.Collections.Generic;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}

class Program
{
    static void Main()
    {
        Dictionary<string, Student> students = new Dictionary<string, Student>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
                break;

            string[] studentInfo = input.Split(' ');
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];
            int age = int.Parse(studentInfo[2]);
            string homeTown = studentInfo[3];

            string fullName = $"{firstName} {lastName}";

            // Check if the student already exists
            if (students.ContainsKey(fullName))
            {
                students[fullName].Age = age;
                students[fullName].HomeTown = homeTown;
            }
            else
            {
                Student student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };

                students.Add(fullName, student);
            }
        }

        string city = Console.ReadLine();

        foreach (var student in students.Values)
        {
            if (student.HomeTown == city)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
    }
}