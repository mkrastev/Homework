using System;

namespace ex1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter size of random generated array:");
			int arraySize = int.Parse (Console.ReadLine());

			int[] masiv = new int[arraySize];
			Random rand = new Random ();

			for (int i = 0; i < arraySize; i++) {
				masiv [i] = rand.Next (1, 500);
				if (masiv [i] % 2 == 0) {
					
				
					Console.WriteLine (masiv [i]);
				}
				
			}
				

		}
	}
}
