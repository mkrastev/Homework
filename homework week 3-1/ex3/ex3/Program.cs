using System;

namespace ex3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter size of random generated array:");
			int arraySize = int.Parse (Console.ReadLine());

			int[] masiv = new int[arraySize];

			for (int i = 0; i < arraySize; i++) {
				masiv [i] = i * 10;
					Console.WriteLine (masiv [i]);
				}
		}
	}
}
