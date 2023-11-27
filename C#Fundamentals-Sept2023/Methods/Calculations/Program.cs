

string comand = Console.ReadLine();

int firstNum = int.Parse(Console.ReadLine()); 
int secondNum = int.Parse(Console.ReadLine()); 

int result = calco(comand, firstNum, secondNum);    

Console.WriteLine(result);

static int calco(string doer, int n, int x)
{
    int sum = 0;
    switch (doer)
    {
        case "add":
            sum = n + x; 
            break;
        case "multiply":
            sum = n * x;
            break;
        case "subtract":
            sum = n - x;
            break;
        case "divide":
            if (n == 0 || x == 0)
            {
                break;
            }
            sum = n / x;
            break;
    }


   return sum;

}