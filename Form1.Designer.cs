﻿namespace RocketScience
{
    partial class Game
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
            this.rocket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            this.SuspendLayout();
            // 
            // rocket
            // 
            this.rocket.Image = global::RocketScience.Properties.Resources.rocket_off_000;
            this.rocket.Location = new System.Drawing.Point(363, 446);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(87, 134);
            this.rocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rocket.TabIndex = 0;
            this.rocket.TabStop = false;
            this.rocket.Click += new System.EventHandler(this.Rocket_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 592);
            this.Controls.Add(this.rocket);
            this.Name = "Game";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox rocket;
    }
}

