using System;

namespace ConsoleApp34
{
	class Program
	{
		static void Main(string[] args)
		{
			University politex = new University(1933, "Koryun", "NPUA");
			University politex1 = new University(1933, "Koryun", "NPUA");
			Console.WriteLine(politex>politex1);

			Lecture palyan = new Lecture("Armenak", 60, politex );
			Console.WriteLine(politex + politex1);
			Console.WriteLine(palyan++);



		}
	}
}
