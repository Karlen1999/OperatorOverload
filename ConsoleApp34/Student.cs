using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp34
{
	class Student
	{
		string name;
		int age;
		University universityName;
		public Student()
		{

		}
		public Student(string name, int age, string universityName)
		{
			this.name = name;
			this.age = age;
			//this.universityName = universityName;
		}

		public static Student operator ++(Student s1)
		{
		s1.age++;
			return s1;
		}
		public static Student operator --(Student s1)
		{
			s1.age--;
			return s1;
		}
		public static int operator +(Student s1, Student s2)
		{
			return s1.age + s2.age;
		}
		public static int operator -(Student s1, Student s2)
		{
			return s1.age - s2.age;
		}
		public static int operator *(Student s1, Student s2)
		{
			return s1.age * s2.age;
		}
		public static int operator /(Student s1, Student s2)
		{
			return s1.age / s2.age;
		}
		public static bool operator ==(Student s1, Student s2)
		{
			return s1.age == s2.age;
		}
		public static bool operator !=(Student s1, Student s2)
		{
			return s1.age != s2.age;
		}
		public static bool operator >(Student s1, Student s2)
		{
			return s1.age > s2.age;
		}
		public static bool operator <(Student s1, Student s2)
		{
			return s1.age <s2.age;
		}

		public override string ToString()
		{
			return "age=" + age;
		}
	

	}
}
