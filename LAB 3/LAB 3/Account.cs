using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Account
    {
        public string accName;
        public string acid;
        public int balance;
        public int amount;

        public string AccName
        {
            set { accName = value; }
            get { return accName; }
        }
        public string Acid
        {
            set { acid = value; }
            get { return acid; }
        }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public int Amount
        {
            set { amount = value; }
            get { return amount; }
        }

        public Account()
        {
            Console.WriteLine("Account Created with default.");
        }

        public Account(string accName, string acid, int balance)
        {
            Console.WriteLine("Student Created with 3 parameters.");
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }

        public void deposit(int amount)
        {
            if(balance>0)
            {
                this.balance = balance + amount;
                Console.WriteLine("After Diposite: " +balance);
            }
            else
            {
                Console.WriteLine("Not Diposited.");
            }
                
        }

            public void withdraw(int amount)
            {
                if(amount>0 && amount<=balance)
                {
                    this.balance = balance - amount;
                    Console.WriteLine("After Withdraw: "+balance);
                }
                else
                {
                    Console.WriteLine("Can not withdraw.");
                }
            }
         public void ShowInfo()
        {
            Console.WriteLine("Account Name is: " + accName);
            Console.WriteLine("ID is: " + acid);
            Console.WriteLine("Balance is: " + balance);
        }
        }
    }

