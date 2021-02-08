using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3
{
    class Account
    {
        string accName;
        string acid;
        int balance;
        int amount;

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

        public void deposit()
        {
            if(balance>0)
            {
                balance += amount;
                Console.WriteLine("Diposited: " +balance);
            }
            else
            {
                Console.WriteLine("Not Diposited.");
            }
                
        }

            public void withdraw()
            {
                if(amount>0 && amount<=balance)
                {
                    this.balance = balance - amount;
                    Console.WriteLine("Withdraw: "+balance);
                }
                else
                {
                    Console.WriteLine("Can not withdraw.");
                }
            }

        }
    }
}
