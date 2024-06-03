using System;
namespace BasicOOP_Sharp
{
    public class Rectangle : Sharp
    {
        public Rectangle()
        {
        }

        public override double Areas(double width, double height)
        {
            return width * height;
        }

        public override double Perimeter(double width, double height)
        {
            const int factor = 2;
            return (width + height) * factor;
        }

    }
}

