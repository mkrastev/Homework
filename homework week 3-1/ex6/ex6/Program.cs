using System;

namespace ex6
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter array size:");
			int size = int.Parse (Console.ReadLine());
			Random rand = new Random ();

			int[] spimise = new int[size];

			for (int i = 0; i < size; i++) {
				spimise [i] = rand.Next (1, 1000);
				Console.WriteLine (spimise[i]);
			}

			Console.WriteLine ();
			Console.WriteLine ("The negative array is:");

			for (int i = 0; i < size; i++) {
				spimise [i] = - spimise [i];
				Console.WriteLine (spimise[i]);
			}
		}
	}
}
