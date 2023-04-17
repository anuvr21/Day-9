using System;
namespace InheritPgm
{
    public class Employee:Account
    {
		private int _salary;

		public int Salary
		{ 
			get { return _salary; }
			set { _salary = value; }
		}
		public Employee() { }
		public Employee(int id,string name,int salary):base(id,name)
		{
			Salary = salary;
		}
		public void display()
		{
			Console.Write($"Salary: {Salary}");
		}
	}
}