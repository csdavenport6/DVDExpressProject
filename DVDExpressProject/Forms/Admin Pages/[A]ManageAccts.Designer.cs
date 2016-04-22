namespace DVDExpressProject.Forms.Admin_Pages
{
    partial class _A_ManageAccts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_A_ManageAccts));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FAQButton = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AccountReportButton = new System.Windows.Forms.Button();
            this.TransactionReportButton = new System.Windows.Forms.Button();
            this.AccountListing = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "About";
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(92, 36);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FAQButton});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // FAQButton
            // 
            this.FAQButton.Name = "FAQButton";
            this.FAQButton.Size = new System.Drawing.Size(135, 36);
            this.FAQButton.Text = "FAQ";
            this.FAQButton.Click += new System.EventHandler(this.FAQButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(180, 460);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(352, 79);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update Customer Account";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // AccountReportButton
            // 
            this.AccountReportButton.Location = new System.Drawing.Point(180, 350);
            this.AccountReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccountReportButton.Name = "AccountReportButton";
            this.AccountReportButton.Size = new System.Drawing.Size(352, 79);
            this.AccountReportButton.TabIndex = 3;
            this.AccountReportButton.Text = "Customer Account Report";
            this.AccountReportButton.UseVisualStyleBackColor = true;
            // 
            // TransactionReportButton
            // 
            this.TransactionReportButton.Location = new System.Drawing.Point(560, 350);
            this.TransactionReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TransactionReportButton.Name = "TransactionReportButton";
            this.TransactionReportButton.Size = new System.Drawing.Size(352, 79);
            this.TransactionReportButton.TabIndex = 4;
            this.TransactionReportButton.Text = "Produce Transaction Report";
            this.TransactionReportButton.UseVisualStyleBackColor = true;
            // 
            // AccountListing
            // 
            this.AccountListing.FormattingEnabled = true;
            this.AccountListing.ItemHeight = 25;
            this.AccountListing.Location = new System.Drawing.Point(200, 108);
            this.AccountListing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccountListing.Name = "AccountListing";
            this.AccountListing.Size = new System.Drawing.Size(680, 179);
            this.AccountListing.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(560, 460);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(352, 79);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Update";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(792, 569);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(196, 62);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // _A_ManageAccts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 663);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AccountListing);
            this.Controls.Add(this.TransactionReportButton);
            this.Controls.Add(this.AccountReportButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "_A_ManageAccts";
            this.Text = "_A_ManageAccts";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button AccountReportButton;
        private System.Windows.Forms.Button TransactionReportButton;
        private System.Windows.Forms.ListBox AccountListing;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ToolStripMenuItem FAQButton;
    }
}