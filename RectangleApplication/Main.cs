using System;

namespace RectangleApplication
{
	class Rectangle
	{
		//member variables
		double length;
		double width;
		
		public void Acceptdetials()
		{
			length = 4.5;
			width = 3.5;
		}
		public double GetArea()
		{
			return length*width;
		}
		public void Display()
		{
			Console.WriteLine ("Length: {0}",length);
			Console.WriteLine ("Width: {0}", width);
			Console.WriteLine ("Area: {0}", GetArea ());
		}
	}
	
	class ExecuteRectangle
	{
		static void Main (string[] args)
		{
			Rectangle r = new Rectangle();
			r.Acceptdetials ();
			r.Display();
			Console.ReadLine();
			//Console.WriteLine ("Hello World!");
		}
	}
}
