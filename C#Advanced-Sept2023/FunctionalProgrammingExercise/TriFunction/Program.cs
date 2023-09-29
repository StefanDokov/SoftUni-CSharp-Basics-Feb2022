


Func<string, int, bool> checkEqual = (name, sum) => name.Sum(ch => ch) >= sum;

Func<string[], int, Func<string, int, bool>, string> getFirstName =
    (names, sum, match) => names.FirstOrDefault(name => match(name, sum));


int sum = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string foundName = getFirstName(names, sum, checkEqual);

Console.WriteLine(foundName);