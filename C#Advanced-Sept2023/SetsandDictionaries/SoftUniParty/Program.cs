




string comand = Console.ReadLine();

bool isOpen = false;

HashSet<string> vips = new HashSet<string>();
HashSet<string> guests = new HashSet<string>();

while (comand != "END")
{

    if (comand == "PARTY")
    {
        isOpen = true;
    }

    if (!isOpen && char.IsDigit(comand[0]))
    {
        vips.Add(comand);
    }
    else if (!isOpen && !char.IsDigit(comand[0]))
    {
        guests.Add(comand);
    }

    if (isOpen && char.IsDigit(comand[0])) 
    {
        vips.Remove(comand);


    } 
    else if (isOpen && !char.IsDigit(comand[0]))
    {
        guests.Remove(comand);
    }


    comand = Console.ReadLine();
}

Console.WriteLine(vips.Count + guests.Count);
foreach (string vip in vips)
{
    Console.WriteLine(vip);
}
foreach (string guest in guests)
{
    Console.WriteLine(guest);
}