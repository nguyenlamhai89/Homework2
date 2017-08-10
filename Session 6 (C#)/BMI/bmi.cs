using System;

namespace FirstCSProjectọ
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine ("Enter your height");
			float height = Convert.ToInt32(Console.ReadLine ());
			height = height / 100;
			while (height <= 0)
			{
				Console.WriteLine ("Invalid height, try again: ");
				height = Convert.ToInt32(Console.ReadLine ());
			}

			Console.WriteLine ("Enter your mass(kg): ");
			float mass = Convert.ToInt32(Console.ReadLine ());
			while (mass <= 0)
			{
				Console.WriteLine("Invalid mass,try again: ");
				mass = Convert.ToInt32(Console.ReadLine ());
			}
			float BMI = mass/(height*height);
			Console.WriteLine("Your BMI is: " + BMI);

			if (BMI < 16) {
				Console.WriteLine ("Severely underweight");
			}
					else if (BMI < 18.5)
					{
						Console.WriteLine("Underweight");
					}
					else if (BMI < 25)
					{
						Console.WriteLine("Normal");
					}
					else if (BMI < 30)
					{
						Console.WriteLine("Overweight");
					}
					else if (BMI >= 30)
					{
						Console.WriteLine("Obese");
					}
		
		}
	}
}

