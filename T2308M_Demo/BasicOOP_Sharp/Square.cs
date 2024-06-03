using System;
namespace BasicOOP_Sharp
{
	public class Square:Sharp
	{
		public Square()
		{
		}

        public override double Areas(double width, double height)
        {
            return width * height;
        }

        public override double Perimeter(double width, double height)
        {
            const int factor = 4;
            return width * factor;
        }
    }
}

