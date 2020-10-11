using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAndSealedImplementation
{
	class Program
	{
		static void Main(string[] args)
		{
			// Мы успешно можем вызвать все три собственные реализации

			new ChildUnsealed().Dispose();
			new ChildSealed().Dispose();
			new ChildSealedOwnImplementation().Dispose();

			Console.ReadLine();

			// Но так как ChildSealed на самом деле не переопределяет интерфейс, а замещает его
			// то при работе с экземпляром через интерфейс будет вызвана базовая реализация, а не собственная.

			var collection = new List<IDisposable>
			{
				new ChildUnsealed(),
				new ChildSealedOwnImplementation(),
				new ChildSealed() // будет вызвана базовая реализация
			};

			foreach(var child in collection)
			{
				child.Dispose();
			}

			Console.ReadLine();
		}
	}
}
