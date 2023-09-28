


string bookWeAreLookingFor = Console.ReadLine();

int booksChecked = 0;
string currentBook = Console.ReadLine();
while (currentBook != "No More Books")
{
    
    if (currentBook == bookWeAreLookingFor)
    {
        Console.WriteLine($"You checked {booksChecked} books and found it.");
        break;
    }

   
    booksChecked++;
    currentBook = Console.ReadLine();
}

if (currentBook == "No More Books")
{
    Console.WriteLine($"The book you search is not here!");
    Console.WriteLine($"You checked {booksChecked} books.");

}