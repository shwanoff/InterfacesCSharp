using System;

namespace ExplicitInterfaceMethodImplementation
{
	class Program
	{
		static void Main(string[] args)
		{
			var simpleType = new SimpleType();

			// Вызов неявной реализации.
			simpleType.Dispose();

			// Вызов явной реализации.
			IDisposable disposable = simpleType;
			disposable.Dispose();

			Console.ReadLine();
		}
	}
}
