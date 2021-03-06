﻿using System;
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
    public partial class UpdateAddress : Form
    {
        public Member userAccount { get; set; }
        public UpdateAddress()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
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
            MessageBox.Show("This form lets the user to keep their address information current. Without a current address they may never recieve their movies.");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Member> Members = db.GetTable<Member>();

            var query =
                from member in Members
                where member.MemberID == userAccount.MemberID
                select member;

            int newZIP;
            int.TryParse(ZIPEntry.Text, out newZIP);

            foreach (Member member in query)
            {
                if (Address1Text.Text.Any())
                    member.Address1 = Address1Text.Text;
                if (Address2Text.Text.Any())
                    member.Address2 = Address2Text.Text;
                if (CityText.Text.Any())
                    member.City = CityText.Text;
                if (StateEntry.Text.Any())
                    member.State = StateEntry.Text;
                if (ZIPEntry.Text.Any())
                    member.Zip = newZIP;

            }
            db.SubmitChanges();
            MessageBox.Show("Address updated!");

        }            
    }
}
