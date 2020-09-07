using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
	class Lecture
	{
		string name;
		int age;
		University universityName;
		public Lecture()
		{

		}
		public Lecture(string name, int age, University universityName)
		{
			this.name = name;
			this.age = age;
			this.universityName = universityName;
		}

		public static Lecture operator ++(Lecture l1)
		{
			l1.age++;
			return l1;
		}
		public static Lecture operator --(Lecture L1)
		{
			L1.age--;
			return L1;
		}
		public static int operator +(Lecture l1, Lecture l2)
		{
			return l1.age + l2.age;
		}
		public static int operator -(Lecture l1, Lecture l2)
		{
			return l1.age - l2.age;
		}
		public static int operator *(Lecture l1, Lecture l2)
		{
			return l1.age * l2.age;
		}
		public static int operator /(Lecture l1, Lecture l2)
		{
			return l1.age / l2.age;
		}
		public static bool operator ==(Lecture l1, Lecture l2)
		{
			return l1.age == l2.age;
		}
		public static bool operator !=(Lecture l1, Lecture l2)
		{
			return l1.age != l2.age;
		}
		public static bool operator >(Lecture l1, Lecture l2)
		{
			return l1.age > l2.age;
		}
		public static bool operator <(Lecture l1, Lecture l2)
		{
			return l1.age < l2.age;
		}

		public override string ToString()
		{
			return "age=" + age;
		}
	}
}

