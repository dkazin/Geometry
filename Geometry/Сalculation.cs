using Geometry.Figure;
using System.Collections.Generic;

namespace Geometry
{
	public class Сalculation
	{ 
		public static double Area(IEnumerable<IFigure> figures)
		{
			double result = 0;

			foreach(var figure in figures)
			{
				result += figure.Area();
			}

			return result;
		}
	}
}