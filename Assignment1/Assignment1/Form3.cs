using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form3 : Form
    {
        Bank bank2;
        string passedaccnum;
        public Form3()
        {
            InitializeComponent();
        }
        public void passBank(ref Bank bank,String txt)
        {
            bank2 = bank;
            passedaccnum = txt;
        }
        public Bank accessBank
        {
            get { return bank2; }
            set { this.bank2 = value; }
        }
        
        private void dobutton_Click(object sender, EventArgs e)
        {

            try
            {
                if (deposittextbox.Text != "" & withdrawtextbox.Text == "")
                {
                    bank2.getaccount(Convert.ToInt32(passedaccnum)).deposit(Convert.ToDouble(deposittextbox.Text));
                    accbalview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountbalance) + " $";
                    deposittextbox.Text = "";
                }
                if (deposittextbox.Text == "" & withdrawtextbox.Text != "")
                {
                    bank2.getaccount(Convert.ToInt32(passedaccnum)).withdraw(Convert.ToDouble(withdrawtextbox.Text));
                    accbalview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountbalance) + " $";
                    withdrawtextbox.Text = "";
                }
                if (deposittextbox.Text != "" & withdrawtextbox.Text != "")
                {
                    MessageBox.Show("Both Withdaw and Deposit not possible", "ERROR");
                    deposittextbox.Text = "";
                    withdrawtextbox.Text = "";
                    sendtextbox.Text = "";
                    amounttextbox.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Account balance bcome less than 0$", "ERROR");
                deposittextbox.Text = "";
                withdrawtextbox.Text = "";
                sendtextbox.Text = "";
                amounttextbox.Text = "";
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            accnumview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountnumber);
            accnameview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountname);
            accbalview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountbalance)+" $";
            acctypeview.Text = bank2.getaccounttype(Convert.ToInt32(passedaccnum))+" Account";
            accinterestview.Text = "NOT APPLICABLE";


        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2= new Form2();
            f2.passBank(bank2);
            f2.Show();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(sendtextbox.Text) || string.IsNullOrWhiteSpace(amounttextbox.Text))
                {
                    MessageBox.Show("Propery fill in information", "ERROR");
                }
                else if (bank2.contains(Convert.ToInt32(sendtextbox.Text)))
                {
                    bank2.getaccount(Convert.ToInt32(sendtextbox.Text)).deposit(Convert.ToDouble(amounttextbox.Text));
                    bank2.getaccount(Convert.ToInt32(passedaccnum)).withdraw(Convert.ToDouble(amounttextbox.Text));
                    sendtextbox.Text = "";
                    amounttextbox.Text = "";
                    deposittextbox.Text = "";
                    withdrawtextbox.Text = "";
                    accbalview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountbalance) + " $";
                }
                else
                {
                    MessageBox.Show("No such account ", "ERROR");

                }
            }
            catch
            {
                MessageBox.Show("Account balance bcome less than 0$ OR improper amount inserted", "ERROR");
                deposittextbox.Text = "";
                withdrawtextbox.Text = "";
                sendtextbox.Text = "";
                amounttextbox.Text = "";
            }
        }
    }
}
