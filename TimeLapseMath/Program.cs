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
			Console.WriteLine ("How many hours do you have?");
			int H_a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine (" ");
			Console.WriteLine ("What framerate do you use?");
			int FR_a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine (" ");
			Console.WriteLine ("How many secound are your final video?");
			int Dtrt_a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine (" ");

			MathOut (H_a, FR_a, Dtrt_a);
		}

		public static void MathOut (int H, int FR, int Dtrt)
		{
			int a = H * 3600; 
			int b = FR * Dtrt;
			float c = (float)a / (float)b;
			Console.WriteLine ("Hour = " + H + ". Fps = " + FR + ". Final video in sec = " + Dtrt);
			Console.WriteLine ("Take a picture every " + c + " second");
			Console.WriteLine ("Press Enter To Exit");
			Console.ReadKey (true);
		}
	}
}
