using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
	class University
	{
		int year;
		public string address;
		string name;

		public University()
		{
				
		}
		public University(int year, string address, string name)
		{
			this.year = year;
			this.address = address;
			this.name = name;
		}

		public static University operator++(University u1)
		{
			 u1.year++;
			return u1;
		}

		public static University operator --(University u2)
		{
			if (u2.year > 1)
			{
				u2.year--;
				return u2;
			}
			throw new Exception("tariqn 0-ic poqr chi karox linel!");
		}


		public  static University operator+(University u1, University u2)
		{
			return new University(u1.year + u1.year, u1.address + "+" + u2.address, u1.name + "+" + u2.name); ;
		}

		public static University operator-(University u1, University u2)
		{
			return new University(u1.year-u1.year, u1.address+"-"+u2.address, u1.name+"-"+u2.name);
		}
		public static bool operator ==(University u1, University u2)
		{
			return u1.year == u2.year;
		}
		public static bool operator !=(University u1, University u2)
		{
			return u1.year != u2.year;
		}
		public static bool operator>(University u1, University u2)
		{
			return u1 > u2;
		}
		public static bool operator<(University u1, University u2)
		{
			return u1 < u2;
		}
		public static int operator*(University u1, University u2)
		{
			return u1.year * u2.year;
		}

		public static int operator/(University u1, University u2)
		{
			return u1.year / u2.year;
		}
		public static int operator%(University u1, University u2)
		{
			return u1.year % u2.year;
		}
	
		public override string ToString()
		{
			return "year="+year;
		}

		
	}
}
