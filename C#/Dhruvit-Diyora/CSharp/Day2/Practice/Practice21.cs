using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    class Practice21
    {
        class Employee
        {
            public int Age { get; set; }

            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new Employee();
                emp.Age = 29;
                Console.WriteLine("Age is: {0}", emp.Age);
                emp.Name = "Kanan";
                Console.WriteLine("Name is: {0}", emp.Name);
            }
        }
    }
}
