namespace DVDExpressProject.Forms.Admin_Pages
{
    partial class MovieReport
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
            this.MovieList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MovieList)).BeginInit();
            this.SuspendLayout();
            // 
            // MovieList
            // 
            this.MovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieList.Location = new System.Drawing.Point(4, 5);
            this.MovieList.Name = "MovieList";
            this.MovieList.RowTemplate.Height = 33;
            this.MovieList.Size = new System.Drawing.Size(976, 659);
            this.MovieList.TabIndex = 0;
            // 
            // MovieReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 662);
            this.Controls.Add(this.MovieList);
            this.Name = "MovieReport";
            this.Text = "MovieReport";
            this.Load += new System.EventHandler(this.MovieReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovieList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView MovieList;



    }
}