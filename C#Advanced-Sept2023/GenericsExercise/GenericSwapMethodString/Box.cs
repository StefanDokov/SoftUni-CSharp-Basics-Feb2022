using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSwapMethodString
{
    public class Box<T>
    {
        List<T> list;
        public Box() 
        {
            list = new List<T>();   
        }
		
        public void Add(T input)
        {
            list.Add(input);
        }

        public void Swap(int a, int b)
        {
            T temp = list[a];
            list[a] = list[b];
            list[b] = temp;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (T input in list)
            {
                sb.AppendLine($"{typeof(T)}: {input}");
            }
            return sb.ToString().TrimEnd();
        }


    }
}
