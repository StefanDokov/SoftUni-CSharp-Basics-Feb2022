





using Microsoft.VisualBasic;

string input = Console.ReadLine();

Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();
List<string> keyove = new List<string>();
while (input != "Revision")
{
    string[] info = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string shopName = info[0];
    string product = info[1];
    double price = double.Parse(info[2]);

    if (!shops.ContainsKey(shopName))
    {
        shops[shopName] = new Dictionary<string, double>();
        keyove.Add(shopName);
    }

    shops[shopName].Add(product, price);



    input = Console.ReadLine();
}



foreach (string shop in keyove.OrderBy(x => x).ToList())
{
    Console.WriteLine(shop + "->");
    foreach (var product in shops[shop])
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}