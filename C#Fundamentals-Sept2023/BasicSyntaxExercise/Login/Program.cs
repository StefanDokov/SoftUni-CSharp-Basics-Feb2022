


string user = Console.ReadLine();

string pass;
int counter = 0;
while ((pass = Console.ReadLine()) != null)
{

    char[] charArray = pass.ToCharArray();
    Array.Reverse(charArray);
    string check = new string(charArray);

    if (check == user)
    {
        Console.WriteLine($"User {user} logged in.");
        break;
    }
    else
    {
        counter++;
        if (counter < 4) 
        { 
        Console.WriteLine("Incorrect password. Try again.");

        }
    }

    if (counter == 4)
    {
        Console.WriteLine($"User {user} blocked!");
        break;
    }

}