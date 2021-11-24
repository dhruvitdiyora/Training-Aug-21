using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    interface IEmp
    {
        void Get();
        void Display();
        void Salary();


    }
    abstract class Employee : IEmp
    {
        static int AccountID;
        string Name, Address,PanNumber;
        public virtual void Display()
        {
            Console.WriteLine($"Employee's Account Id is {AccountID} , Name is {Name} , Address is {Address} , PAN is {PanNumber}");
        }

        public virtual void Get()
        {
            AccountID += 1;
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Address:");
            Address = Console.ReadLine();
            Console.WriteLine("Enter Pan Number:");
            PanNumber = Console.ReadLine();
        }

        public virtual void Salary()
        {
            //Console.WriteLine("working");
        }
    }
    class PartTime : Employee
    {
        int NoOfHour, SalePerHour;
        public override void Salary()
        {
            base.Salary();
            Console.WriteLine("Enter no of hours worked:");
            NoOfHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter sales per hr:");
            SalePerHour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your salary should be {NoOfHour*SalePerHour}");

        }

    }
    class FullTime : Employee
    {
        int Basic, TA, HRA, DA;
        public override void Salary()
        {
            base.Salary();
            Console.WriteLine("Enter Basics");
            Basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter TA");
            TA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter HRA");
            HRA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DA");
            TA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your salary should be {Basic*TA*HRA*DA}");
        }
    }
    class Assignment
    {
        public void functioncall(IEmp obj)
        {
            obj.Get();
            obj.Salary();
            obj.Display();
        }
        static void Main(string[] args)
        {
            IEmp obj = null;
            Console.WriteLine("Select job type:\n1 for Parttime job\n2 for Fulltime job");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    obj = new PartTime();
                    break;
                case 2:
                    obj = new FullTime();
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }

            Assignment assign = new Assignment();
            assign.functioncall(obj);
        }
    }
}
