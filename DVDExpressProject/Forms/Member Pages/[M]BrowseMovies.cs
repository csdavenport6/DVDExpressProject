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
    public partial class _M_BrowseMovies : Form
    {
        private _M_AccountInfo mAccInfo;

        public _M_AccountInfo MAccInfo
        {
            get { return mAccInfo; }
            set { mAccInfo = value; }
        }

        public _M_BrowseMovies()
        {
            InitializeComponent();
        }

        private void _M_BrowseMovies_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
