using System;

namespace Examples
{
	public class Greeter
	{
		private readonly string name;

		public Greeter(string name)
		{
			this.name = name;
		}

		public void SayHello()
		{
			Console.WriteLine("Hello {0}!", name);
		}
	}
}