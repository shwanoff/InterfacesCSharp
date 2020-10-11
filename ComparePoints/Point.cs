using System;

namespace ComparePoints
{
	public class Point : IComparable<Point>
	{
		public int X { get; }
		public int Y { get; }

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		public int CompareTo(Point other)
		{
			return Math.Sign(Math.Sqrt(X * X + Y * Y) - Math.Sqrt(other.X * other.X + other.Y * other.Y));
		}

		public override string ToString()
		{
			return $"[{X}; {Y}]";
		}
	}
}
