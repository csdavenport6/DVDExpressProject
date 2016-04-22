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
    public partial class TransReport : Form
    {
        public TransReport()
        {
            InitializeComponent();
        }

        private void TransReport_Load(object sender, EventArgs e)
        {

            DVDExpressDataContext db = new DVDExpressDataContext();
            Table<Transaction> Transactions = db.GetTable<Transaction>();

            var getAllTransactions =
                from transaction in Transactions
                select transaction;

            DataTable transactionList = new DataTable();
            transactionList.Columns.Add("Transaction ID");
            transactionList.Columns.Add("Account ID");
            transactionList.Columns.Add("Movie ID");
            transactionList.Columns.Add("Reward ID");
            transactionList.Columns.Add("Rent Date");
            transactionList.Columns.Add("Due Date");
            transactionList.Columns.Add("Total");
           
            foreach (Transaction transaction in getAllTransactions)
            {
                transactionList.Rows.Add(transaction.TransactionID, transaction.AccountID, transaction.MovieID, transaction.RewardID, transaction.RentDate, transaction.DueDate, transaction.Total);
            }
            TransactionList.DataSource = transactionList;
        }

        private void TransactionList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
