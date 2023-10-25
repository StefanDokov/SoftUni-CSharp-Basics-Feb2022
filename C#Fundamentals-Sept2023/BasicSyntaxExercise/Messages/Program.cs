


int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{

char[] arrer = Console.ReadLine().ToCharArray();

char last = arrer[0];
int cont = arrer.Length - 1;;
switch (last)
{
    case '0':
        Console.Write(" ");
        break;
    case '2':
        char[] mid1 = { 'a', 'b', 'c'};
        Console.Write(mid1[cont]);
        break;
    case '3':
        char[] mid2 = { 'd', 'e', 'f' };
        Console.Write(mid2[cont]);
        break;
    case '4':
        char[] mid3 = { 'g', 'h', 'i' };
        Console.Write(mid3[cont]);
        break;
    case '5':
            char[] mid4 = { 'j', 'k', 'l' };
            Console.Write(mid4[cont]);
            break;
    case '6':
            char[] mid5 = { 'm', 'n', 'o' };
            Console.Write(mid5[cont]); ;
        break;
    case '7':
            char[] mid6 = { 'p', 'q', 'r', 's' };
            Console.Write(mid6[cont]);
            break;
    case '8':
            char[] mid7 = { 't', 'u', 'v' };
            Console.Write(mid7[cont]);
            break;
    case '9':
            char[] mid8 = { 'w', 'x', 'y', 'z' };
            Console.Write(mid8[cont]);
            break;
}


}
Console.WriteLine();