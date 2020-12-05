using System;

namespace DangerousOfEimi
{
	class Program
	{
		static void Main(string[] args)
		{
			Convertible();

			Console.ReadLine();

			var derived = new Derived();
			derived.CompareTo(new object());

			Console.ReadLine();
		}

		private static void ConvertibleInt()
		{
			//var i = 5;
			// var temp = i.ToSingle(null); // ToSingle() - не существует
		}

		private static void Convertible()
		{
			// Не смотря на то, что в документации указано, что int реализует интерфейс IConverible
			// мы не можем работать и ним на прямую из-за явной реализации данного интерфейса в типе int.
			// При этом подобное поведение является далеко не очевидным.
			// И даже если мы выполняем приведение к интерфейсу, мы сталкиваемся с другой проблемой
			// Значимый тип int будет упаковываться, а значит будет снижаться быстродействие системы.

			int i = 5;
			var temp = ((IConvertible)i).ToSingle(null); // ToSingle() работает, но будет выполняться упаковка
			Console.WriteLine(temp.GetType());
		}
	}
}
