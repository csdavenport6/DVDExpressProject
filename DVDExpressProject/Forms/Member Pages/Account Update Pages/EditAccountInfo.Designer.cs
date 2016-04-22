namespace DVDExpressProject.Forms.Member_Pages.Account_Update_Pages
{
    partial class EditAccountInfo
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
            this.DOBEntry = new System.Windows.Forms.DateTimePicker();
            this.LastNameEntry = new System.Windows.Forms.TextBox();
            this.FirstNameEntry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UsernameEntry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FAQButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // DOBEntry
            // 
            this.DOBEntry.Location = new System.Drawing.Point(153, 288);
            this.DOBEntry.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DOBEntry.Name = "DOBEntry";
            this.DOBEntry.Size = new System.Drawing.Size(301, 26);
            this.DOBEntry.TabIndex = 46;
            // 
            // LastNameEntry
            // 
            this.LastNameEntry.Location = new System.Drawing.Point(153, 243);
            this.LastNameEntry.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.LastNameEntry.Name = "LastNameEntry";
            this.LastNameEntry.Size = new System.Drawing.Size(301, 26);
            this.LastNameEntry.TabIndex = 45;
            // 
            // FirstNameEntry
            // 
            this.FirstNameEntry.Location = new System.Drawing.Point(153, 198);
            this.FirstNameEntry.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.FirstNameEntry.Name = "FirstNameEntry";
            this.FirstNameEntry.Size = new System.Drawing.Size(301, 26);
            this.FirstNameEntry.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "D.O.B.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "First Name";
            // 
            // UsernameEntry
            // 
            this.UsernameEntry.Location = new System.Drawing.Point(153, 343);
            this.UsernameEntry.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.UsernameEntry.Name = "UsernameEntry";
            this.UsernameEntry.Size = new System.Drawing.Size(301, 26);
            this.UsernameEntry.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Username";
            // 
            // SaveChanges
            // 
            this.SaveChanges.Location = new System.Drawing.Point(429, 454);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(204, 94);
            this.SaveChanges.TabIndex = 50;
            this.SaveChanges.Text = "Save Changes";
            this.SaveChanges.UseVisualStyleBackColor = true;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(861, 33);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutButton
            // 
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(74, 29);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FAQButton});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // FAQButton
            // 
            this.FAQButton.Name = "FAQButton";
            this.FAQButton.Size = new System.Drawing.Size(131, 30);
            this.FAQButton.Text = "FAQ";
            this.FAQButton.Click += new System.EventHandler(this.FAQButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVDExpressProject.Properties.Resources.dvdexpress_logo;
            this.pictureBox2.Location = new System.Drawing.Point(51, 35);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(657, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(153, 454);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(204, 89);
            this.CancelButton.TabIndex = 52;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 726);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveChanges);
            this.Controls.Add(this.UsernameEntry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOBEntry);
            this.Controls.Add(this.LastNameEntry);
            this.Controls.Add(this.FirstNameEntry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "EditAccountInfo";
            this.Text = "EditAccountInfo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker DOBEntry;
        private System.Windows.Forms.TextBox LastNameEntry;
        private System.Windows.Forms.TextBox FirstNameEntry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UsernameEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FAQButton;
        private System.Windows.Forms.Button CancelButton;
    }
}