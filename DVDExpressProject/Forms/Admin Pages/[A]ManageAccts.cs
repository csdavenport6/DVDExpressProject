using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDExpressProject.Forms.Login_and_Main_Pages;

namespace DVDExpressProject.Forms.Admin_Pages
{
    public partial class _A_ManageAccts : Form
    {

        private AdminMainPage adminPage;

        public AdminMainPage AdminPage
        {
            get { return adminPage; }
            set { adminPage = value; }
        }

        public _A_ManageAccts()
        {
            InitializeComponent();
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
            MessageBox.Show("Admins can manage customer accounts, and show transaction reports.");
        }

        private void AccountReportButton_Click(object sender, EventArgs e)
        {
            CustAcctReport custAcctReport = new CustAcctReport();
            custAcctReport.Show();
        }

        private void TransReportButton_Click(object sender, EventArgs e)
        {
            TransReport transReport = new TransReport();
            transReport.Show();
        }
    }
}
