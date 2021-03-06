﻿namespace DVDExpressProject.Forms.Member_Pages
{
    partial class _M_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_M_Search));
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ViewCartButton = new System.Windows.Forms.Button();
            this.ViewWishlistButton = new System.Windows.Forms.Button();
            this.ViewAcctButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.MovieList = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaysForRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.s2T5DataSet = new DVDExpressProject.S2T5DataSet();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.movieTableAdapter = new DVDExpressProject.S2T5DataSetTableAdapters.MovieTableAdapter();
            this.SearchButton = new System.Windows.Forms.Button();
            this.BrowseNavButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FAQButton = new System.Windows.Forms.ToolStripMenuItem();
            this.WishlistBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddToWishlist = new System.Windows.Forms.Button();
            this.AddToCart = new System.Windows.Forms.Button();
            this.movieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MovieList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2T5DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(14, 152);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(230, 114);
            this.BrowseButton.TabIndex = 17;
            this.BrowseButton.Text = "Browse Movies";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ViewCartButton
            // 
            this.ViewCartButton.Location = new System.Drawing.Point(14, 271);
            this.ViewCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewCartButton.Name = "ViewCartButton";
            this.ViewCartButton.Size = new System.Drawing.Size(228, 100);
            this.ViewCartButton.TabIndex = 13;
            this.ViewCartButton.Text = "Cart";
            this.ViewCartButton.UseVisualStyleBackColor = true;
            this.ViewCartButton.Click += new System.EventHandler(this.ViewCartButton_Click);
            // 
            // ViewWishlistButton
            // 
            this.ViewWishlistButton.Location = new System.Drawing.Point(14, 376);
            this.ViewWishlistButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewWishlistButton.Name = "ViewWishlistButton";
            this.ViewWishlistButton.Size = new System.Drawing.Size(228, 100);
            this.ViewWishlistButton.TabIndex = 14;
            this.ViewWishlistButton.Text = "Wishlist";
            this.ViewWishlistButton.UseVisualStyleBackColor = true;
            this.ViewWishlistButton.Click += new System.EventHandler(this.ViewWishlistButton_Click);
            // 
            // ViewAcctButton
            // 
            this.ViewAcctButton.Location = new System.Drawing.Point(14, 481);
            this.ViewAcctButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewAcctButton.Name = "ViewAcctButton";
            this.ViewAcctButton.Size = new System.Drawing.Size(228, 100);
            this.ViewAcctButton.TabIndex = 15;
            this.ViewAcctButton.Text = "Account";
            this.ViewAcctButton.UseVisualStyleBackColor = true;
            this.ViewAcctButton.Click += new System.EventHandler(this.ViewAcctButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(280, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Search Inventory";
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(490, 170);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(408, 26);
            this.SearchBox.TabIndex = 19;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // MovieList
            // 
            this.MovieList.AllowUserToAddRows = false;
            this.MovieList.AllowUserToDeleteRows = false;
            this.MovieList.AllowUserToOrderColumns = true;
            this.MovieList.AutoGenerateColumns = false;
            this.MovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovieList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.runTimeDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.DaysForRent});
            this.MovieList.DataSource = this.movieBindingSource;
            this.MovieList.Location = new System.Drawing.Point(292, 217);
            this.MovieList.Name = "MovieList";
            this.MovieList.ReadOnly = true;
            this.MovieList.RowTemplate.Height = 28;
            this.MovieList.Size = new System.Drawing.Size(656, 357);
            this.MovieList.TabIndex = 20;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // runTimeDataGridViewTextBoxColumn
            // 
            this.runTimeDataGridViewTextBoxColumn.DataPropertyName = "RunTime";
            this.runTimeDataGridViewTextBoxColumn.HeaderText = "Run Time";
            this.runTimeDataGridViewTextBoxColumn.Name = "runTimeDataGridViewTextBoxColumn";
            this.runTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DaysForRent
            // 
            this.DaysForRent.DataPropertyName = "DaysForRent";
            this.DaysForRent.HeaderText = "Days For Rent";
            this.DaysForRent.Name = "DaysForRent";
            this.DaysForRent.ReadOnly = true;
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.s2T5DataSet;
            // 
            // s2T5DataSet
            // 
            this.s2T5DataSet.DataSetName = "S2T5DataSet";
            this.s2T5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVDExpressProject.Properties.Resources.dvdexpress_logo;
            this.pictureBox2.Location = new System.Drawing.Point(270, 48);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(658, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(16, 48);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(228, 100);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Search Movies";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // BrowseNavButton
            // 
            this.BrowseNavButton.Location = new System.Drawing.Point(14, 152);
            this.BrowseNavButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BrowseNavButton.Name = "BrowseNavButton";
            this.BrowseNavButton.Size = new System.Drawing.Size(230, 114);
            this.BrowseNavButton.TabIndex = 17;
            this.BrowseNavButton.Text = "Browse Movies";
            this.BrowseNavButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 100);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 376);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 100);
            this.button2.TabIndex = 14;
            this.button2.Text = "Wishlist";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 481);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 100);
            this.button3.TabIndex = 15;
            this.button3.Text = "Account";
            this.button3.UseVisualStyleBackColor = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(991, 33);
            this.menuStrip1.TabIndex = 22;
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
            // WishlistBox
            // 
            this.WishlistBox.FormattingEnabled = true;
            this.WishlistBox.ItemHeight = 20;
            this.WishlistBox.Location = new System.Drawing.Point(292, 603);
            this.WishlistBox.Name = "WishlistBox";
            this.WishlistBox.Size = new System.Drawing.Size(155, 84);
            this.WishlistBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Available Wishlists";
            // 
            // AddToWishlist
            // 
            this.AddToWishlist.Location = new System.Drawing.Point(526, 603);
            this.AddToWishlist.Name = "AddToWishlist";
            this.AddToWishlist.Size = new System.Drawing.Size(166, 84);
            this.AddToWishlist.TabIndex = 25;
            this.AddToWishlist.Text = "Add movie to selected wishlist";
            this.AddToWishlist.UseVisualStyleBackColor = true;
            this.AddToWishlist.Click += new System.EventHandler(this.AddToWishlist_Click);
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(762, 603);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(166, 84);
            this.AddToCart.TabIndex = 26;
            this.AddToCart.Text = "Add movie to cart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // movieBindingSource1
            // 
            this.movieBindingSource1.DataMember = "Movie";
            this.movieBindingSource1.DataSource = this.s2T5DataSet;
            // 
            // _M_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(991, 697);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.AddToWishlist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WishlistBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MovieList);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ViewCartButton);
            this.Controls.Add(this.ViewWishlistButton);
            this.Controls.Add(this.ViewAcctButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "_M_Search";
            this.Text = "Search Movies";
            this.Load += new System.EventHandler(this._M_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovieList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2T5DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView MovieList;
        private S2T5DataSet s2T5DataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private S2T5DataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button ViewCartButton;
        private System.Windows.Forms.Button ViewWishlistButton;
        private System.Windows.Forms.Button ViewAcctButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button BrowseNavButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FAQButton;
        private System.Windows.Forms.ListBox WishlistBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddToWishlist;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.BindingSource movieBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysForRent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn runTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    }
}