using System;

namespace Stars2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Nhap chieu dai: ");
			int cd = Convert.ToInt32 (Console.ReadLine ());
			for (int i = 0; i < cd; i++) {
				if (i % 2 == 0) {
					Console.Write ("x");
				}
				else{
					Console.Write("*");
				}
			}
		}
	}
}
