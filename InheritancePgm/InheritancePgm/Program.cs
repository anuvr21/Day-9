using System;
using System.ComponentModel;
using System.Linq;

namespace InheritPgm

{
    class Program

    {

        static void Main(string[] args)

        {
            Employee e = new Employee(101,"Anu",10);
            Console.WriteLine(e);
        }

    }

    public class Account

    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Account() { }

        public Account(int id, string name)
        {
            Id= id;
            Name= name;
        }
        public override string ToString()
        {
            return $"EmpId: {Id} \t EmpName: {Name} \t Salary: {}";
        }
    }

}

















