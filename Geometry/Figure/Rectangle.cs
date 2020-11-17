namespace Geometry.Figure
{
	public class Rectangle : IFigure
	{
		protected double width;
		protected double height;

		public Rectangle(double width, double height)
		{
			this.width = width;
			this.height = height;
		}

		public double Width => width;

		public double Height => height;

		public virtual double Area() => width * height;
	}
}