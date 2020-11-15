using System;

namespace DefaultInterfaceImplementation
{
	public interface IRestaurant
	{
		// В интерфейсе объявлен метод и для него добавлена реализация по умолчанию.
		void GetMenu()
		{
			Console.WriteLine("IRestaurant.GetMenu() - default implementation");
		}
	}
}
