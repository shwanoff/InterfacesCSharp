using System;
using System.Collections.Generic;

namespace BaseClassVsInterface
{
	class Program
	{
		static void Main(string[] args)
		{
			Interfaces();
			BaseClasses();

			Console.ReadLine();
		}

		private static void BaseClasses()
		{
			// В данном случае использование базового класса обосновано потому что 
			// логика поведения для обоих наследников идентична, и нет никакой необходимости дублировать одинаковый код
			// к тому же, если мы захотим поменять логику поведения, нам будет достаточно сделать это в одном месте - в базовом классе

			var animals = new List<AnimalBase>
			{
				new Cat(),
				new Dog()
			};

			foreach (var animal in animals)
			{
				Console.WriteLine($"{animal.GetType().Name} говорит {animal.Say()}");
			}
		}

		private static void Interfaces()
		{
			// В данном случае использование интерфейсов обосновано потому что
			// нас интересует работа с различными типами фигур по средствам вызова одинакового метода
			// но реализация этого метода для каждого конкретного типа совершенно разная

			var figures = new List<IFigure>
			{
				new Circle(5),
				new Square(5)
			};

			foreach (var figure in figures)
			{
				Console.WriteLine($"Для фигуры {figure.GetType().Name} площадь равна {figure.GetArea()}");
			}
		}
	}
}
