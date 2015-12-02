namespace x2_Lui
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
            this.lblPurchase = new System.Windows.Forms.Label();
            this.lblCreditscount = new System.Windows.Forms.Label();
            this.lblBalanceinfo = new System.Windows.Forms.Label();
            this.txtBookPurchase = new System.Windows.Forms.TextBox();
            this.txtBookCredit = new System.Windows.Forms.TextBox();
            this.txtOldBalance = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBalanceRemaining = new System.Windows.Forms.Label();
            this.txtCreditTotal = new System.Windows.Forms.TextBox();
            this.txtPurchaseTotal = new System.Windows.Forms.TextBox();
            this.txtNewBalance = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.txtAmountDue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Location = new System.Drawing.Point(50, 64);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(228, 13);
            this.lblPurchase.TabIndex = 11;
            this.lblPurchase.Text = "Enter the number of books you are purchasing:";
            // 
            // lblCreditscount
            // 
            this.lblCreditscount.AutoSize = true;
            this.lblCreditscount.Location = new System.Drawing.Point(15, 38);
            this.lblCreditscount.Name = "lblCreditscount";
            this.lblCreditscount.Size = new System.Drawing.Size(263, 13);
            this.lblCreditscount.TabIndex = 10;
            this.lblCreditscount.Text = "Enter the number of books you are turning in for credit:";
            // 
            // lblBalanceinfo
            // 
            this.lblBalanceinfo.Location = new System.Drawing.Point(15, 12);
            this.lblBalanceinfo.Name = "lblBalanceinfo";
            this.lblBalanceinfo.Size = new System.Drawing.Size(275, 42);
            this.lblBalanceinfo.TabIndex = 9;
            this.lblBalanceinfo.Text = "Enter the amount of store credit you have on balance:";
            // 
            // txtBookPurchase
            // 
            this.txtBookPurchase.Location = new System.Drawing.Point(305, 60);
            this.txtBookPurchase.Name = "txtBookPurchase";
            this.txtBookPurchase.Size = new System.Drawing.Size(100, 20);
            this.txtBookPurchase.TabIndex = 3;
            // 
            // txtBookCredit
            // 
            this.txtBookCredit.Location = new System.Drawing.Point(305, 34);
            this.txtBookCredit.Name = "txtBookCredit";
            this.txtBookCredit.Size = new System.Drawing.Size(100, 20);
            this.txtBookCredit.TabIndex = 2;
            // 
            // txtOldBalance
            // 
            this.txtOldBalance.Location = new System.Drawing.Point(305, 8);
            this.txtOldBalance.Name = "txtOldBalance";
            this.txtOldBalance.Size = new System.Drawing.Size(100, 20);
            this.txtOldBalance.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(258, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(177, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 40);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(96, 213);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 40);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Process Transaction";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(168, 110);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(110, 13);
            this.lblCredit.TabIndex = 15;
            this.lblCredit.Text = "Total Available Credit:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(156, 140);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Today\'s Total Purchase:";
            // 
            // lblBalanceRemaining
            // 
            this.lblBalanceRemaining.AutoSize = true;
            this.lblBalanceRemaining.Location = new System.Drawing.Point(174, 166);
            this.lblBalanceRemaining.Name = "lblBalanceRemaining";
            this.lblBalanceRemaining.Size = new System.Drawing.Size(104, 13);
            this.lblBalanceRemaining.TabIndex = 17;
            this.lblBalanceRemaining.Text = "New Credit Balance:";
            // 
            // txtCreditTotal
            // 
            this.txtCreditTotal.Location = new System.Drawing.Point(305, 107);
            this.txtCreditTotal.Name = "txtCreditTotal";
            this.txtCreditTotal.ReadOnly = true;
            this.txtCreditTotal.Size = new System.Drawing.Size(100, 20);
            this.txtCreditTotal.TabIndex = 18;
            this.txtCreditTotal.TabStop = false;
            // 
            // txtPurchaseTotal
            // 
            this.txtPurchaseTotal.Location = new System.Drawing.Point(305, 133);
            this.txtPurchaseTotal.Name = "txtPurchaseTotal";
            this.txtPurchaseTotal.ReadOnly = true;
            this.txtPurchaseTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPurchaseTotal.TabIndex = 19;
            this.txtPurchaseTotal.TabStop = false;
            // 
            // txtNewBalance
            // 
            this.txtNewBalance.Location = new System.Drawing.Point(305, 159);
            this.txtNewBalance.Name = "txtNewBalance";
            this.txtNewBalance.ReadOnly = true;
            this.txtNewBalance.Size = new System.Drawing.Size(100, 20);
            this.txtNewBalance.TabIndex = 20;
            this.txtNewBalance.TabStop = false;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(209, 192);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(69, 13);
            this.lblAmountDue.TabIndex = 21;
            this.lblAmountDue.Text = "Amount Due:";
            // 
            // txtAmountDue
            // 
            this.txtAmountDue.Location = new System.Drawing.Point(305, 185);
            this.txtAmountDue.Name = "txtAmountDue";
            this.txtAmountDue.ReadOnly = true;
            this.txtAmountDue.Size = new System.Drawing.Size(100, 20);
            this.txtAmountDue.TabIndex = 22;
            this.txtAmountDue.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 265);
            this.Controls.Add(this.txtAmountDue);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.txtNewBalance);
            this.Controls.Add(this.txtPurchaseTotal);
            this.Controls.Add(this.txtCreditTotal);
            this.Controls.Add(this.lblBalanceRemaining);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPurchase);
            this.Controls.Add(this.lblCreditscount);
            this.Controls.Add(this.lblBalanceinfo);
            this.Controls.Add(this.txtBookPurchase);
            this.Controls.Add(this.txtBookCredit);
            this.Controls.Add(this.txtOldBalance);
            this.Name = "Form1";
            this.Text = "Bargain Books Credit Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Label lblCreditscount;
        private System.Windows.Forms.Label lblBalanceinfo;
        private System.Windows.Forms.TextBox txtBookPurchase;
        private System.Windows.Forms.TextBox txtBookCredit;
        private System.Windows.Forms.TextBox txtOldBalance;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBalanceRemaining;
        private System.Windows.Forms.TextBox txtCreditTotal;
        private System.Windows.Forms.TextBox txtPurchaseTotal;
        private System.Windows.Forms.TextBox txtNewBalance;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.TextBox txtAmountDue;
    }
}

