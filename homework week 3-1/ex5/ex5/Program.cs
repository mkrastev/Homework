using System;

namespace ex5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter array size:");
			int size = int.Parse (Console.ReadLine());
			Console.WriteLine ();

			int[] arrayUno = new int [size];
			int[] arrayDos = new int [size];
			Random rand = new Random ();

			Console.WriteLine ("The first array is:");

			for (int i = 0; i < size; i++) {
				arrayUno [i] = rand.Next(0, 1000);
				Console.WriteLine (arrayUno[i]);
			}
			Console.WriteLine ();

			Console.WriteLine ("The second array is a copy of the first and consists of the following integers:");
			for (int i = 0; i < size; i++) {
				arrayDos [i] = arrayUno [i];
				Console.WriteLine (arrayDos[i]);

			}
		}
	}
}
