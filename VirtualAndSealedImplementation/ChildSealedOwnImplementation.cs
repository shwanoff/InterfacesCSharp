using System;

namespace VirtualAndSealedImplementation
{
	public class ChildSealedOwnImplementation : BaseSealed, IDisposable
	{
		// В данном случае мы можем переопределить метод Dispose у потомка
		// не смотря на то, что он является запечатанным в родительском классе
		// мы просто реализуем интерфейс в потомке по своему, оставляя зависимость от интерфейса.

		new public void Dispose()
		{
			Console.WriteLine(nameof(ChildSealedOwnImplementation));

			// при желании также можно обратиться и к базовой реализации используя эту команду:
			// base.Dispose();
			// на консоль будет выведено BaseSealed
		}
	}
}
