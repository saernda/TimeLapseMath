using System;

namespace TimeLapseMath
{
	class MainClass
	{

		/*
		 * H = Total Hours taken for time lapse in real time. 
		 * FR = Frame Rate in which the images will be displayed (24, 25, 30, 60 etc.). 
		 * Dtrt = Desired Total Running Time of your final video in seconds
		 */
		
		public static void Main (string[] args)
		{
			Math (3, 30, 300);
		}

		public static void Math (int H, int FR, int Dtrt)
		{
			int a = H * 3600; 
			int b = FR * Dtrt;
			float c = (float)a / (float)b;
			Console.Write ("Take a picture every " + c + " second");
			Console.Write ("Press Enter To Exit");
			Console.ReadLine ();
		
		}
	}
}
