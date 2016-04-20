﻿using DVDExpressProject.Forms.Member_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVDExpressProject.Forms;
using DVDExpressProject.Forms.Login_and_Main_Pages;

namespace DVDExpressProject
{
    public partial class Form1 : Form
    {
        private _M_AccountInfo mAccInfo;
        public _M_AccountInfo MAccInfo
        {
            get { return mAccInfo; }
            set { mAccInfo = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MemberMainPage homePage = new MemberMainPage();
            homePage.Show();
            MessageBox.Show("Login Succesful");
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void CreateAcctButton_Click(object sender, EventArgs e)
        {
            CreateAcct createAcctPage = new CreateAcct();
            createAcctPage.Show();
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            AdminMainPage homePage = new AdminMainPage();
            homePage.Show();
            MessageBox.Show("Login Succesful");
            this.Hide();
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to DVDExpress. Created by Connor, Bobby, Joseph, and James.");
        }

        private void FAQButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please log in with your credentials or create an account. If you are an admin please click 'Admin Login' to be taken to another login form.");
        }
    }
}
