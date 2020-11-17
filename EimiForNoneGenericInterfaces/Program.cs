using System;

namespace EimiForNoneGenericInterfaces
{
	class Program
	{
		static void Main(string[] args)
		{
			var value = new SomeValueType(0);
			var obj = new object();


			// В данном случае мы видим два нежелательных поведения - выполняется упаковка
			// и во время написания кода не выводится сообщение об несовместимости типов.
			// Ошибка будет выявлена только во время выполнения приложения.
			Console.WriteLine(value.CompareTo(value)); // Упаковка
			//Console.WriteLine(value.CompareTo(obj)); // Несоответствие типов видна только во время выполнения

			Console.ReadLine();

			var eimi = new EimiValueType(0);

			Console.WriteLine(eimi.CompareTo(eimi)); // Упаковка не выполняется
			//Console.WriteLine(eimi.CompareTo(obj)); // Ошибка на этапе написания кода: cannot convert from object to EimiValueType

			Console.ReadLine();

			IComparable comparable = eimi; // Первая упаковка

			Console.WriteLine(comparable.CompareTo(eimi)); // Вторая упаковка
			//Console.WriteLine(comparable.CompareTo(obj)); // Безопасность типов опять не соблюдается. Ошибка видна только во время выполнения

			Console.ReadLine();
		}
	}
}
