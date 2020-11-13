using System;
using System.Drawing;
using System.Windows.Media;
using System.Collections.Generic;
using Color = System.Drawing.Color;

namespace Assignment1
{
    partial class Form1
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
            this.currentradiobutton = new System.Windows.Forms.RadioButton();
            this.acctypegroupbox = new System.Windows.Forms.GroupBox();
            this.savingradiobutton = new System.Windows.Forms.RadioButton();
            this.infogroupbox = new System.Windows.Forms.GroupBox();
            this.accountnumberlabel = new System.Windows.Forms.Label();
            this.accountnamelabel = new System.Windows.Forms.Label();
            this.numbertextbox = new System.Windows.Forms.TextBox();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.createbutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.acctypegroupbox.SuspendLayout();
            this.infogroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentradiobutton
            // 
            this.currentradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.currentradiobutton.Location = new System.Drawing.Point(21, 23);
            this.currentradiobutton.Name = "currentradiobutton";
            this.currentradiobutton.Size = new System.Drawing.Size(154, 35);
            this.currentradiobutton.TabIndex = 1;
            this.currentradiobutton.TabStop = true;
            this.currentradiobutton.Text = "Current Account";
            this.currentradiobutton.UseVisualStyleBackColor = true;
            // 
            // acctypegroupbox
            // 
            this.acctypegroupbox.Controls.Add(this.currentradiobutton);
            this.acctypegroupbox.Controls.Add(this.savingradiobutton);
            this.acctypegroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.acctypegroupbox.Location = new System.Drawing.Point(12, 162);
            this.acctypegroupbox.Name = "acctypegroupbox";
            this.acctypegroupbox.Size = new System.Drawing.Size(232, 119);
            this.acctypegroupbox.TabIndex = 2;
            this.acctypegroupbox.TabStop = false;
            this.acctypegroupbox.Text = "Select Account Type";
            // 
            // savingradiobutton
            // 
            this.savingradiobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.savingradiobutton.Location = new System.Drawing.Point(21, 64);
            this.savingradiobutton.Name = "savingradiobutton";
            this.savingradiobutton.Size = new System.Drawing.Size(154, 35);
            this.savingradiobutton.TabIndex = 0;
            this.savingradiobutton.TabStop = true;
            this.savingradiobutton.Text = "Saving Account";
            this.savingradiobutton.UseVisualStyleBackColor = true;
            // 
            // infogroupbox
            // 
            this.infogroupbox.Controls.Add(this.accountnumberlabel);
            this.infogroupbox.Controls.Add(this.accountnamelabel);
            this.infogroupbox.Controls.Add(this.numbertextbox);
            this.infogroupbox.Controls.Add(this.nametextbox);
            this.infogroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.infogroupbox.Location = new System.Drawing.Point(12, 12);
            this.infogroupbox.Name = "infogroupbox";
            this.infogroupbox.Size = new System.Drawing.Size(447, 144);
            this.infogroupbox.TabIndex = 3;
            this.infogroupbox.TabStop = false;
            this.infogroupbox.Text = "Account Information ";
            // 
            // accountnumberlabel
            // 
            this.accountnumberlabel.AutoSize = true;
            this.accountnumberlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accountnumberlabel.Location = new System.Drawing.Point(6, 85);
            this.accountnumberlabel.Name = "accountnumberlabel";
            this.accountnumberlabel.Size = new System.Drawing.Size(154, 24);
            this.accountnumberlabel.TabIndex = 3;
            this.accountnumberlabel.Text = "Account Number";
            // 
            // accountnamelabel
            // 
            this.accountnamelabel.AutoSize = true;
            this.accountnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.accountnamelabel.Location = new System.Drawing.Point(6, 37);
            this.accountnamelabel.Name = "accountnamelabel";
            this.accountnamelabel.Size = new System.Drawing.Size(136, 24);
            this.accountnamelabel.TabIndex = 2;
            this.accountnamelabel.Text = "Account Name";
            // 
            // numbertextbox
            // 
            this.numbertextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numbertextbox.Location = new System.Drawing.Point(184, 85);
            this.numbertextbox.Name = "numbertextbox";
            this.numbertextbox.Size = new System.Drawing.Size(242, 28);
            this.numbertextbox.TabIndex = 1;
            // 
            // nametextbox
            // 
            this.nametextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nametextbox.Location = new System.Drawing.Point(184, 37);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(242, 28);
            this.nametextbox.TabIndex = 0;
            // 
            // createbutton
            // 
            this.createbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.createbutton.Location = new System.Drawing.Point(250, 162);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(209, 35);
            this.createbutton.TabIndex = 4;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchbutton.Location = new System.Drawing.Point(250, 203);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(209, 35);
            this.searchbutton.TabIndex = 5;
            this.searchbutton.Text = "Search Window";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.BackColor = System.Drawing.Color.Crimson;
            this.exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.exitbutton.ForeColor = System.Drawing.Color.White;
            this.exitbutton.Location = new System.Drawing.Point(250, 244);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(209, 35);
            this.exitbutton.TabIndex = 6;
            this.exitbutton.Text = "Exit";
            this.exitbutton.UseVisualStyleBackColor = false;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 288);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.createbutton);
            this.Controls.Add(this.infogroupbox);
            this.Controls.Add(this.acctypegroupbox);
            this.Name = "Form1";
            this.Text = "Create Bank Account ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.acctypegroupbox.ResumeLayout(false);
            this.infogroupbox.ResumeLayout(false);
            this.infogroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton currentradiobutton;
        private System.Windows.Forms.GroupBox acctypegroupbox;
        private System.Windows.Forms.GroupBox infogroupbox;
        private System.Windows.Forms.Label accountnamelabel;
        private System.Windows.Forms.TextBox numbertextbox;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label accountnumberlabel;
        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.RadioButton savingradiobutton;
    }
}

