using System;

namespace EimiForNoneGenericInterfaces
{
	public struct EimiValueType : IComparable
	{
		public int Value { get; }

		public EimiValueType(int value)
		{
			Value = value;
		}

		// Собственный метод класса, не связанный с интерфейсом IComparable
		// и в качестве аргумента принимающий EimiValueType, а не object
		public int CompareTo(EimiValueType other)
		{
			return Math.Sign(Value - other.Value);
		}

		// Явная реализация интерфейса IComparable, которая вызывает внутренний метод
		int IComparable.CompareTo(object other)
		{
			return CompareTo((EimiValueType)other);
		}
	}
}
