



int n = int.Parse(Console.ReadLine());

int sum = 0;
int starter = 1;

for  (int i = 0; i < n; i++)
{
    Console.WriteLine(starter);
    sum += starter;
    starter += 2;
}

Console.WriteLine($"Sum: {sum}");