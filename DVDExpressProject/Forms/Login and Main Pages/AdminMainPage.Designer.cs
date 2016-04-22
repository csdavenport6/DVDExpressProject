namespace DVDExpressProject.Forms
{
    partial class AdminMainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainPage));
            this.ManageMemAcc = new System.Windows.Forms.Button();
            this.InventManage = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FAQButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ManageMemAcc
            // 
            this.ManageMemAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageMemAcc.Location = new System.Drawing.Point(147, 329);
            this.ManageMemAcc.Margin = new System.Windows.Forms.Padding(4);
            this.ManageMemAcc.Name = "ManageMemAcc";
            this.ManageMemAcc.Size = new System.Drawing.Size(413, 168);
            this.ManageMemAcc.TabIndex = 3;
            this.ManageMemAcc.Text = "Member Account Management";
            this.ManageMemAcc.UseVisualStyleBackColor = true;
            this.ManageMemAcc.Click += new System.EventHandler(this.ManageMemAcc_Click);
            // 
            // InventManage
            // 
            this.InventManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventManage.Location = new System.Drawing.Point(640, 329);
            this.InventManage.Margin = new System.Windows.Forms.Padding(4);
            this.InventManage.Name = "InventManage";
            this.InventManage.Size = new System.Drawing.Size(413, 168);
            this.InventManage.TabIndex = 4;
            this.InventManage.Text = "Inventory Management";
            this.InventManage.UseVisualStyleBackColor = true;
            this.InventManage.Click += new System.EventHandler(this.InventManage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutButton,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1244, 44);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVDExpressProject.Properties.Resources.dvdexpress_logo;
            this.pictureBox2.Location = new System.Drawing.Point(176, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(877, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnButton.Location = new System.Drawing.Point(413, 635);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(323, 106);
            this.ReturnButton.TabIndex = 14;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // AdminMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 915);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.InventManage);
            this.Controls.Add(this.ManageMemAcc);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminMainPage";
            this.Text = "Admin Main Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ManageMemAcc;
        private System.Windows.Forms.Button InventManage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FAQButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button ReturnButton;
    }
}