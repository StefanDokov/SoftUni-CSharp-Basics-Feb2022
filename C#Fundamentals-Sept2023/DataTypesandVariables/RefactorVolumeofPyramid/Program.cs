


double dul, sh, h, V = 0;
Console.Write("Length: ");
dul = double.Parse(Console.ReadLine());
Console.Write("Width: ");
sh = double.Parse(Console.ReadLine());
Console.Write("Height: ");
h = double.Parse(Console.ReadLine());
V = ((dul * sh) * h) / 3;
Console.WriteLine($"Pyramid Volume: {V:f2}");