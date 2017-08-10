using System;

namespace Stars3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Nhap chieu dai: ");
			int cd = Convert.ToInt32(Console.ReadLine ());
			Console.WriteLine ("Nhap chieu rong: ");
			int cr = Convert.ToInt32(Console.ReadLine ());
			for (int j = 0; j < cr; j++) {
				for (int i = 0; i < cd; i++) {
					if (j % 2 == 0) {
						if (i % 2 == 0) {
							Console.Write ("x");
						} else {
							Console.Write ("*");
						}
					} else 
					{
						if (i % 2 != 0) 
						{
							Console.Write ("x");
						}
						else
						{
							Console.Write ("*");
						}
					}
				}
				Console.WriteLine ();
			}
		}
	}
}
