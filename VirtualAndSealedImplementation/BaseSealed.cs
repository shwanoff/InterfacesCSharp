using System;

namespace VirtualAndSealedImplementation
{
	public class BaseSealed : IDisposable
	{
		// Базовый класс БЕЗ явного указания, что метод реализующий интерфейс виртуальный.
		// Из-за этого, метод всё равно будет виртуальным, но еще и запечатанным.
		public void Dispose()
		{
			Console.WriteLine(nameof(BaseSealed));
		}
	}
}
