


using GenericBoxofString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

List<Box<int>> list = new List<Box<int>>();

int n = int.Parse(Console.ReadLine());

for  (int i = 0; i < n; i++)
{
    Box<int> boxz = new(int.Parse(Console.ReadLine()));
    list.Add(boxz);
}

foreach (Box<int> box in list)
{
    Console.WriteLine(box.ToString());
}