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
    public partial class ChangePassword : Form
    {
        public Member userAccount { get; set; }
        private _M_AccountInfo mAccInfo;

        public _M_AccountInfo MAccInfo
        {
            get { return mAccInfo; }
            set { mAccInfo = value; }
        }

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to DVDExpress. Created by Connor, Bobby, Joseph, and James.");
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can change your password. Type your old password followed by your new password twice as verification.");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string newPassword = ConfirmPasswordEntry.Text;
            string oldPassword = OldPasswordEntry.Text;

            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Login> Logins = db.GetTable<Login>();

            if (newPassword != NewPasswordEntry.Text)
            {
                MessageBox.Show("Error: New passwords don't match.");
                return;
            }

            var query =
                from login in Logins
                where login.MemberID == userAccount.MemberID
                select login;
            
            foreach(Login login in query)
            {
                if (login.Password == oldPassword)
                {
                    login.Password = newPassword;
                }
                else
                {
                    MessageBox.Show("Error: Old password incorrect.");
                    return;
                }
            }
            db.SubmitChanges();
            MessageBox.Show("Password Updated!");
        }

        private void ReturnButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
