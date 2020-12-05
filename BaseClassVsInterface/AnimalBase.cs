using System;

namespace BaseClassVsInterface
{
	public abstract class AnimalBase
	{
		protected string _speech = "";

		public string Say()
		{
			return _speech;
		}
	}
}
