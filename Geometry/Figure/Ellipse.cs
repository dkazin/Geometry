using System;

namespace Geometry.Figure
{
	public class Ellipse : Rectangle
	{
		public Ellipse(double width, double height) : base(width, height)
		{
		}

		public override double Area() => width * height * Math.PI;
	}
}