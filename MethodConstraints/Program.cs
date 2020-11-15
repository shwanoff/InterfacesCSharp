using System;

namespace MethodConstraints
{
	class Program
	{
		static void Main(string[] args)
		{
			var number = 5;
			var guid = new Guid();

			// Вызов метода с целым числом будет успешной,
			// т.к. int реализует оба интерфейса IComparable и IConvertible
			Method(number);

			// Ошибка на этапе написания кода,
			// т.к. Guid реализует только один интерфейс - IComparable, но не реализует IConvertible
			//Method(guid); // CS0315: The type Guid cannot be used as type parameter T in generic type or method Method<T>(T). There is no boxing conversion from Guid to IConvertable

			Console.ReadLine();
		}

		// Обобщенный метод, который требует чтобы тип переменной item обязательно реализовывал интерфейсы IComparable и IConvertible.
		// При работе с этим методом упаковка выполняться не будет.
		private static void Method<T>(T item) where T : IComparable, IConvertible
		{
			Console.WriteLine("Generic Method");
		}

		// Необобщенный метод, который в качестве аргумента принимает интерфейс.
		// В данном случае у нас меньше возможностей, поскольку мы можем наложить ограничение на использование типов реализующих только один интерфейс
		// Кроме того, при работе со значимыми типами будет выполняться упаковка, т.к. IComparable - ссылочный тип
		private static void Method(IComparable item)
		{
			Console.WriteLine("Method");
		}
	}
}
