using System;

namespace GenericInterfaces
{
	// Реализуем интерфейс IComparable<> с двумя разными фактическими типами
	public sealed class Number : IComparable<int>, IComparable<string>
	{
		public int Value { get; }

		public Number(int value)
		{
			Value = value;
		}

		// Реализация интерфейса с int.
		public int CompareTo(int other)
		{
			return Value.CompareTo(other);
		}

		// Реализация интефейса со string.
		public int CompareTo(string other)
		{
			return Value.CompareTo(int.Parse(other));
		}
	}
}
