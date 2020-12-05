using System;

namespace BaseClassVsInterface
{
	public class Square : IFigure
	{
		public double Lenght { get; }

		public Square(double lenght)
		{
			if (lenght < 0) throw new ArgumentException("Длина стороны квадрата должна быть больше 0", nameof(lenght));

			Lenght = lenght;
		}

		public double GetArea()
		{
			return Lenght * Lenght;
		}
	}
}
