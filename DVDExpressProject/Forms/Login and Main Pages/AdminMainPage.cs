using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDExpressProject.Forms.Admin_Pages;

namespace DVDExpressProject.Forms
{
    public partial class AdminMainPage : Form
    {
        public Member adminAccount { get; set; }
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void ManageMemAcc_Click(object sender, EventArgs e)
        {
            _A_ManageAccts manageMemAcc = new _A_ManageAccts();
            manageMemAcc.Show();
            manageMemAcc.AdminPage = this;
            this.Hide();
        }

        private void InventManage_Click(object sender, EventArgs e)
        {
            _A_ManageInventory manageInvent = new _A_ManageInventory();
            manageInvent.Show();
            manageInvent.AdminPage = this;
            this.Hide();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to DVDExpress. Created by Connor, Bobby, Joseph, and James.");
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This form allows the admin to enter into either the manage accounts page, or the manage inventory page.");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
