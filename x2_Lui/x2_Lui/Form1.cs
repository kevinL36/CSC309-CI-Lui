using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x2_Lui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOldBalance.Text = "";
            txtBookCredit.Text = "";
            txtBookPurchase.Text = "";
            txtCreditTotal.Text = "";
            txtPurchaseTotal.Text = "";
            txtNewBalance.Text = "";
            txtAmountDue.Text = "";

            txtOldBalance.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal BOOK_PURCHASE_PRICE = 3.99m;
                const decimal BOOK_TRADE_CREDIT = 1.00m;

                decimal OLD_CREDIT,
                        BOOKS_TRADED,
                        BOOKS_PURCHASED,
                        CREDIT_AVAILABLE,
                        PURCHASE_TOTAL,
                        NEW_CREDIT,
                        AMOUNT_DUE;

                OLD_CREDIT = decimal.Parse(txtOldBalance.Text);
                BOOKS_TRADED = decimal.Parse(txtBookCredit.Text);
                BOOKS_PURCHASED = decimal.Parse(txtBookPurchase.Text);
                CREDIT_AVAILABLE = OLD_CREDIT + (BOOKS_TRADED * BOOK_TRADE_CREDIT);
                PURCHASE_TOTAL = decimal.Parse(txtBookPurchase.Text) * BOOK_PURCHASE_PRICE;
                NEW_CREDIT = CREDIT_AVAILABLE - PURCHASE_TOTAL;
                AMOUNT_DUE = (CREDIT_AVAILABLE - PURCHASE_TOTAL) * -1;

                if (NEW_CREDIT > 0)
                {
                    txtNewBalance.Text = NEW_CREDIT.ToString("c");
                }
                else
                {
                    txtNewBalance.Text = "none";
                }
                if (AMOUNT_DUE > 0)
                {
                    txtAmountDue.Text = AMOUNT_DUE.ToString("c");
                }
                else
                {
                    txtAmountDue.Text = "none";
                }
                txtCreditTotal.Text = CREDIT_AVAILABLE.ToString("c");
                txtPurchaseTotal.Text = PURCHASE_TOTAL.ToString("c");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
