


int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine());

int sum = summerer(first, second);

sum = substractor(sum, third);

Console.WriteLine(sum);

static int summerer(int one, int two)
{
    return one + two;
}

static int substractor(int one, int two)
{
    return one - two;
}



