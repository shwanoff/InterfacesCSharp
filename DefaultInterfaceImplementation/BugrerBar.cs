using System;

namespace DefaultInterfaceImplementation
{
	public sealed class BugrerBar : IRestaurant
	{
		void IRestaurant.GetMenu()
		{
			Console.WriteLine("BugrerBar.GetMenu() - explicit implementation");
		}
	}
}
