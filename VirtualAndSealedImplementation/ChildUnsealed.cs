using System;

namespace VirtualAndSealedImplementation
{
	public class ChildUnsealed : BaseUnsealed
	{
		// Мы можем переопределить реализацию интерфейсного метода, т.к. он НЕ запечатан.
		public override void Dispose()
		{
			Console.WriteLine(nameof(ChildUnsealed));
		}
	}
}
