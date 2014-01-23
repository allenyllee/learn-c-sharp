using System;

namespace TypeConversionApplication
{
	class ExpliceitConversion
	{
		static void Main (string[] args)
		{
			double d = 5673.74;
			int i;
			
			//cast double to int.
			i = (int)d;
			Console.WriteLine (i);
			Console.ReadKey ();
		}
	}
}
