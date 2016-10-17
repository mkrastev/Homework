using System;

namespace ex4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter n:");
			int end = int.Parse (Console.ReadLine());

			for (int i = 0; i < end + 1; i++) {
				Console.WriteLine (i);
			}
		}
	}
}
