using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }


        public override string Draw()
        {
            return base.Draw();
        }

        public override double CalculatePerimeter()
        {
            return radius * 2 * Math.PI;

        }

        public override double CalculateArea()
        {
            return radius * radius * Math.PI;

        }
    }
}
