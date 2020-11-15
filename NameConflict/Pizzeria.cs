using System;

namespace NameConflict
{
	public sealed class Pizzeria : IWindow, IRestaurant
	{
		// Явная реализация интерфейса IWindow
		void IWindow.GetMenu()
		{
			Console.WriteLine("IWindow.GetMenu()");
		}

		// Явная реализация интерфейса IRestaurant
		void IRestaurant.GetMenu()
		{
			Console.WriteLine("IRestaurant.GetMenu()");
		}

		// Собственная реализация метода GetMenu. Никак не связана ни с одним из интерфейсов.
		public void GetMenu()
		{
			Console.WriteLine("Pizzeria.GetMenu()");
		}
	}
}
