using System;
using System.Collections.Generic;

namespace NhiPhan
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Nhap so cac so: ");
			int nums = Convert.ToInt32 (Console.ReadLine ());

			Random random = new Random ();
			List<int> list = new List<int>();
			for (int i = 0; i < nums ; i++)
			{
				int n = random.Next (1, 100);
				list.Add (n);
				string nhiphan = Convert.ToString(n , 2);
				Console.Write ("Day nhi phan cua " + n + " la: " + nhiphan);
				Console.WriteLine ();
			}
		}
	}
}