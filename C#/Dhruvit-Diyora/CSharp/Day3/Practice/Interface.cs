using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    interface IBank
    {
        void Createaccount();
        void Closeaccount();
        void Withdraw();
        void Deposit();
        void display();

    }
    abstract class Bank : IBank
    {
        static int AccountID;
        protected float balance, amountdeposited, initialbalance;
        string name, address;
        bool Accountstatus;

        public virtual void Createaccount()
        {
            AccountID += 1;
            Console.WriteLine("Enter Name ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter Initial Balance");
            initialbalance = Convert.ToSingle(Console.ReadLine());
            Accountstatus = true;
        }
        public virtual void Closeaccount()
        {
            Accountstatus = false;
        }
        public virtual void Deposit()
        {
            Console.WriteLine("Enter Amount to be deposited");
            amountdeposited = Convert.ToSingle(Console.ReadLine());
            balance += amountdeposited;
        }
        public abstract void Withdraw();
        public virtual void display()
        {
            Console.WriteLine($"Account id {AccountID}Name is {name} Address is {address} Balance {balance}");
        }
    }
    class Saving : Bank
    {

        public override void Withdraw()
        {
            Console.WriteLine("Saving WithDraw Function");
        }
    }
    class FixedDeposit : Bank
    {
        float tenure, interest, maturityamount;
        DateTime createdate, maturitydate;
        public override void Createaccount()
        {
            base.Createaccount();
            Console.WriteLine("Enter Tenure in month");
            tenure = Convert.ToSingle(Console.ReadLine());
            createdate = DateTime.Now;
            Console.WriteLine("Enter Rate of Interest");
            interest = Convert.ToInt32(Console.ReadLine());
            maturitydate = createdate.AddMonths((int)tenure);
            maturityamount = (initialbalance * (interest / 100)) + initialbalance;

        }
        public override void Withdraw()
        {
            if (DateTime.Now >= maturitydate)
            {
                balance = maturityamount;
            }
            else
            {
                throw new Exception($"Time is left Maturity date is {maturitydate} ");
            }
        }
        public void getspecialbenifit()
        {
            Console.WriteLine("Credit card issue");
        }
    }
    class Current : Bank
    {
        public new void Createaccount()
        {
            Console.WriteLine("Create Account current");
        }
        public override void Withdraw()
        {
            Console.WriteLine("Current Function");
        }
    }

    class Interface
    {
        public void FuncionInvoke(IBank bank)
        {
            if (bank.GetType().Name == "Current")
            {
                Current current = (Current)bank;
                current.Createaccount();
                bank.Deposit();
                bank.Withdraw();
                bank.Closeaccount();
                bank.display();
            }
            else
            {

                bank.Createaccount();
                bank.Deposit();
                bank.Withdraw();
                bank.Closeaccount();
                bank.display();
            }
            if (bank.GetType().Name == "FixedDeposit")
            {
                FixedDeposit fixedDeposit = (FixedDeposit)bank;
                fixedDeposit.getspecialbenifit();
            }



        }
        static void Main(string[] args)
        {
            IBank bank = null;
            Console.WriteLine("Enter 1 for saving Enter 2 for current Enter 3 fixed deposit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    bank = new Saving();

                    break;
                case 2:
                    bank = new Current();
                    break;
                case 3:
                    bank = new FixedDeposit();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;


            }
            var Interface = new Interface();
            Interface.FuncionInvoke(bank);
            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
