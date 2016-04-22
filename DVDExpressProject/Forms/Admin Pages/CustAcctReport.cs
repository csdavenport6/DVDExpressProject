using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDExpressProject.Forms.Admin_Pages
{
    public partial class CustAcctReport : Form
    {
        public CustAcctReport()
        {
            InitializeComponent();
        }

        private void CustAcctReport_Load(object sender, EventArgs e)
        {
            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Member> Members = db.GetTable<Member>();

            var getAllMembers =
                from member in Members
                select member;

            DataTable memberList = new DataTable();
            memberList.Columns.Add("Member ID");
            memberList.Columns.Add("Account ID");
            memberList.Columns.Add("First Name");
            memberList.Columns.Add("Last Name");
            memberList.Columns.Add("DOB");
            memberList.Columns.Add("Address 1");
            memberList.Columns.Add("Address 2");
            memberList.Columns.Add("City");
            memberList.Columns.Add("State");
            memberList.Columns.Add("ZIP");
            memberList.Columns.Add("Phone");

            foreach(Member member in getAllMembers)
            {
                memberList.Rows.Add(member.MemberID, member.AccountID, member.FirstName, member.LastName, member.DOB, member.Address1, member.Address2, member.City, member.State, member.Zip, member.Phone);
            }
            MemberList.DataSource = memberList;
        }
    }
}
