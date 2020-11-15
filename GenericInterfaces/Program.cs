using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			Boxing();
			WithoutBoxing();

			Console.ReadLine();

			var number = new Number(42);

			// Сравниваем напрямую тип Number с помощью соответствующих перегруженных методов обобщенного интерфейса
			Console.WriteLine(number.CompareTo(42));
			Console.WriteLine(number.CompareTo("42"));

			// Сравниваем с приведением к конкретному типу обобщенного интерфейса
			IComparable<int> comparableInt = number;
			comparableInt.CompareTo(42);

			IComparable<string> comparableString = number;
			comparableString.CompareTo("42");

			Console.ReadLine();
		}

		private static void Boxing()
		{
			var x = 1;
			var y = 2;

			IComparable comparable = x;

			// Выполняется упаковка
			// т.к. IComparable.CompareTo(object obj) в качестве аргумента ожидает переменную типа object - ссылочный тип
			// а мы передаем int - значимый тип. Это возможно, но для работы необходимо упаковать переменную в куче.
			comparable.CompareTo(y);

			// Ошибка во время выполнения
			// т.к. в качестве аргумента ожитадется object, то мы совершенно спокойно можем поместить любой тип, например строку,
			// но во время выполнения CLR будет выполнять сравнение фактических типов int и string, что не возможно без приведения.
			// Однако, во время написания кода данная ошибка выявлена не будет.
			//comparable.CompareTo("2");

			Console.WriteLine("Boxing");
		}

		private static void WithoutBoxing()
		{
			var x = 1;
			var y = 2;

			IComparable<int> comparable = x;

			// Упаковка не выполняется
			// т.к. IComparable<int>.CompareTo(int other) в качестве аргумента ожидается int.
			comparable.CompareTo(y);

			// Выявление ошибки во время написания кода
			// Статический анализатор Visual Studio в силах заметить не соответствие, что
			// в качестве аргумента ожидается int, а мы передаем string.
			//comparable.CompareTo("2"); // CS1503: Argument 1: cannot convert from string to int.

			Console.WriteLine("Without boxing");
		}
	}
}
