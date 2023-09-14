


int n = int.Parse(Console.ReadLine());

int max = 0;
int min = 0;
for (int i = 1; i <= n; i++)
{
    int numero = int.Parse(Console.ReadLine());
    if (i == 1)
    {
        max = numero;
        min = numero;
    }
    if (numero > max)
    {
        max = numero;
    }
    if (numero < min) 
    { 
        min = numero; 
    }


}

Console.WriteLine($"Max number: {max}");
Console.WriteLine($"Min number: {min}");
