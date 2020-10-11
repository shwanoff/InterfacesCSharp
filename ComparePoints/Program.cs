using System;
using System.Collections.Generic;

namespace ComparePoints
{
	class Program
	{
		static void Main()
		{
			var points = new List<Point>
			{
				new Point(3, 3),
				new Point(1, 2)
			};

			if(points[0].CompareTo(points[1]) > 0)
			{
				var tempPoint = points[0];
				points[0] = points[1];
				points[1] = tempPoint;
			}

			Console.WriteLine("Упорядоченные по возрастанию от начала координат точки:");
			foreach(var point in points)
			{
				Console.WriteLine(point);
			}

			Console.ReadLine();
		}
	}
}
