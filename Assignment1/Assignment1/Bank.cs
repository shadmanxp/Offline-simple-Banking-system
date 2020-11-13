using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Bank
    {
        List<AccountInterface> banklist = new List<AccountInterface>() ;
        
        public void addaccount(AccountInterface a)
        {
            banklist.Add(a);
        }
        public AccountInterface getaccount(int n)
        {

            return banklist.Find(Account => Account.accountnumber == n);
        }
        public bool contains(int n)
        {
            return banklist.Contains(getaccount(n));
        }
        public int count()
        {
            return banklist.Count();
        }
        public string getaccounttype(int n)
        {
            
            return banklist.Find(Account => Account.accountnumber == n).GetType().Name;
        }
        public bool containsaccnumber(int n)
        {
            return banklist.Exists(Account => Account.accountnumber == n);
        }
        public List<AccountInterface> transferList
        {
            get { return this.banklist; }
            set { this.banklist = value; }
        }

    }   
}
