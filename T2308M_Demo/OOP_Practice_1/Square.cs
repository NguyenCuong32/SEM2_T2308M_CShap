using System;
namespace OOP_Practice_1
{
    public class Square : Geometry
    {
        public override double Area()
        {
            double edge = Width = Height;
            return Math.Pow(edge, 2);
        }

        public override double Perimeter()
        {
            double edge = Width = Height;
            const int factor = 4;
            return factor * edge;
        }
    }
}

