using System;
namespace Assignment1
{

    partial class Form3
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
        private void InitializeComponent()
        {
            this.transactiongroupbox = new System.Windows.Forms.GroupBox();
            this.Depositlabel = new System.Windows.Forms.Label();
            this.withdrawlabel = new System.Windows.Forms.Label();
            this.deposittextbox = new System.Windows.Forms.TextBox();
            this.withdrawtextbox = new System.Windows.Forms.TextBox();
            this.dobutton = new System.Windows.Forms.Button();
            this.accnumviewtext = new System.Windows.Forms.Label();
            this.accbalviewtext = new System.Windows.Forms.Label();
            this.accnameviewtext = new System.Windows.Forms.Label();
            this.acctypeviewtext = new System.Windows.Forms.Label();
            this.accnameview = new System.Windows.Forms.Label();
            this.accnumview = new System.Windows.Forms.Label();
            this.accbalview = new System.Windows.Forms.Label();
            this.acctypeview = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.accdetailsgroupbox = new System.Windows.Forms.GroupBox();
            this.accinterestview = new System.Windows.Forms.Label();
            this.accinteresttext = new System.Windows.Forms.Label();
            this.transfergroupbox = new System.Windows.Forms.GroupBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.amounttextbox = new System.Windows.Forms.TextBox();
            this.sendtextbox = new System.Windows.Forms.TextBox();
            this.amountlabel = new System.Windows.Forms.Label();
            this.sendmoneylabel = new System.Windows.Forms.Label();
            this.transactiongroupbox.SuspendLayout();
            this.accdetailsgroupbox.SuspendLayout();
            this.transfergroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // transactiongroupbox
            // 
            this.transactiongroupbox.Controls.Add(this.Depositlabel);
            this.transactiongroupbox.Controls.Add(this.withdrawlabel);
            this.transactiongroupbox.Controls.Add(this.deposittextbox);
            this.transactiongroupbox.Controls.Add(this.withdrawtextbox);
            this.transactiongroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.transactiongroupbox.Location = new System.Drawing.Point(12, 238);
            this.transactiongroupbox.Name = "transactiongroupbox";
            this.transactiongroupbox.Size = new System.Drawing.Size(199, 91);
            this.transactiongroupbox.TabIndex = 4;
            this.transactiongroupbox.TabStop = false;
            this.transactiongroupbox.Text = " Transaction amount";
            // 
            // Depositlabel
            // 
            this.Depositlabel.AutoSize = true;
            this.Depositlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Depositlabel.Location = new System.Drawing.Point(7, 55);
            this.Depositlabel.Name = "Depositlabel";
            this.Depositlabel.Size = new System.Drawing.Size(73, 24);
            this.Depositlabel.TabIndex = 3;
            this.Depositlabel.Text = "Deposit";
            // 
            // withdrawlabel
            // 
            this.withdrawlabel.AutoSize = true;
            this.withdrawlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.withdrawlabel.Location = new System.Drawing.Point(6, 25);
            this.withdrawlabel.Name = "withdrawlabel";
            this.withdrawlabel.Size = new System.Drawing.Size(88, 24);
            this.withdrawlabel.TabIndex = 2;
            this.withdrawlabel.Text = "Withdraw";
            // 
            // deposittextbox
            // 
            this.deposittextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deposittextbox.Location = new System.Drawing.Point(100, 55);
            this.deposittextbox.Name = "deposittextbox";
            this.deposittextbox.Size = new System.Drawing.Size(84, 24);
            this.deposittextbox.TabIndex = 1;
            // 
            // withdrawtextbox
            // 
            this.withdrawtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.withdrawtextbox.Location = new System.Drawing.Point(100, 25);
            this.withdrawtextbox.Name = "withdrawtextbox";
            this.withdrawtextbox.Size = new System.Drawing.Size(84, 24);
            this.withdrawtextbox.TabIndex = 0;
            // 
            // dobutton
            // 
            this.dobutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dobutton.Location = new System.Drawing.Point(12, 333);
            this.dobutton.Name = "dobutton";
            this.dobutton.Size = new System.Drawing.Size(199, 31);
            this.dobutton.TabIndex = 5;
            this.dobutton.Text = "Do Transaction";
            this.dobutton.UseVisualStyleBackColor = false;
            this.dobutton.Click += new System.EventHandler(this.dobutton_Click);
            // 
            // accnumviewtext
            // 
            this.accnumviewtext.AutoSize = true;
            this.accnumviewtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accnumviewtext.Location = new System.Drawing.Point(6, 45);
            this.accnumviewtext.Name = "accnumviewtext";
            this.accnumviewtext.Size = new System.Drawing.Size(159, 24);
            this.accnumviewtext.TabIndex = 6;
            this.accnumviewtext.Text = "Account Number:";
            // 
            // accbalviewtext
            // 
            this.accbalviewtext.AutoSize = true;
            this.accbalviewtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accbalviewtext.Location = new System.Drawing.Point(6, 69);
            this.accbalviewtext.Name = "accbalviewtext";
            this.accbalviewtext.Size = new System.Drawing.Size(158, 24);
            this.accbalviewtext.TabIndex = 7;
            this.accbalviewtext.Text = "Account Balance:";
            // 
            // accnameviewtext
            // 
            this.accnameviewtext.AutoSize = true;
            this.accnameviewtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accnameviewtext.Location = new System.Drawing.Point(6, 21);
            this.accnameviewtext.Name = "accnameviewtext";
            this.accnameviewtext.Size = new System.Drawing.Size(141, 24);
            this.accnameviewtext.TabIndex = 8;
            this.accnameviewtext.Text = "Account Name:";
            // 
            // acctypeviewtext
            // 
            this.acctypeviewtext.AutoSize = true;
            this.acctypeviewtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.acctypeviewtext.Location = new System.Drawing.Point(7, 93);
            this.acctypeviewtext.Name = "acctypeviewtext";
            this.acctypeviewtext.Size = new System.Drawing.Size(133, 24);
            this.acctypeviewtext.TabIndex = 9;
            this.acctypeviewtext.Text = "Account Type:";
            // 
            // accnameview
            // 
            this.accnameview.AutoSize = true;
            this.accnameview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accnameview.Location = new System.Drawing.Point(173, 21);
            this.accnameview.Name = "accnameview";
            this.accnameview.Size = new System.Drawing.Size(0, 24);
            this.accnameview.TabIndex = 10;
            // 
            // accnumview
            // 
            this.accnumview.AutoSize = true;
            this.accnumview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accnumview.Location = new System.Drawing.Point(173, 45);
            this.accnumview.Name = "accnumview";
            this.accnumview.Size = new System.Drawing.Size(0, 24);
            this.accnumview.TabIndex = 11;
            // 
            // accbalview
            // 
            this.accbalview.AutoSize = true;
            this.accbalview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accbalview.Location = new System.Drawing.Point(173, 69);
            this.accbalview.Name = "accbalview";
            this.accbalview.Size = new System.Drawing.Size(0, 24);
            this.accbalview.TabIndex = 12;
            // 
            // acctypeview
            // 
            this.acctypeview.AutoSize = true;
            this.acctypeview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.acctypeview.Location = new System.Drawing.Point(173, 93);
            this.acctypeview.Name = "acctypeview";
            this.acctypeview.Size = new System.Drawing.Size(0, 24);
            this.acctypeview.TabIndex = 13;
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.Color.PaleVioletRed;
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backbutton.Location = new System.Drawing.Point(387, 300);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(77, 64);
            this.backbutton.TabIndex = 14;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // accdetailsgroupbox
            // 
            this.accdetailsgroupbox.Controls.Add(this.accinterestview);
            this.accdetailsgroupbox.Controls.Add(this.accinteresttext);
            this.accdetailsgroupbox.Controls.Add(this.accnameviewtext);
            this.accdetailsgroupbox.Controls.Add(this.accnumviewtext);
            this.accdetailsgroupbox.Controls.Add(this.acctypeview);
            this.accdetailsgroupbox.Controls.Add(this.accbalviewtext);
            this.accdetailsgroupbox.Controls.Add(this.accbalview);
            this.accdetailsgroupbox.Controls.Add(this.acctypeviewtext);
            this.accdetailsgroupbox.Controls.Add(this.accnumview);
            this.accdetailsgroupbox.Controls.Add(this.accnameview);
            this.accdetailsgroupbox.Location = new System.Drawing.Point(12, 9);
            this.accdetailsgroupbox.Name = "accdetailsgroupbox";
            this.accdetailsgroupbox.Size = new System.Drawing.Size(447, 145);
            this.accdetailsgroupbox.TabIndex = 15;
            this.accdetailsgroupbox.TabStop = false;
            this.accdetailsgroupbox.Text = "Account Details";
            // 
            // accinterestview
            // 
            this.accinterestview.AutoSize = true;
            this.accinterestview.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accinterestview.Location = new System.Drawing.Point(173, 117);
            this.accinterestview.Name = "accinterestview";
            this.accinterestview.Size = new System.Drawing.Size(0, 24);
            this.accinterestview.TabIndex = 16;
            // 
            // accinteresttext
            // 
            this.accinteresttext.AutoSize = true;
            this.accinteresttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accinteresttext.Location = new System.Drawing.Point(7, 117);
            this.accinteresttext.Name = "accinteresttext";
            this.accinteresttext.Size = new System.Drawing.Size(150, 24);
            this.accinteresttext.TabIndex = 15;
            this.accinteresttext.Text = "Account Interest:";
            // 
            // transfergroupbox
            // 
            this.transfergroupbox.Controls.Add(this.sendbutton);
            this.transfergroupbox.Controls.Add(this.amounttextbox);
            this.transfergroupbox.Controls.Add(this.sendtextbox);
            this.transfergroupbox.Controls.Add(this.amountlabel);
            this.transfergroupbox.Controls.Add(this.sendmoneylabel);
            this.transfergroupbox.Location = new System.Drawing.Point(12, 160);
            this.transfergroupbox.Name = "transfergroupbox";
            this.transfergroupbox.Size = new System.Drawing.Size(447, 79);
            this.transfergroupbox.TabIndex = 16;
            this.transfergroupbox.TabStop = false;
            this.transfergroupbox.Text = "Transfer amount";
            // 
            // sendbutton
            // 
            this.sendbutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sendbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.sendbutton.Location = new System.Drawing.Point(273, 15);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(168, 58);
            this.sendbutton.TabIndex = 7;
            this.sendbutton.Text = "SEND";
            this.sendbutton.UseVisualStyleBackColor = false;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // amounttextbox
            // 
            this.amounttextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.amounttextbox.Location = new System.Drawing.Point(163, 45);
            this.amounttextbox.Name = "amounttextbox";
            this.amounttextbox.Size = new System.Drawing.Size(104, 28);
            this.amounttextbox.TabIndex = 6;
            // 
            // sendtextbox
            // 
            this.sendtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sendtextbox.Location = new System.Drawing.Point(163, 15);
            this.sendtextbox.Name = "sendtextbox";
            this.sendtextbox.Size = new System.Drawing.Size(104, 28);
            this.sendtextbox.TabIndex = 5;
            // 
            // amountlabel
            // 
            this.amountlabel.AutoSize = true;
            this.amountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.amountlabel.Location = new System.Drawing.Point(7, 42);
            this.amountlabel.Name = "amountlabel";
            this.amountlabel.Size = new System.Drawing.Size(81, 24);
            this.amountlabel.TabIndex = 4;
            this.amountlabel.Text = "Amount:";
            // 
            // sendmoneylabel
            // 
            this.sendmoneylabel.AutoSize = true;
            this.sendmoneylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sendmoneylabel.Location = new System.Drawing.Point(6, 18);
            this.sendmoneylabel.Name = "sendmoneylabel";
            this.sendmoneylabel.Size = new System.Drawing.Size(151, 24);
            this.sendmoneylabel.TabIndex = 3;
            this.sendmoneylabel.Text = "Send Money To:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 369);
            this.Controls.Add(this.transfergroupbox);
            this.Controls.Add(this.accdetailsgroupbox);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.dobutton);
            this.Controls.Add(this.transactiongroupbox);
            this.Name = "Form3";
            this.Text = "Current Account Transaction";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.transactiongroupbox.ResumeLayout(false);
            this.transactiongroupbox.PerformLayout();
            this.accdetailsgroupbox.ResumeLayout(false);
            this.accdetailsgroupbox.PerformLayout();
            this.transfergroupbox.ResumeLayout(false);
            this.transfergroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox transactiongroupbox;
        private System.Windows.Forms.Label Depositlabel;
        private System.Windows.Forms.Label withdrawlabel;
        private System.Windows.Forms.TextBox deposittextbox;
        private System.Windows.Forms.TextBox withdrawtextbox;
        private System.Windows.Forms.Button dobutton;
        private System.Windows.Forms.Label accnumviewtext;
        private System.Windows.Forms.Label accbalviewtext;
        private System.Windows.Forms.Label accnameviewtext;
        private System.Windows.Forms.Label acctypeviewtext;
        private System.Windows.Forms.Label accnameview;
        private System.Windows.Forms.Label accnumview;
        private System.Windows.Forms.Label accbalview;
        private System.Windows.Forms.Label acctypeview;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.GroupBox accdetailsgroupbox;
        private System.Windows.Forms.Label accinteresttext;
        private System.Windows.Forms.Label accinterestview;
        private System.Windows.Forms.GroupBox transfergroupbox;
        private System.Windows.Forms.TextBox amounttextbox;
        private System.Windows.Forms.TextBox sendtextbox;
        private System.Windows.Forms.Label amountlabel;
        private System.Windows.Forms.Label sendmoneylabel;
        private System.Windows.Forms.Button sendbutton;
    }
}