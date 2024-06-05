using System;
namespace OOP_Practice_1
{
	public abstract class Geometry
	{
		public double Width { get; set; }
		public double Height { get; set; }
		public double radius { get; set; }
		public abstract double Area();
		public abstract double Perimeter();
	}
}

