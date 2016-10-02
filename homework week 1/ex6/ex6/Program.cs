using System;

namespace ex6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter decimal (use '.' as decimal point):");
			decimal x = decimal.Parse(Console.ReadLine ());
			Console.WriteLine ("Enter int:");
			int y = int.Parse (Console.ReadLine ());
			Console.WriteLine (Math.Truncate(x) / y);

		}
	}
}
