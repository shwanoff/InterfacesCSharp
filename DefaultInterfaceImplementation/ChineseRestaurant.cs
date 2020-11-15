using System;

namespace DefaultInterfaceImplementation
{
	public sealed class ChineseRestaurant : IRestaurant
	{
		public void GetMenu()
		{
			Console.WriteLine("ChineseRestaurant.GetMenu() - own implementation");
		}
	}
}
