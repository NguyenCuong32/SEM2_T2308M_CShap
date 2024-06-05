using System;
namespace OOP_Practice_1
{
    public class Rectangle : Geometry
    {
        public override double Area()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return 2 * (Width + Height);
        }
    }
}

