


using GenericBoxofString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

List<Box<string>> list = new List<Box<string>>();

int n = int.Parse(Console.ReadLine());

for  (int i = 0; i < n; i++)
{
    Box<string> boxz = new(Console.ReadLine());
    list.Add(boxz);
}

foreach (Box<string> box in list)
{
    Console.WriteLine(box.ToString());
}