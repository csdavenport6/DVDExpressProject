﻿using System;
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
    public partial class _M_ViewCart : Form
    {
        private _M_AccountInfo mAccInfo;

        public _M_AccountInfo MAccInfo
        {
            get { return mAccInfo; }
            set { mAccInfo = value; }
        }
        public _M_ViewCart()
        {
            InitializeComponent();
        }

        private void _M_ViewCart_Load(object sender, EventArgs e)
        {

        }
    }
}
