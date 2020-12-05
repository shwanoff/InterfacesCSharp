using System;

namespace BaseClassVsInterface
{
	public class Circle : IFigure
	{
		public double Radius { get; }

		public Circle(double radius)
		{
			if (radius < 0) throw new ArgumentException("Радиус круга должен быть больше 0", nameof(radius));

			Radius = radius;
		}

		public double GetArea()
		{
			return Math.PI * Radius * Radius;
		}
	}
}
