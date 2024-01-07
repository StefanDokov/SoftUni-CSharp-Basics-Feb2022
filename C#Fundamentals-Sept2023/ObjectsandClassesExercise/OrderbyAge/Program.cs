

Dictionary<string, Person> people = new Dictionary<string, Person>();

while (true)
{
    string input = Console.ReadLine();

    if (input == "End")
    {
        break;
    }

    string[] data = input.Split();
    string name = data[0];
    string id = data[1];
    int age = int.Parse(data[2]);

    if (!people.ContainsKey(id))
    {
        people[id] = new Person { Name = name, Age = age, ID = id};
    }
    else
    {
        people[id].Name = name;
        people[id].Age = age;
    }
}

foreach (var person in people.Values.OrderBy(p => p.Age))
{
    Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
}
    

    class Person
{
    public string Name { get; set; }
    public string ID { get; set; } 
    public int Age { get; set; }
}