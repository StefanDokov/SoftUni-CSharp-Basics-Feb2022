


int n = int.Parse(Console.ReadLine());

List<string> list = new List<string>();

for  (int i = 0; i < n; i++)
{

    string input = Console.ReadLine();

    list.Add(input);


}
int k = 1;

foreach (string input in list.OrderBy(p => p))
{
    

    Console.WriteLine($"{k}.{input}");

    k++;
}