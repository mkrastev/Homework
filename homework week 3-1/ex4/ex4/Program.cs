using System;

namespace ex4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter sze of array:");
			int size = int.Parse (Console.ReadLine());

			int[] masiv = new int[size];

			for (int i = 0; i < size; i++) {
				masiv [i] = i;
			}

			Console.WriteLine ("Enter the number you are looking for:");
			int wanted = int.Parse (Console.ReadLine());

			foreach (int i in masiv) {
				if (masiv[i] == wanted) {
					Console.WriteLine ("Your number is here on {0} postition!", i - 1);
				}
			}
					
				

		}
	}
}
