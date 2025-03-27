using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal abstract class Shape
    {
        public bool isHoley;
        private string color;

        public string Color { get => color; set => color = value; }

        protected Shape(bool isHoley, string color)
        {
            this.isHoley = isHoley;
            this.color = color;
        }

        protected Shape(string color)
        {
            this.color = color;
            this.isHoley = false;
        }

        public void MakeHoley()
        {
            this.isHoley = true;
        }

        public void MakeHoleyIf()
        {
            if (!isHoley)
            {
                if (Area() > Perimeter())
                {
                    isHoley = true;
                }
            }
        }

        public abstract double Perimeter();

        public abstract double Area();

        public override string? ToString()
        {
            return $"Szín: {color} lyukas-e: {isHoley} kerület: {Perimeter()} terület: {Area()}";
        }
    }
}
