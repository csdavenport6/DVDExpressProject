
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
        public _M_AccountInfo()
        {
            InitializeComponent();
        }

        //Search Button
        private void button4_Click(object sender, EventArgs e)
        {
            _M_Search search = new _M_Search();
            search.Show();
            search.MAccInfo = this;
            
        }

        //Browse Button
        private void button5_Click(object sender, EventArgs e)
        {
            _M_BrowseMovies browse = new _M_BrowseMovies();
            browse.Show();
            browse.MAccInfo = this;
            
        }

        //Cart Button
        private void button1_Click(object sender, EventArgs e)
        {
            _M_ViewCart cart = new _M_ViewCart();
            cart.Show();
            cart.MAccInfo = this;
            
        }

        //Wishlist Button
        private void button2_Click(object sender, EventArgs e)
        {
            _M_ViewWishlists wishlist = new _M_ViewWishlists();
            wishlist.Show();
            wishlist.MAccInfo = this;
            
        }

        private void EditAccountOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EditAccountOptions.SelectedItem == "Change Password")
            {
                ChangePassword changePasswordPage = new ChangePassword();
                changePasswordPage.Show();
            }
            if (EditAccountOptions.SelectedItem == "Check Member Status")
            {
                CheckMemberStatus memStatusPage = new CheckMemberStatus();
                memStatusPage.Show();
            }
            if (EditAccountOptions.SelectedItem == "Edit Account Info")
            {
                EditAccountInfo editInfoPage = new EditAccountInfo();
                editInfoPage.Show();
            }
            if (EditAccountOptions.SelectedItem == "Manage Payment Methods")
            {
                ManagePaymentMethods changePaymentPage = new ManagePaymentMethods();
                changePaymentPage.Show();
            }
            if (EditAccountOptions.SelectedItem == "Update Address")
            {
                UpdateAddress updateAddressPage = new UpdateAddress();
                updateAddressPage.Show();
            }
        }
    }
}
