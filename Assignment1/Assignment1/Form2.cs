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
    public partial class Form2 : Form
    {
        Bank bank1;
        string passedtxt;
        string counttext;
        public Form2()
        {
            InitializeComponent();
        }
        public void passBank(Bank passedbank)
        {
            this.bank1 = passedbank;
        }
        public void passBank(ref Bank bank)
        {
            bank1 = bank;
        }
        public Bank accessBank
        {
            get { return bank1; }
            set { this.bank1 = value; }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(numbertextbox.Text))
                {
                    MessageBox.Show("Enter Account number", "ERROR");
                }
                else if (numbertextbox.Text == accnumvalue.Text)
                {
                    MessageBox.Show("Already Found, search another", "FOUND");
                }
                else
                {
                    if (bank1.contains(Convert.ToInt32(numbertextbox.Text)))
                    {
                        accnamevalue.Text = bank1.getaccount(Convert.ToInt32(numbertextbox.Text)).accountname;
                        accnumvalue.Text = Convert.ToString(bank1.getaccount(Convert.ToInt32(numbertextbox.Text)).accountnumber);
                        accbalvalue.Text = Convert.ToString(bank1.getaccount(Convert.ToInt32(numbertextbox.Text)).accountbalance) + " $";
                        acctypevalue.Text = bank1.getaccounttype(Convert.ToInt32(numbertextbox.Text)) + " Account";
                    }
                    else
                    {
                        MessageBox.Show("No account found", "ERROR");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter Account number not name", "ERROR");
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            accnamevalue.Text= "";
            accnumvalue.Text = "";
            accbalvalue.Text = "";
            acctypevalue.Text = "";
            Form1 main = new Form1();
            main.passBank(bank1);
            main.Show();
        }

        private void transactionbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numbertextbox.Text))
            {
                MessageBox.Show("Enter Account number", "ERROR");
            }
            else if (bank1.contains(Convert.ToInt32(numbertextbox.Text)))
            {
                if (bank1.getaccounttype(Convert.ToInt32(numbertextbox.Text)) == "Current")
                {
                    this.Hide();
                    passedtxt = numbertextbox.Text;
                    Form3 t = new Form3();
                    t.passBank(ref bank1, passedtxt);
                    t.Show();
                }
                else if (bank1.getaccounttype(Convert.ToInt32(numbertextbox.Text)) == "Saving")
                {
                    this.Hide();
                    passedtxt = numbertextbox.Text;
                    Form4 t = new Form4();
                    t.passBank(ref bank1, passedtxt);
                    t.Show();
                }
            }
            else
            {
                MessageBox.Show("No account found", "ERROR");
            }
        }

        private void activebutton_Click(object sender, EventArgs e)
        {
            counttext = "Active accounts: "+Convert.ToString(bank1.count());
            MessageBox.Show(counttext, "Active");
        }
    }
   
}
