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

namespace DVDExpressProject.Forms.Login_and_Main_Pages
{
    public partial class CreateAcct : Form
    {
        public CreateAcct()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CreateAcct_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the required information to create a new account.");
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to DVDExpress. Created by Connor, Bobby, Joseph, and James.");
        }

        private void ConfirmProfileButton_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();

            Table<Account> Accounts = db.GetTable<Account>();
            Table<Login> Logins = db.GetTable<Login>();
            Table<Member> Members = db.GetTable<Member>();
            //make sure entered passwords match
            if (PasswordEntry.Text != ConfirmPassword.Text)
            {
                MessageBox.Show("Error: Passwords don't match");
                return;
            }
            //generate new IDs
            var acctIDQuery =
                from account in Accounts
                orderby account.AccountID descending
                select account.AccountID;

            int newAcctID = acctIDQuery.First() + 1;

            var memIDQuery =
                from member in Members
                orderby member.MemberID descending
                select member.MemberID;

            int newMemID = memIDQuery.First() + 1;
            //make sure new username isn't taken
            var checkUsername =
                from login in Logins
                where login.Username == UsernameEntry.Text
                select login;

            if (checkUsername.Any())
            {
                MessageBox.Show("Error: Username is already taken");
                return;
            }
            //generate new member, account, and login
            int newZIP;
            int.TryParse(ZIPEntry.Text, out newZIP);


            Member newMem = new Member
            {
                MemberID = newMemID,
                AccountID = newAcctID,
                FirstName = FirstNameEntry.Text,
                LastName = LastNameEntry.Text,
                DOB = DOBEntry.Value,
                Address1 = Address1Entry.Text,
                Address2 = "",
                City = CityEntry.Text,
                State = StateEntry.Text,
                Zip = newZIP,
                Phone = PhoneEntry.Text,
            };

            Login newLogin = new Login
            {
                Username = UsernameEntry.Text,
                MemberID = newMemID,
                Password = ConfirmPassword.Text,
                IsAdmin = false,
            };

            long newCardNo;
            long.TryParse(CreditCardEntry.Text, out newCardNo);
            int newCVV;
            int.TryParse(CCNEntry.Text, out newCVV);

            Account newAcct = new Account
            {
                AccountID = newAcctID,
                MemStatus = "Bronze",
                Balance = 0,
                CardNumber = newCardNo,
                PaymentType = true,
                ExpirationDate = null,
                CVV = newCVV,     
            };
            //submit changes to DB
            db.Accounts.InsertOnSubmit(newAcct);
            db.Logins.InsertOnSubmit(newLogin);
            db.Members.InsertOnSubmit(newMem);
            db.SubmitChanges();
            MessageBox.Show("Account Created!");
        }
    }
}
