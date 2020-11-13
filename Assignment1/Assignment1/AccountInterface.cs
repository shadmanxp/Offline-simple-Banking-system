using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public interface AccountInterface
    {
        //void setdetails(string accname, int accnumber, double balance);
        string accountname { get; set; }
        int accountnumber { get; set; }
        double accountbalance { get; set; }
        int accountinterestrate { get; set; }
        void withdraw(double wamount);
        void deposit(double damount);
        double interest(int intrate);
        void transfer(int tnumber,double tamount);



    }
}
