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
    public partial class _M_Search : Form
    {
        private _M_AccountInfo mAccInfo;

        public _M_AccountInfo MAccInfo
        {
            get { return mAccInfo; }
            set { mAccInfo = value; }
        }

        public _M_Search()
        {
            InitializeComponent();
        }

        private void _M_Search_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }


        //Browse Button
        private void button5_Click(object sender, EventArgs e)
        {
            _M_BrowseMovies browse = new _M_BrowseMovies();
            browse.Show();
            //browse.MBrowse = this;
        }

        //Cart Button
        private void button1_Click(object sender, EventArgs e)
        {
            _M_ViewCart cart = new _M_ViewCart();
            cart.Show();
            //cart.MAccInfo = this;
        }

        //Wishlist Button
        private void button2_Click(object sender, EventArgs e)
        {
            _M_ViewWishlists wishlist = new _M_ViewWishlists();
            wishlist.Show();
            //wishlist.MAccInfo = this;
        }

        //Account Info Button
        private void button3_Click(object sender, EventArgs e)
        {
            _M_AccountInfo account = new _M_AccountInfo();
            account.Show();
        }
    }
}
