

Queue<string> clients = new Queue<string>();

string input = Console.ReadLine(); 

while (input != "End")
{
    
   if (input == "Paid")
    {
        
        while (clients.Any())
        {
            Console.WriteLine(clients.Dequeue());
        }
        
    } else
    {
        clients.Enqueue(input);
    }
   
   input = Console.ReadLine();
}


    Console.WriteLine($"{clients.Count} people remaining.");


