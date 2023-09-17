


string name = Console.ReadLine();
string pass = Console.ReadLine();

string tryPass = Console.ReadLine();

while (tryPass != pass)
{
    
    tryPass = Console.ReadLine();
}

if (tryPass == pass)
{
    Console.WriteLine($"Welcome {name}!");
}