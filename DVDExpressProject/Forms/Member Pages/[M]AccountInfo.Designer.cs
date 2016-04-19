namespace DVDExpressProject.Forms.Member_Pages
{
    partial class _M_AccountInfo
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Change Password");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Check Member Status");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Edit Account Info");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Manage Payment Methods");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Update Address");
            this.SearchMovies = new System.Windows.Forms.Button();
            this.BrowseMovies = new System.Windows.Forms.Button();
            this.ViewCart = new System.Windows.Forms.Button();
            this.ViewWishlist = new System.Windows.Forms.Button();
            this.AccountInfo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountEditList = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchMovies
            // 
            this.SearchMovies.Location = new System.Drawing.Point(4, 2);
            this.SearchMovies.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SearchMovies.Name = "SearchMovies";
            this.SearchMovies.Size = new System.Drawing.Size(304, 125);
            this.SearchMovies.TabIndex = 3;
            this.SearchMovies.Text = "Search Movies";
            this.SearchMovies.UseVisualStyleBackColor = true;
            this.SearchMovies.Click += new System.EventHandler(this.button4_Click);
            // 
            // BrowseMovies
            // 
            this.BrowseMovies.Location = new System.Drawing.Point(4, 131);
            this.BrowseMovies.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BrowseMovies.Name = "BrowseMovies";
            this.BrowseMovies.Size = new System.Drawing.Size(307, 142);
            this.BrowseMovies.TabIndex = 4;
            this.BrowseMovies.Text = "Browse Movies";
            this.BrowseMovies.UseVisualStyleBackColor = true;
            this.BrowseMovies.Click += new System.EventHandler(this.button5_Click);
            // 
            // ViewCart
            // 
            this.ViewCart.Location = new System.Drawing.Point(4, 277);
            this.ViewCart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ViewCart.Name = "ViewCart";
            this.ViewCart.Size = new System.Drawing.Size(304, 125);
            this.ViewCart.TabIndex = 0;
            this.ViewCart.Text = "Cart";
            this.ViewCart.UseVisualStyleBackColor = true;
            this.ViewCart.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewWishlist
            // 
            this.ViewWishlist.Location = new System.Drawing.Point(4, 406);
            this.ViewWishlist.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ViewWishlist.Name = "ViewWishlist";
            this.ViewWishlist.Size = new System.Drawing.Size(304, 125);
            this.ViewWishlist.TabIndex = 1;
            this.ViewWishlist.Text = "Wishlist";
            this.ViewWishlist.UseVisualStyleBackColor = true;
            this.ViewWishlist.Click += new System.EventHandler(this.button2_Click);
            // 
            // AccountInfo
            // 
            this.AccountInfo.Location = new System.Drawing.Point(4, 535);
            this.AccountInfo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AccountInfo.Name = "AccountInfo";
            this.AccountInfo.Size = new System.Drawing.Size(304, 125);
            this.AccountInfo.TabIndex = 2;
            this.AccountInfo.Text = "Account";
            this.AccountInfo.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1271, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(92, 36);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(135, 36);
            this.fAQToolStripMenuItem.Text = "FAQ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 474);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Edit Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(908, 474);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Order History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "Welcome!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVDExpressProject.Properties.Resources.dvdexpress_logo;
            this.pictureBox2.Location = new System.Drawing.Point(375, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(877, 192);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SearchMovies);
            this.flowLayoutPanel1.Controls.Add(this.BrowseMovies);
            this.flowLayoutPanel1.Controls.Add(this.ViewCart);
            this.flowLayoutPanel1.Controls.Add(this.ViewWishlist);
            this.flowLayoutPanel1.Controls.Add(this.AccountInfo);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 69);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(311, 676);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AccountEditList
            // 
            this.AccountEditList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.AccountEditList.Location = new System.Drawing.Point(429, 514);
            this.AccountEditList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccountEditList.Name = "AccountEditList";
            this.AccountEditList.Size = new System.Drawing.Size(328, 172);
            this.AccountEditList.TabIndex = 12;
            this.AccountEditList.UseCompatibleStateImageBehavior = false;
            this.AccountEditList.View = System.Windows.Forms.View.List;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(869, 514);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(297, 172);
            this.listView2.TabIndex = 13;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // _M_AccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 901);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.AccountEditList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "_M_AccountInfo";
            this.Text = "_M_AccountInfo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchMovies;
        private System.Windows.Forms.Button BrowseMovies;
        private System.Windows.Forms.Button ViewCart;
        private System.Windows.Forms.Button ViewWishlist;
        private System.Windows.Forms.Button AccountInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListView AccountEditList;
        private System.Windows.Forms.ListView listView2;
    }
}