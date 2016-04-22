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
            this.Return.Location = new System.Drawing.Point(84, 440);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(152, 81);
            this.Return.TabIndex = 24;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(190, 352);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(60, 20);
            this.Rating.TabIndex = 23;
            this.Rating.Text = "Rating:";
            // 
            // RatingBox
            // 
            this.RatingBox.Location = new System.Drawing.Point(256, 352);
            this.RatingBox.Mask = "A";
            this.RatingBox.Name = "RatingBox";
            this.RatingBox.Size = new System.Drawing.Size(18, 26);
            this.RatingBox.TabIndex = 22;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(342, 440);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(177, 81);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save Movie Entry";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Runtime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Release Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Movie Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Movie Title:";
            // 
            // RuntimeBox
            // 
            this.RuntimeBox.Location = new System.Drawing.Point(256, 293);
            this.RuntimeBox.Mask = "000";
            this.RuntimeBox.Name = "RuntimeBox";
            this.RuntimeBox.Size = new System.Drawing.Size(35, 26);
            this.RuntimeBox.TabIndex = 16;
            // 
            // ReleaseDateBox
            // 
            this.ReleaseDateBox.Location = new System.Drawing.Point(256, 235);
            this.ReleaseDateBox.Name = "ReleaseDateBox";
            this.ReleaseDateBox.Size = new System.Drawing.Size(200, 26);
            this.ReleaseDateBox.TabIndex = 15;
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(256, 167);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.Size = new System.Drawing.Size(198, 26);
            this.GenreBox.TabIndex = 14;
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(256, 107);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(198, 26);
            this.TitleBox.TabIndex = 13;
            // 
            // MovieIDBox
            // 
            this.MovieIDBox.Location = new System.Drawing.Point(256, 53);
            this.MovieIDBox.Name = "MovieIDBox";
            this.MovieIDBox.Size = new System.Drawing.Size(100, 26);
            this.MovieIDBox.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Movie ID:";
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 619);
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