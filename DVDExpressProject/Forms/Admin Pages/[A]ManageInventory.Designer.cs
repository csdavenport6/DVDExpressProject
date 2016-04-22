namespace DVDExpressProject.Forms.Admin_Pages
{
    partial class _A_ManageInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_A_ManageInventory));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FAQButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
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
            this.menuStrip1.TabIndex = 0;
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
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(360, 121);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(300, 73);
            this.ViewButton.TabIndex = 2;
            this.ViewButton.Text = "View Current Inventory";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(360, 215);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(300, 73);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit Entries";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(360, 308);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(300, 73);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add Entries";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(360, 402);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(300, 73);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "Delete Entries";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(540, 508);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(300, 73);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Updates";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(188, 508);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(300, 73);
            this.ReturnButton.TabIndex = 7;
            this.ReturnButton.Text = "Return";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // _A_ManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1048, 684);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "_A_ManageInventory";
            this.Text = "_A_ManageInventory";
            this.Load += new System.EventHandler(this._A_ManageInventory_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.ToolStripMenuItem FAQButton;
    }
}