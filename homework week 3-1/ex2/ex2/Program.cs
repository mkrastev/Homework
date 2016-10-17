using System;

namespace ex2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter size of random generated array:");
			int arraySize = int.Parse (Console.ReadLine());
			int a = 0;
			int b = 1;
			int c = 0;

			int[] masiv = new int[arraySize];
			masiv [0] = 1;

			for (int i = 0; i < arraySize; i++) {
				masiv[i] = c = a + b;
				Console.WriteLine (c);
				a = b;
				b = c;
			}


		}
	}
}
