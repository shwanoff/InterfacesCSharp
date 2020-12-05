using System;

namespace DangerousOfEimi
{
	public class Derived : Base/*, IComparable*/
	{
		public override int CompareTo(object o)
		{
			Console.WriteLine("Derived CompareTo()");

			// К сожалению, мы не можем обращаться к базовому типу для вызова его метода CompareTo(),
			// т.к. интерфейс реализован явно и по сути совсем не относится к типу Base.
			// base.CompareTo(o); // Базовый тип Base не содержит в себе метод CompareTo()

			// Для решения этой проблемы можно попробовать привести тип к интерфейсу.
			// но это приведет к бесконечной рекурсии
			//IComparable comparable = this;
			//comparable.CompareTo(o);

			return base.CompareTo(o);
		}
	}
}
