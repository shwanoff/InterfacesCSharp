using System;

namespace DangerousOfEimi
{
	public class Base : IComparable
	{
		int IComparable.CompareTo(object obj)
		{
			Console.WriteLine("Base CompareTo()");
			return CompareTo(obj);
		}

		public virtual int CompareTo(object o)
		{
			Console.WriteLine("Base virtual CompareTo()");
			return 0;
		}
	}
}
