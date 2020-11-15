using System;

namespace DefaultInterfaceImplementation
{
	class Program
	{
		static void Main(string[] args)
		{
			var pizzeria = new Pizzeria();
			//pizzeria.GetMenu(); // Метод GetMenu() не доступен у экземпляра класса, т.к. он не реализует в себе напрямую этот интерфейс
			((IRestaurant)pizzeria).GetMenu(); // Но обратиться к реализации по умолчанию можно приведя экземпляр к интерейсу

			var burgerBar = new BugrerBar();
			//burgerBar.GetMenu(); // Метод GetMenu() не доступен у экземпляра класса, т.к. он явно реализует этот интерфейс
			((IRestaurant)burgerBar).GetMenu();

			var chineseRestaurant = new ChineseRestaurant();
			chineseRestaurant.GetMenu(); // Мы можем вызвать метод GetMenu() и получим собственную реализацию метода
			((IRestaurant)chineseRestaurant).GetMenu(); // и даже при явном приведении к интерфейсному типу будет вызываться собственная реализация метода в классе

			Console.ReadLine();
		}
	}
}
