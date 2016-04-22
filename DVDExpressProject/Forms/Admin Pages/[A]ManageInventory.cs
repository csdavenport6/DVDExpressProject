using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDExpressProject.Forms.Admin_Pages
{
    public partial class _A_ManageInventory : Form
    {
        public Member adminAccount { get; set; }
        private AdminMainPage adminPage;

        public AdminMainPage AdminPage
        {
            get { return adminPage; }
            set { adminPage = value; }
        }

        public _A_ManageInventory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void _A_ManageInventory_Load(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            adminPage.Show();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to DVDExpress. Created by Connor, Bobby, Joseph, and James.");
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admins are able to manage the inventory of DVDExpress.");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddMovie addMoviePage = new AddMovie();
            addMoviePage.Show();
        }
    }
}
