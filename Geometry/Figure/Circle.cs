using System;

namespace Geometry.Figure
{
	public class Circle : Rectangle
	{
		public Circle(double diameter) : base (diameter, diameter)
		{
		}

		public double Diameter => width;

		public override double Area() => Math.Pow(Diameter / 2, 2) * Math.PI;
	}
}