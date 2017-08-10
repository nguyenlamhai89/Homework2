using System;

namespace Stars1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Nhap chieu dai: ");
			int cd = Convert.ToInt32 (Console.ReadLine ());
			for (int i = 0; i < cd; i++) {
				Console.Write ("*");
			}
		}
	}
}
