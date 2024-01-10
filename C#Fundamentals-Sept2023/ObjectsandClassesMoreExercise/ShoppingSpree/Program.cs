



Dictionary<string, Person> people = new Dictionary<string, Person>();
Dictionary<string, Product> products = new Dictionary<string, Product>();

string[] inputPeople = Console.ReadLine().Split(';');
foreach (var personData in inputPeople)
{
    string[] personInfo = personData.Split('=');
    string personName = personInfo[0];
    decimal personMoney = decimal.Parse(personInfo[1]);
    people.Add(personName, new Person(personName, personMoney));
}

string[] inputProducts = Console.ReadLine().Split(';');
foreach (var productData in inputProducts)
{
    string[] productInfo = productData.Split('=');
    string productName = productInfo[0];
    decimal productCost = decimal.Parse(productInfo[1]);
    products.Add(productName, new Product(productName, productCost));
}

string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] purchaseInfo = command.Split();
    string personName = purchaseInfo[0];
    string productName = purchaseInfo[1];

    if (people.ContainsKey(personName) && products.ContainsKey(productName))
    {
        people[personName].BuyProduct(productName, products[productName].Cost);
    }
}

// Output results
foreach (var person in people.Values)
{
    if (person.Bag.Count > 0)
    {
        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag)}");
    }
    else
    {
        Console.WriteLine($"{person.Name} - Nothing bought");
    }
}

class Person
{
    public string Name { get; set; }
    public decimal Money { get; set; }
    public List<string> Bag { get; set; }

    public Person(string name, decimal money)
    {
        Name = name;
        Money = money;
        Bag = new List<string>();
    }

    public void BuyProduct(string productName, decimal productCost)
    {
        if (Money >= productCost)
        {
            Money -= productCost;
            Bag.Add(productName);
            Console.WriteLine($"{Name} bought {productName}");
        }
        else
        {
            Console.WriteLine($"{Name} can't afford {productName}");
        }
    }
}

class Product
{
    public string Name { get; set; }
    public decimal Cost { get; set; }

    public Product(string name, decimal cost)
    {
        Name = name;
        Cost = cost;
    }
}