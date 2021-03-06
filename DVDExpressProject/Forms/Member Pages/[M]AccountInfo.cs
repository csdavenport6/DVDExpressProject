﻿
using DVDExpressProject.Forms.Member_Pages.Account_Update_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDExpressProject.Forms.Member_Pages
{
    public partial class _M_AccountInfo : Form
    {
        public Member userAccount { get; set; }
        public _M_AccountInfo()
        {
            InitializeComponent();
        }

        //Search Button
        private void button4_Click(object sender, EventArgs e)
        {
            _M_Search search = new _M_Search();
            search.userAccount = this.userAccount;
            search.Show();
            this.Hide();
            
        }

        //Browse Button
        private void button5_Click(object sender, EventArgs e)
        {
            _M_BrowseMovies browse = new _M_BrowseMovies();
            browse.userAccount = this.userAccount;
            browse.Show();
            this.Hide();
            
        }

        //Cart Button
        private void button1_Click(object sender, EventArgs e)
        {
            _M_ViewCart cart = new _M_ViewCart();
            cart.userAccount = this.userAccount;
            cart.Show();
            this.Hide();
            
        }

        //Wishlist Button
        private void button2_Click(object sender, EventArgs e)
        {
            _M_ViewWishlists wishlist = new _M_ViewWishlists();
            wishlist.userAccount = this.userAccount;
            wishlist.Show();
            this.Hide();
            
        }

        private void EditAccountOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditAccountOptions.SelectedItem == "Change Password")
            {
                ChangePassword changePasswordPage = new ChangePassword();
                changePasswordPage.userAccount = this.userAccount;
                changePasswordPage.Show();
            }
            if (EditAccountOptions.SelectedItem == "Check Member Status")
            {
                CheckMemberStatus memStatusPage = new CheckMemberStatus();
                memStatusPage.userAccount = this.userAccount;
                memStatusPage.Show();
            }
            if (EditAccountOptions.SelectedItem == "Edit Account Info")
            {
                EditAccountInfo editInfoPage = new EditAccountInfo();
                editInfoPage.userAccount = this.userAccount;
                editInfoPage.Show();
            }
            if (EditAccountOptions.SelectedItem == "Manage Payment Methods")
            {
                ManagePaymentMethods changePaymentPage = new ManagePaymentMethods();
                changePaymentPage.userAccount = this.userAccount;
                changePaymentPage.Show();
            }
            if (EditAccountOptions.SelectedItem == "Update Address")
            {
                UpdateAddress updateAddressPage = new UpdateAddress();
                updateAddressPage.userAccount = this.userAccount;
                updateAddressPage.Show();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to DVDExpress. Created by Connor, Bobby, Joseph, and James.");
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form allows you to edit your account information. Please keep this information current as possible.");
        }
    }
}
