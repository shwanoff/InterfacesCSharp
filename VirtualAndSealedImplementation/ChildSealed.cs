using System;

namespace VirtualAndSealedImplementation
{
	public class ChildSealed : BaseSealed
	{
		// Мы НЕ можем переопределить интерфейсный метод, т.к. он является запечатанным

		//public override void Dispose() // ERROR CS0506!
		//{
		//	Console.WriteLine(nameof(ChildSealed));
		//}

		// Мы можем заместить реализацию базового метода с помощью ключевого слова new
		// но тогда метод Dispose не будет относиться к интерфейсу IDispoible,
		// а будет работать как самостоятельный метод
		new public void Dispose()
		{
			Console.WriteLine(nameof(ChildSealed));
		}
	}
}
