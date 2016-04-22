namespace DVDExpressProject.Forms.Admin_Pages
{
    partial class CustAcctReport
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
            this.components = new System.ComponentModel.Container();
            this.s2T5DataSet = new DVDExpressProject.S2T5DataSet();
            this.s2T5DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s2T5DataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MemberList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.s2T5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2T5DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2T5DataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberList)).BeginInit();
            this.SuspendLayout();
            // 
            // s2T5DataSet
            // 
            this.s2T5DataSet.DataSetName = "S2T5DataSet";
            this.s2T5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s2T5DataSetBindingSource
            // 
            this.s2T5DataSetBindingSource.DataSource = this.s2T5DataSet;
            this.s2T5DataSetBindingSource.Position = 0;
            // 
            // s2T5DataSetBindingSource1
            // 
            this.s2T5DataSetBindingSource1.DataSource = this.s2T5DataSet;
            this.s2T5DataSetBindingSource1.Position = 0;
            // 
            // MemberList
            // 
            this.MemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberList.Location = new System.Drawing.Point(12, 12);
            this.MemberList.Name = "MemberList";
            this.MemberList.RowTemplate.Height = 28;
            this.MemberList.Size = new System.Drawing.Size(862, 721);
            this.MemberList.TabIndex = 0;
            // 
            // CustAcctReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 745);
            this.Controls.Add(this.MemberList);
            this.Name = "CustAcctReport";
            this.Text = "CustAcctReport";
            this.Load += new System.EventHandler(this.CustAcctReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s2T5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2T5DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2T5DataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemberList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private S2T5DataSet s2T5DataSet;
        private System.Windows.Forms.BindingSource s2T5DataSetBindingSource;
        private System.Windows.Forms.BindingSource s2T5DataSetBindingSource1;
        private System.Windows.Forms.DataGridView MemberList;
    }
}