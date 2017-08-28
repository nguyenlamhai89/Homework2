using System;
using System.Collections.Generic;

namespace UCLN
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int a = 18;
			int b = 12;
			int UCLN = 0;
			for(int i = Math.Max(a, b); i>= 1; i--)
			{
				if(a % i == 0 && b % i == 0)
				{
					UCLN = i;
					break;
				}
			}
			Console.WriteLine ("Uoc chung lon nhat la: {0}", UCLN);

		}
	}
}

