﻿namespace DVDExpressProject.Forms.Admin_Pages
{
    partial class DeleteMovie
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
            this.label5 = new System.Windows.Forms.Label();
            this.MovieIDBox = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Movie ID:";
            // 
            // MovieIDBox
            // 
            this.MovieIDBox.Location = new System.Drawing.Point(364, 104);
            this.MovieIDBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MovieIDBox.Name = "MovieIDBox";
            this.MovieIDBox.Size = new System.Drawing.Size(132, 31);
            this.MovieIDBox.TabIndex = 39;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(107, 264);
            this.Return.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(203, 101);
            this.Return.TabIndex = 38;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(451, 264);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(236, 101);
            this.DeleteButton.TabIndex = 35;
            this.DeleteButton.Text = "Delete Movie Entry";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 458);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MovieIDBox);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.DeleteButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteMovie";
            this.Text = "Delete Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MovieIDBox;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Button DeleteButton;
    }
}