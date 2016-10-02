using System;

namespace ex5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter something:");
			string something = Console.ReadLine ();
			Console.WriteLine ("Enter something else:");
			string somethingElse = Console.ReadLine();
			Console.WriteLine (something + "_" + somethingElse);

		}
	}
}
