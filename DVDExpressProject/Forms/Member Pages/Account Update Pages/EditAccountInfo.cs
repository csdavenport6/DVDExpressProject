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
    public partial class EditAccountInfo : Form
    {
        public Member userAccount { get; set; }
        public EditAccountInfo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
            MessageBox.Show("This form allows the user to edit their name, DOB, and account username.");
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Member> Members = db.GetTable<Member>();
            Table<Login> Logins = db.GetTable<Login>();

            var memQuery =
                from member in Members
                where member.MemberID == userAccount.MemberID
                select member;

            var loginQuery =
                from login in Logins
                where login.MemberID == userAccount.MemberID
                select login;
            //make sure new username isn't already taken
            var checkUsername =
                from login in Logins
                where login.Username == UsernameEntry.Text
                select login;

            if (checkUsername.Any() || !UsernameEntry.Text.Any())
            {
                MessageBox.Show("Error: Username is already taken, or the field was left blank.");
                return;
            }
            //update stuff
            foreach (Member member in memQuery)
            {
                if (FirstNameEntry.Text.Any())
                {
                    member.FirstName = FirstNameEntry.Text;
                }
                if (LastNameEntry.Text.Any())
                {
                    member.LastName = LastNameEntry.Text;
                }

                member.DOB = DOBEntry.Value;
            }
            foreach (Login login in loginQuery)
            {
                Login newLogin = new Login
                {
                    Username = UsernameEntry.Text,
                    MemberID = userAccount.MemberID,
                    Password = login.Password,
                    IsAdmin = login.IsAdmin
                };
                db.Logins.InsertOnSubmit(newLogin);
                db.Logins.DeleteOnSubmit(login);
            }
            db.SubmitChanges();
            MessageBox.Show("Account information updated!");
        }
    }
}
