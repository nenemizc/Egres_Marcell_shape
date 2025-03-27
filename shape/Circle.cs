using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Circle : Shape
    {
        double r;


        public Circle(bool isHoley, string color, double r) : base(isHoley, color)
        {
            this.r = r;
        }

        public double R { get => r; set => r = value; }

        public override double Area()
        {
            return Math.Pow(r, 2) * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * r * Math.PI;
        }

        public override string? ToString()
        {
            return base.ToString() + " Kör";
        }
    }
}
