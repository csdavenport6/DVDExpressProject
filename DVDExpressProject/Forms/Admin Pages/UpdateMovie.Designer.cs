namespace DVDExpressProject.Forms.Admin_Pages
{
    partial class UpdateMovie
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
            this.Return = new System.Windows.Forms.Button();
            this.Rating = new System.Windows.Forms.Label();
            this.RatingBox = new System.Windows.Forms.MaskedTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RuntimeBox = new System.Windows.Forms.MaskedTextBox();
            this.ReleaseDateBox = new System.Windows.Forms.DateTimePicker();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.MovieIDBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(112, 550);
            this.Return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(203, 101);
            this.Return.TabIndex = 24;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(253, 440);
            this.Rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(80, 25);
            this.Rating.TabIndex = 23;
            this.Rating.Text = "Rating:";
            // 
            // RatingBox
            // 
            this.RatingBox.Location = new System.Drawing.Point(341, 440);
            this.RatingBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RatingBox.Mask = "A";
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(23, 31);
            this.RatingBox.TabIndex = 22;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(456, 550);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(236, 101);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save Movie Entry";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Runtime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Release Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Movie Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Movie Title:";
            // 
            // RuntimeBox
            // 
            this.RuntimeBox.Location = new System.Drawing.Point(341, 366);
            this.RuntimeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RuntimeBox.Mask = "000";
            this.RuntimeBox.Name = "RuntimeBox";
            this.RuntimeBox.Size = new System.Drawing.Size(45, 31);
            this.RuntimeBox.TabIndex = 16;
            // 
            // ReleaseDateBox
            // 
            this.ReleaseDateBox.Location = new System.Drawing.Point(341, 294);
            this.ReleaseDateBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReleaseDateBox.Name = "ReleaseDateBox";
            this.ReleaseDateBox.Size = new System.Drawing.Size(265, 31);
            this.ReleaseDateBox.TabIndex = 15;
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(341, 209);
            this.GenreBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(263, 31);
            this.GenreBox.TabIndex = 14;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(341, 134);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(263, 31);
            this.TitleBox.TabIndex = 13;
            // 
            // MovieIDBox
            // 
            this.MovieIDBox.Location = new System.Drawing.Point(341, 66);
            this.MovieIDBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MovieIDBox.Name = "MovieIDBox";
            this.MovieIDBox.Size = new System.Drawing.Size(132, 31);
            this.MovieIDBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Movie ID:";
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 774);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MovieIDBox);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.RatingBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RuntimeBox);
            this.Controls.Add(this.ReleaseDateBox);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.TitleBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UpdateMovie";
            this.Text = "Update Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.MaskedTextBox RatingBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox RuntimeBox;
        private System.Windows.Forms.DateTimePicker ReleaseDateBox;
        private System.Windows.Forms.TextBox GenreBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.TextBox MovieIDBox;
        private System.Windows.Forms.Label label5;
    }
}