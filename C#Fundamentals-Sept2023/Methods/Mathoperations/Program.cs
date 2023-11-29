

int first = int.Parse(Console.ReadLine());

string operand = Console.ReadLine();

int second = int.Parse(Console.ReadLine()); 

Console.WriteLine(Calc(first, operand, second));


static double Calc(int a, string @operator, int b)
{

    double result = 0;

    switch (@operator)
    {
        case "*":
            result = a * b;
            break;

    case "/":
            result = a / b;
            break;
            case "+":
            result = a + b;
            break;
            case "-":
            result = a - b;
            break;




    }
    return result;

}