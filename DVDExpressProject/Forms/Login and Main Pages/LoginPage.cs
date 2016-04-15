using DVDExpressProject.Forms.Member_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
           _M_AccountInfo mAccInfo = new _M_AccountInfo();
           mAccInfo.Show();
           MessageBox.Show("Login Succesful");
           this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
