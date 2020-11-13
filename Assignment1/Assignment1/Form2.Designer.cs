namespace Assignment1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent(/*Form1 f1*/)
        {
            this.infogroupbox = new System.Windows.Forms.GroupBox();
            this.accountnumberlabel = new System.Windows.Forms.Label();
            this.numbertextbox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.detailsgroupbox = new System.Windows.Forms.GroupBox();
            this.acctypevalue = new System.Windows.Forms.Label();
            this.accbalvalue = new System.Windows.Forms.Label();
            this.accnumvalue = new System.Windows.Forms.Label();
            this.accnamevalue = new System.Windows.Forms.Label();
            this.acctypedetails = new System.Windows.Forms.Label();
            this.accbalancedetails = new System.Windows.Forms.Label();
            this.accnumdetails = new System.Windows.Forms.Label();
            this.accnamedetails = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.transactionbutton = new System.Windows.Forms.Button();
            this.activebutton = new System.Windows.Forms.Button();
            this.infogroupbox.SuspendLayout();
            this.detailsgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // infogroupbox
            // 
            this.infogroupbox.Controls.Add(this.accountnumberlabel);
            this.infogroupbox.Controls.Add(this.numbertextbox);
            this.infogroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.infogroupbox.Location = new System.Drawing.Point(8, 12);
            this.infogroupbox.Name = "infogroupbox";
            this.infogroupbox.Size = new System.Drawing.Size(447, 75);
            this.infogroupbox.TabIndex = 4;
            this.infogroupbox.TabStop = false;
            this.infogroupbox.Text = "Search Account ";
            // 
            // accountnumberlabel
            // 
            this.accountnumberlabel.AutoSize = true;
            this.accountnumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accountnumberlabel.Location = new System.Drawing.Point(6, 31);
            this.accountnumberlabel.Name = "accountnumberlabel";
            this.accountnumberlabel.Size = new System.Drawing.Size(154, 24);
            this.accountnumberlabel.TabIndex = 3;
            this.accountnumberlabel.Text = "Account Number";
            // 
            // numbertextbox
            // 
            this.numbertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numbertextbox.Location = new System.Drawing.Point(177, 28);
            this.numbertextbox.Name = "numbertextbox";
            this.numbertextbox.Size = new System.Drawing.Size(242, 28);
            this.numbertextbox.TabIndex = 1;
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchbutton.Location = new System.Drawing.Point(279, 240);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(87, 35);
            this.searchbutton.TabIndex = 6;
            this.searchbutton.Text = "Search ";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // detailsgroupbox
            // 
            this.detailsgroupbox.Controls.Add(this.acctypevalue);
            this.detailsgroupbox.Controls.Add(this.accbalvalue);
            this.detailsgroupbox.Controls.Add(this.accnumvalue);
            this.detailsgroupbox.Controls.Add(this.accnamevalue);
            this.detailsgroupbox.Controls.Add(this.acctypedetails);
            this.detailsgroupbox.Controls.Add(this.accbalancedetails);
            this.detailsgroupbox.Controls.Add(this.accnumdetails);
            this.detailsgroupbox.Controls.Add(this.accnamedetails);
            this.detailsgroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.detailsgroupbox.Location = new System.Drawing.Point(10, 93);
            this.detailsgroupbox.Name = "detailsgroupbox";
            this.detailsgroupbox.Size = new System.Drawing.Size(447, 141);
            this.detailsgroupbox.TabIndex = 7;
            this.detailsgroupbox.TabStop = false;
            this.detailsgroupbox.Text = "Account Details";
            // 
            // acctypevalue
            // 
            this.acctypevalue.AutoSize = true;
            this.acctypevalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.acctypevalue.Location = new System.Drawing.Point(171, 92);
            this.acctypevalue.Name = "acctypevalue";
            this.acctypevalue.Size = new System.Drawing.Size(0, 24);
            this.acctypevalue.TabIndex = 10;
            // 
            // accbalvalue
            // 
            this.accbalvalue.AutoSize = true;
            this.accbalvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accbalvalue.Location = new System.Drawing.Point(170, 68);
            this.accbalvalue.Name = "accbalvalue";
            this.accbalvalue.Size = new System.Drawing.Size(0, 24);
            this.accbalvalue.TabIndex = 9;
            // 
            // accnumvalue
            // 
            this.accnumvalue.AutoSize = true;
            this.accnumvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accnumvalue.Location = new System.Drawing.Point(170, 44);
            this.accnumvalue.Name = "accnumvalue";
            this.accnumvalue.Size = new System.Drawing.Size(0, 24);
            this.accnumvalue.TabIndex = 8;
            // 
            // accnamevalue
            // 
            this.accnamevalue.AutoSize = true;
            this.accnamevalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accnamevalue.Location = new System.Drawing.Point(170, 20);
            this.accnamevalue.Name = "accnamevalue";
            this.accnamevalue.Size = new System.Drawing.Size(0, 24);
            this.accnamevalue.TabIndex = 7;
            // 
            // acctypedetails
            // 
            this.acctypedetails.AutoSize = true;
            this.acctypedetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.acctypedetails.Location = new System.Drawing.Point(4, 92);
            this.acctypedetails.Name = "acctypedetails";
            this.acctypedetails.Size = new System.Drawing.Size(133, 24);
            this.acctypedetails.TabIndex = 6;
            this.acctypedetails.Text = "Account Type:";
            // 
            // accbalancedetails
            // 
            this.accbalancedetails.AutoSize = true;
            this.accbalancedetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accbalancedetails.Location = new System.Drawing.Point(6, 68);
            this.accbalancedetails.Name = "accbalancedetails";
            this.accbalancedetails.Size = new System.Drawing.Size(158, 24);
            this.accbalancedetails.TabIndex = 5;
            this.accbalancedetails.Text = "Account Balance:";
            // 
            // accnumdetails
            // 
            this.accnumdetails.AutoSize = true;
            this.accnumdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accnumdetails.Location = new System.Drawing.Point(5, 44);
            this.accnumdetails.Name = "accnumdetails";
            this.accnumdetails.Size = new System.Drawing.Size(159, 24);
            this.accnumdetails.TabIndex = 4;
            this.accnumdetails.Text = "Account Number:";
            // 
            // accnamedetails
            // 
            this.accnamedetails.AutoSize = true;
            this.accnamedetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accnamedetails.Location = new System.Drawing.Point(6, 20);
            this.accnamedetails.Name = "accnamedetails";
            this.accnamedetails.Size = new System.Drawing.Size(141, 24);
            this.accnamedetails.TabIndex = 3;
            this.accnamedetails.Text = "Account Name:";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backbutton.Location = new System.Drawing.Point(372, 240);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(85, 35);
            this.backbutton.TabIndex = 8;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // transactionbutton
            // 
            this.transactionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.transactionbutton.Location = new System.Drawing.Point(168, 240);
            this.transactionbutton.Name = "transactionbutton";
            this.transactionbutton.Size = new System.Drawing.Size(105, 35);
            this.transactionbutton.TabIndex = 9;
            this.transactionbutton.Text = "Transaction";
            this.transactionbutton.UseVisualStyleBackColor = true;
            this.transactionbutton.Click += new System.EventHandler(this.transactionbutton_Click);
            // 
            // activebutton
            // 
            this.activebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.activebutton.Location = new System.Drawing.Point(10, 240);
            this.activebutton.Name = "activebutton";
            this.activebutton.Size = new System.Drawing.Size(152, 35);
            this.activebutton.TabIndex = 10;
            this.activebutton.Text = "Active Accounts";
            this.activebutton.UseVisualStyleBackColor = true;
            this.activebutton.Click += new System.EventHandler(this.activebutton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 289);
            this.Controls.Add(this.activebutton);
            this.Controls.Add(this.transactionbutton);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.infogroupbox);
            this.Controls.Add(this.detailsgroupbox);
            this.Name = "Form2";
            this.Text = "Search Account";
            this.infogroupbox.ResumeLayout(false);
            this.infogroupbox.PerformLayout();
            this.detailsgroupbox.ResumeLayout(false);
            this.detailsgroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infogroupbox;
        private System.Windows.Forms.Label accountnumberlabel;
        private System.Windows.Forms.TextBox numbertextbox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.GroupBox detailsgroupbox;
        private System.Windows.Forms.Label acctypedetails;
        private System.Windows.Forms.Label accbalancedetails;
        private System.Windows.Forms.Label accnumdetails;
        private System.Windows.Forms.Label accnamedetails;
        private System.Windows.Forms.Label acctypevalue;
        private System.Windows.Forms.Label accbalvalue;
        private System.Windows.Forms.Label accnumvalue;
        private System.Windows.Forms.Label accnamevalue;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button transactionbutton;
        private System.Windows.Forms.Button activebutton;
    }
}