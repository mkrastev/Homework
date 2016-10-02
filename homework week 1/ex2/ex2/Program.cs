using System;

namespace ex2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter string:");
			string input = Console.ReadLine();
			bool test = (input == "Hello");
			Console.WriteLine (test);

		}
	}
}
