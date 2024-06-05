using System;
namespace OOP_Practice_1
{
    public class Circle : Geometry
    {
        const double PI = 3.14;
        public override double Area()
        {
            return PI * Math.Pow(radius, 2);
        }

        public override double Perimeter()
        {
            return 2 * PI * radius;
        }
    }
}

