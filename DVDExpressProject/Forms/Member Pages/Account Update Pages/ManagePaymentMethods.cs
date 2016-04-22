using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDExpressProject.Forms.Member_Pages.Account_Update_Pages
{
    public partial class ManagePaymentMethods : Form
    {
        public Member userAccount { get; set; }
        public ManagePaymentMethods()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to DVDExpress. Created by Connor, Bobby, Joseph, and James.");
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form allows the user to keep their payment methods current in order to keep membership from lapsing.");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Account> Accounts = db.GetTable<Account>();

            var query =
                from account in Accounts
                where account.AccountID == userAccount.AccountID
                select account;

            long newCardNo;
            long.TryParse(CardNumberText.Text, out newCardNo);

            int newCVV;
            int.TryParse(CVVText.Text, out newCVV);

            foreach (Account account in query)
            {
                if (CardNumberText.Text.Any())
                    account.CardNumber = newCardNo;
                if (CVVText.Text.Any())
                    account.CVV = newCVV;
                if (ExpDateEntry.Text.Any())
                    account.ExpirationDate = ExpDateEntry.Text;
            }
            db.SubmitChanges();
            MessageBox.Show("Payment information updated!");
        }
    }
}
