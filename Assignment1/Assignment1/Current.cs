using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Current : AccountInterface
    {
        string accname;
        private int accnumber;
        private double balance;
        public Current(string accname, int accnumber)
        {
            this.accname = accname;
            this.accnumber = accnumber;
            this.accountbalance = 0;
        }
        public string accountname
        {
            get { return this.accname; }
            set { this.accname = value; }
        }
        public int accountnumber
        {
            get { return this.accnumber; }
            set { this.accnumber = value; }
        }
        public double accountbalance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public int accountinterestrate 
        { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException(); 
        }

        public void deposit(double damount)
        {
            this.balance = this.balance + damount;
        }
        public void withdraw(double wamount)
        {
            if (this.balance - wamount >= 0)
            {
                this.balance = this.balance - wamount;
            }
            else
            {
                throw new Exception();
            }
        }
        public double interest(int intrate)
        {
            throw new NotImplementedException();
        }

        public void transfer(int tnumber, double tamount)
        {
            throw new NotImplementedException();
        }
     
    }
}
