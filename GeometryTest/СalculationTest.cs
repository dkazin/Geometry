using Geometry;
using Geometry.Figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryTest
{
	[TestClass]
	public class ÑalculationTest
	{
		[TestMethod]
		public void SumArrea()
		{
			var figures = new IFigure[]
			{
				new Rectangle(40, 25),
				new Ellipse(53, 89),
				new RightTriangle(12, 17),
				new Circle(11.03)
			};

			var sumArea = Ñalculation.Area(figures);

			Assert.AreEqual(1000 + 14818.892546983054 + 102 + 95.5522474172806, sumArea);
		}
	}
}