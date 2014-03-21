namespace Universal_Presenter_Remote
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NextSlideButton = new System.Windows.Forms.Button();
            this.PreviousSlideButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.37288F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.62712F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(259, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.NextSlideButton, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.PreviousSlideButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(253, 29);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // NextSlideButton
            // 
            this.NextSlideButton.Location = new System.Drawing.Point(129, 3);
            this.NextSlideButton.Name = "NextSlideButton";
            this.NextSlideButton.Size = new System.Drawing.Size(120, 23);
            this.NextSlideButton.TabIndex = 1;
            this.NextSlideButton.Text = "Next Slide";
            this.NextSlideButton.UseVisualStyleBackColor = true;
            this.NextSlideButton.Click += new System.EventHandler(this.NextSlideButton_Click);
            // 
            // PreviousSlideButton
            // 
            this.PreviousSlideButton.Location = new System.Drawing.Point(3, 3);
            this.PreviousSlideButton.Name = "PreviousSlideButton";
            this.PreviousSlideButton.Size = new System.Drawing.Size(120, 23);
            this.PreviousSlideButton.TabIndex = 0;
            this.PreviousSlideButton.Text = "Previous Slide";
            this.PreviousSlideButton.UseVisualStyleBackColor = true;
            this.PreviousSlideButton.Click += new System.EventHandler(this.PreviousSlideButton_Click);
            // 
            // ControlInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "ControlInterface";
            this.Text = "Control Presentation";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button NextSlideButton;
        private System.Windows.Forms.Button PreviousSlideButton;
    }
}