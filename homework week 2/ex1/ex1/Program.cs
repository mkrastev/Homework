using System;

namespace ex1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter 0-9 digit:");
			int digit = int.Parse(Console.ReadLine());
			switch (digit) {
			case 1:
				Console.WriteLine ("One!");
				break;
			case 2:
				Console.WriteLine ("Zwei!");
				break;
			case 3:
				Console.WriteLine ("Tres!");
				break;
			case 4:
				Console.WriteLine ("Quatro!");
				break;
			case 5:
				Console.WriteLine ("Pet!");
				break;
			case 6:
				Console.WriteLine ("Six!");
				break;
			case 7:
				Console.WriteLine ("Seven!");
				break;
			case 8:
				Console.WriteLine ("Eight!");
				break;
			case 9:
				Console.WriteLine ("Nien!");
				break;
			default:
				Console.WriteLine ("Zero!");
				break;
			}
		}
	}
}
