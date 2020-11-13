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
    public partial class Form4 : Form
    {
        Bank bank2;
        string passedaccnum;
        public Form4()
        {
            InitializeComponent();
        }
        public void passBank(ref Bank bank, String txt)
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
                MessageBox.Show("Improper digit inserted OR Account balance gets under 100$, can't do transaction!", "ERROR");
                deposittextbox.Text = "";
                withdrawtextbox.Text = "";
                sendtextbox.Text = "";
                amounttextbox.Text = "";
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            accnumview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountnumber);
            accnameview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountname);
            accbalview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountbalance) + " $";
            acctypeview.Text = bank2.getaccounttype(Convert.ToInt32(passedaccnum)) + " Account";
            accinterestview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountinterestrate)+" %";
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.passBank(bank2);
            f2.Show();
        }
        private void sendbutton_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(sendtextbox.Text)|| string.IsNullOrWhiteSpace(amounttextbox.Text))
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
                    MessageBox.Show("No such account", "ERROR");
                }
            }
            catch
            {
                MessageBox.Show("Account balance gets under 100$, can't send! OR improper amount inserted", "ERROR");
                deposittextbox.Text = "";
                withdrawtextbox.Text = "";
                amounttextbox.Text = "";
                sendtextbox.Text = "";
            }
        }

        private void changeratebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(changeratetextbox.Text))
            {

            }
            else
            {
                try
                {
                    bank2.getaccount(Convert.ToInt32(passedaccnum)).accountinterestrate = Convert.ToInt32(changeratetextbox.Text);
                    accinterestview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountinterestrate) + " %";
                    changeratetextbox.Text = "";
                }
                catch
                {
                    MessageBox.Show("Input proper number OR must be less than 50%", "ERROR");
                }
            }
        }

        private void calculateinterestbutton_Click(object sender, EventArgs e)
        {
            calculateinteresttextbox.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).interest((bank2.getaccount(Convert.ToInt32(passedaccnum)).accountinterestrate)));
            DialogResult dialogResult = MessageBox.Show("Interest amount:" + calculateinteresttextbox.Text+" $", "Update banace", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bank2.getaccount(Convert.ToInt32(passedaccnum)).deposit(Convert.ToDouble(calculateinteresttextbox.Text));
                accbalview.Text = Convert.ToString(bank2.getaccount(Convert.ToInt32(passedaccnum)).accountbalance) + " $";
                calculateinteresttextbox.Text = "";
            }
            else if (dialogResult == DialogResult.No)
            {
                calculateinteresttextbox.Text = "";
            }
        }
    }
}
