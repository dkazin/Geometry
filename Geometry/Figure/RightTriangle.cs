namespace Geometry.Figure
{
	public class RightTriangle : IFigure
	{
		private double sideA;
		private double sideB;

		public RightTriangle(double sideA, double sideB)
		{
			this.sideA = sideA;
			this.sideB = sideB;
		}

		public double Area() => sideA * sideB / 2;
	}
}