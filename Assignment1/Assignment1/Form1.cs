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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bank bank = new Bank();
        public void passBank(Bank passedbank)
        {
            this.bank = passedbank;
        }
        private void createbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((savingradiobutton.Checked == false & currentradiobutton.Checked == false) || string.IsNullOrWhiteSpace(nametextbox.Text) || string.IsNullOrWhiteSpace(numbertextbox.Text))
                {
                    MessageBox.Show("Please fill in information properly", "ERROR");
                }
                else if (savingradiobutton.Checked == true)
                {
                    if (bank.containsaccnumber(Convert.ToInt32(numbertextbox.Text))==false)
                    {
                        bank.addaccount(new Saving(nametextbox.Text, Convert.ToInt32(numbertextbox.Text)));
                        //MessageBox.Show(bank.getaccount(Convert.ToInt32(numbertextbox.Text)).accountname, "FOUND");
                    }
                    else
                    {
                        MessageBox.Show("Account already exists", "EXISTS");
                    }
                }
                else if (currentradiobutton.Checked == true)
                {
                    if (bank.containsaccnumber(Convert.ToInt32(numbertextbox.Text)) == false)
                    {
                        bank.addaccount(new Current(nametextbox.Text, Convert.ToInt32(numbertextbox.Text)));
                        //MessageBox.Show(bank.getaccount(Convert.ToInt32(numbertextbox.Text)).accountname, "FOUND");
                    }
                    else
                    {
                        MessageBox.Show("Account number already exists", "EXISTS");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter number for account number", "ERROR");
            }
          
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 s = new Form2();
            s.passBank(ref bank);
            s.Show();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            //this.Close();
            //this.Dispose();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.savingradiobutton.Checked = false;
            this.currentradiobutton.Checked = false;
        }
    }
}
