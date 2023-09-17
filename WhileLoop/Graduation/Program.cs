


string name = Console.ReadLine();

double grade;
bool result = double.TryParse(Console.ReadLine(), out grade);
double sumGrades = 0;
int gradesCount = 0;
int lowGrade = 0;
bool isIt = true;

while (result)
{

    if (grade < 4)
    {
        lowGrade++;
        if (lowGrade == 2)
        {
            Console.WriteLine($"{name} has been excluded at {gradesCount} grade");
            isIt = false;
            break;
        }
    }
    sumGrades += grade;
    gradesCount++;



    result = double.TryParse(Console.ReadLine(), out grade);
}


if (isIt)
{
    Console.WriteLine($"{name} graduated. Average grade: {sumGrades / gradesCount:f2}");
}