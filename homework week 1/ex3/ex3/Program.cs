using System;

namespace ex3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter a:");
			double a = double.Parse (Console.ReadLine());
			Console.WriteLine ("Enter h:");
			double h = double.Parse (Console.ReadLine ());
			double surface = (a * h) / 2;
			Console.WriteLine ("S = (a * h) / 2 = " + surface);
		}
	}
}
