using System;

namespace ex3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter number of choice:");
			int dig = int.Parse (Console.ReadLine());

			switch (dig) {
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
				if (dig % 2 == 0) {
					Console.WriteLine ("Your number is even!"); break; 
				}
				else
				{
					Console.WriteLine ("Your number is uneven!"); break;
				}

			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 13:
			case 14:
			case 15:
				if (dig % 3 == 0) {
					Console.WriteLine ("Your number can be divided by 3 no problemo!"); break;
				}
				else
				{
					Console.WriteLine ("Your nmber can't be divided by :C"); break;
				}
			default:
				if (dig == 0) {
					Console.WriteLine ("Your digit is 0!");
				}
				else if (dig >= 0) {
					Console.WriteLine ("Your number is greater than 0!");
				}
				else if (dig <= 0) {
					Console.WriteLine ("Your number is lesser than 0!");
					}
				break;
			}
		}
	}
}
