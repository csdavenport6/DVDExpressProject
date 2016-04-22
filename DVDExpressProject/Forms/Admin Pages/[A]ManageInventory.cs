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

        private void EditButton_Click(object sender, EventArgs e)
        {
            UpdateMovie updateMoviePage = new UpdateMovie();
            updateMoviePage.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteMovie deleteMoviePage = new DeleteMovie();
            deleteMoviePage.Show();
        }

        private void ViewInventoryButton_Click(object sender, EventArgs e)
        {
            MovieReport movieReport = new MovieReport();
            movieReport.Show();
        }
    }
}
