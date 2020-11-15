using System;

namespace ExplicitInterfaceMethodImplementation
{
	public class SimpleType : IDisposable
	{
		// Неявная реализация метода.
		public void Dispose()
		{
			Console.WriteLine("SimpleType Dispose()");
		}

		// Явная реализация метода.
		void IDisposable.Dispose()
		{
			Console.WriteLine("IDisposable Dispose()");
		}
	}
}
