namespace DVDExpressProject.Forms.Admin_Pages
{
    partial class TransReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TransactionList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionList)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionList
            // 
            this.TransactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionList.Location = new System.Drawing.Point(3, 0);
            this.TransactionList.Name = "TransactionList";
            this.TransactionList.RowTemplate.Height = 33;
            this.TransactionList.Size = new System.Drawing.Size(989, 713);
            this.TransactionList.TabIndex = 0;
            this.TransactionList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionList_CellContentClick);
            // 
            // TransReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 711);
            this.Controls.Add(this.TransactionList);
            this.Name = "TransReport";
            this.Text = "TransReport";
            this.Load += new System.EventHandler(this.TransReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TransactionList;
    }
}