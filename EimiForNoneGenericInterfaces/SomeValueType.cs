using System;

namespace EimiForNoneGenericInterfaces
{
	public struct SomeValueType : IComparable
	{
		public int Value { get; }

		public SomeValueType(int value)
		{
			Value = value;
		}

		public int CompareTo(object other)
		{
			return Math.Sign(Value - ((SomeValueType)other).Value);
		}
	}
}
