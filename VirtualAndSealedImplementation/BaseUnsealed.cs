using System;

namespace VirtualAndSealedImplementation
{
	public class BaseUnsealed : IDisposable
	{
		// Базовый класс, явно указывающий, что метод виртуальный.
		// Из-за этого метод будет НЕ запечатанный и виртуальный.
		public virtual void Dispose()
		{
			Console.WriteLine(nameof(BaseUnsealed));
		}
	}
}
