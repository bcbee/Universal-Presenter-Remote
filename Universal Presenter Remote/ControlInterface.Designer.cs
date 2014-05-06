﻿namespace Universal_Presenter_Remote
{
    partial class ControlInterface
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.PreviousSlideButton = new System.Windows.Forms.Button();
            this.NextSlideButton = new System.Windows.Forms.Button();
            this.PlayMedia = new System.Windows.Forms.Button();
            this.PresentLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PresentLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.PreviousSlideButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NextSlideButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 277);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(502, 56);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // PreviousSlideButton
            // 
            this.PreviousSlideButton.Location = new System.Drawing.Point(6, 6);
            this.PreviousSlideButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PreviousSlideButton.Name = "PreviousSlideButton";
            this.PreviousSlideButton.Size = new System.Drawing.Size(239, 44);
            this.PreviousSlideButton.TabIndex = 0;
            this.PreviousSlideButton.Text = "Previous Slide";
            this.PreviousSlideButton.UseVisualStyleBackColor = true;
            this.PreviousSlideButton.Click += new System.EventHandler(this.PreviousSlideButton_Click);
            // 
            // NextSlideButton
            // 
            this.NextSlideButton.Location = new System.Drawing.Point(257, 6);
            this.NextSlideButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NextSlideButton.Name = "NextSlideButton";
            this.NextSlideButton.Size = new System.Drawing.Size(239, 44);
            this.NextSlideButton.TabIndex = 1;
            this.NextSlideButton.Text = "Next Slide";
            this.NextSlideButton.UseVisualStyleBackColor = true;
            this.NextSlideButton.Click += new System.EventHandler(this.NextSlideButton_Click);
            // 
            // PlayMedia
            // 
            this.PlayMedia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayMedia.Location = new System.Drawing.Point(28, 344);
            this.PlayMedia.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PlayMedia.Name = "PlayMedia";
            this.PlayMedia.Size = new System.Drawing.Size(502, 44);
            this.PlayMedia.TabIndex = 1;
            this.PlayMedia.Text = "Play Media (PowerPoint)";
            this.PlayMedia.UseVisualStyleBackColor = true;
            this.PlayMedia.Click += new System.EventHandler(this.PlayMedia_Click);
            // 
            // PresentLogo
            // 
            this.PresentLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PresentLogo.Image = global::Universal_Presenter_Remote.Properties.Resources.UPR;
            this.PresentLogo.Location = new System.Drawing.Point(28, 23);
            this.PresentLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.PresentLogo.Name = "PresentLogo";
            this.PresentLogo.Size = new System.Drawing.Size(502, 242);
            this.PresentLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PresentLogo.TabIndex = 6;
            this.PresentLogo.TabStop = false;
            // 
            // ControlInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(2)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(548, 440);
            this.Controls.Add(this.PresentLogo);
            this.Controls.Add(this.PlayMedia);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximumSize = new System.Drawing.Size(574, 511);
            this.MinimumSize = new System.Drawing.Size(574, 511);
            this.Name = "ControlInterface";
            this.Text = "Control Presentation";
            this.Load += new System.EventHandler(this.ControlInterface_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PresentLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button NextSlideButton;
        private System.Windows.Forms.Button PreviousSlideButton;
        private System.Windows.Forms.Button PlayMedia;
        private System.Windows.Forms.PictureBox PresentLogo;
    }
}