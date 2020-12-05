using System;

namespace BaseClassVsInterface
{
	public abstract class BaseClass : Interface
	{
		public void DoWork()
		{
			Console.WriteLine("Do work");
		}
	}
}
