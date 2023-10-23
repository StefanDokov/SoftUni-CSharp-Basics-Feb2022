


double gamesLost = double.Parse(Console.ReadLine());
double headsetCost = double.Parse(Console.ReadLine());
double mouseCost  = double.Parse(Console.ReadLine());
double keyboardCost  = double.Parse(Console.ReadLine());
double displayCost  = double.Parse(Console.ReadLine());

double headets = Math.Floor(gamesLost / 2);
double mouses = Math.Floor(gamesLost / 3);
double keyboards = Math.Floor(gamesLost / 6);
double displays = Math.Floor(keyboards / 2);

double expenses = headets * headsetCost + mouseCost * mouses + keyboardCost * keyboards + displayCost * displays;


Console.WriteLine($"Rage expenses: {expenses:f2} lv.");