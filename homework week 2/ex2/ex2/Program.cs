using System;

namespace ex2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter your points:");
			int pts = int.Parse (Console.ReadLine());

			if (pts >= 1 && pts <= 3) {
				pts *= 3; 
			}
			else if (pts >= 4 && pts <= 6) {
				pts *= 10; 
			}
			else if (pts >= 7 && pts <= 9) {
				pts *= 50; 
			}
			else if (pts <= 0 && pts >= 10){
				Console.WriteLine ("Invalid points, try again :/");
			}
			Console.WriteLine ("Total points:" + pts);

		}
	}
}
