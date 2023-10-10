using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBoxofString
{
    public class Box<T>
    {
        public Box(T input) 
        {
            Boxer = input;
        }
		private T boxer;

		public T Boxer
		{
			get { return boxer; }
			set { boxer = value; }
		}

        public override string ToString()
        {
            return $"{typeof(T)}: {Boxer}";
        }


    }
}
