using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingInterfaceMethod
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = "code blog";
			DisplayAllMethods(s);

			Console.ReadLine();

			ICloneable cloneable = s;
			DisplayAllMethods(cloneable);

			Console.ReadLine();

			IComparable comparable = s;
			DisplayAllMethods(comparable);

			Console.ReadLine();

			IEnumerable enumerable = (IEnumerable)comparable;
			DisplayAllMethods(enumerable);

			Console.ReadLine();
		}

		private static void DisplayAllMethods<T>(T variable)
		{
			// GetMethods() возвращает имена доступных методов типа.
			// Но так как перегрузка метода считается за отдельный метод,
			// то на выходе получается повторение некоторых методов несколько раз.
			// И с помощью Select и Distinct я просто избавляюсь от повторов перегруженных методов.
			var uniqueMethodsName = typeof(T).GetMethods()
				.Select(n => n.Name).Distinct();

			Console.WriteLine($"Переменная типа {typeof(T)} (фактический тип {variable.GetType()}) " + 
				"содержит в себе следующие методы");
			foreach(var method in uniqueMethodsName)
			{
				Console.WriteLine(method);
			}
			Console.WriteLine();
		}
	}
}
