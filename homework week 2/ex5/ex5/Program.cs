using System;

namespace ex5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter N");
			int end = int.Parse (Console.ReadLine());

			for (int i = 0; i < end; i++) {
				if (i % 7 == 0 && i % 3 == 0) {
					Console.WriteLine (i);
				}
			}
		}
	}
}
