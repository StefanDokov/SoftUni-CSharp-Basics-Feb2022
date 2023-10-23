


double money = double.Parse(Console.ReadLine());
double students = double.Parse(Console.ReadLine());
double lightPrice  = double.Parse(Console.ReadLine());
double robePrice  = double.Parse(Console.ReadLine());
double beltPrice  = double.Parse(Console.ReadLine());

double sum;

double freeBelts = Math.Floor(students / 6);
sum = lightPrice * Math.Ceiling(students * 1.1) + robePrice * students 
    + beltPrice * (students - freeBelts);

if (sum <= money)
{
    Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
}
else
{
    Console.WriteLine($"John will need {sum - money:f2}lv more.");
}

