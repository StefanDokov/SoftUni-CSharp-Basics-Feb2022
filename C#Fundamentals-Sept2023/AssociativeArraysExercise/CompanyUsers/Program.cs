


Dictionary<string, List<string>> companyData = new Dictionary<string, List<string>>();

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputElements = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

    string iCompany = inputElements[0];
    string iEmployeeID = inputElements[1];

    if (!companyData.ContainsKey(iCompany))
    {
        companyData.Add(iCompany, new List<string>());
    }

    if (!companyData[iCompany].Contains(iEmployeeID))
    {
        companyData[iCompany].Add(iEmployeeID);
    }

    input = Console.ReadLine();
}

foreach (var company in companyData)
{
    Console.WriteLine($"{company.Key}");
    //foreach (var id in company.Value.OrderBy(id => id))
    foreach (var id in company.Value)
    {
        Console.WriteLine($"-- {id}");
    }
}