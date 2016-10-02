using System;

namespace ex4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter x:");
			float x = float.Parse (Console.ReadLine());
			Console.WriteLine ("Enter y");
			float y = float.Parse (Console.ReadLine());

			float div = (x / y);
			string exc = div.ToString();
			exc = exc.Substring (1, 6);
			Console.WriteLine ("ostatuk ot delenieto = " + exc);

		}
	}
}
