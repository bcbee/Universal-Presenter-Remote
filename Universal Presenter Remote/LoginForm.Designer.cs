namespace Universal_Presenter_Remote
{
    partial class LoginForm
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
            this.LoginTabControl = new System.Windows.Forms.TabControl();
            this.JumpInPage = new System.Windows.Forms.TabPage();
            this.JumpInTable = new System.Windows.Forms.TableLayoutPanel();
            this.JumpInTokenLabel = new System.Windows.Forms.Label();
            this.JumpInWelcomeLabel = new System.Windows.Forms.Label();
            this.JumpInButton = new System.Windows.Forms.Button();
            this.JumpInLogo = new System.Windows.Forms.PictureBox();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.LoginTabControl.SuspendLayout();
            this.JumpInPage.SuspendLayout();
            this.JumpInTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumpInLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTabControl
            // 
            this.LoginTabControl.Controls.Add(this.JumpInPage);
            this.LoginTabControl.Controls.Add(this.LoginPage);
            this.LoginTabControl.Location = new System.Drawing.Point(12, 12);
            this.LoginTabControl.Name = "LoginTabControl";
            this.LoginTabControl.SelectedIndex = 0;
            this.LoginTabControl.Size = new System.Drawing.Size(660, 337);
            this.LoginTabControl.TabIndex = 0;
            // 
            // JumpInPage
            // 
            this.JumpInPage.Controls.Add(this.JumpInTable);
            this.JumpInPage.Location = new System.Drawing.Point(4, 22);
            this.JumpInPage.Name = "JumpInPage";
            this.JumpInPage.Padding = new System.Windows.Forms.Padding(3);
            this.JumpInPage.Size = new System.Drawing.Size(652, 311);
            this.JumpInPage.TabIndex = 0;
            this.JumpInPage.Text = "Jump In";
            this.JumpInPage.UseVisualStyleBackColor = true;
            // 
            // JumpInTable
            // 
            this.JumpInTable.ColumnCount = 3;
            this.JumpInTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.JumpInTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.JumpInTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.JumpInTable.Controls.Add(this.JumpInTokenLabel, 1, 2);
            this.JumpInTable.Controls.Add(this.JumpInWelcomeLabel, 1, 1);
            this.JumpInTable.Controls.Add(this.JumpInButton, 1, 3);
            this.JumpInTable.Controls.Add(this.JumpInLogo, 1, 0);
            this.JumpInTable.Location = new System.Drawing.Point(6, 6);
            this.JumpInTable.Name = "JumpInTable";
            this.JumpInTable.RowCount = 4;
            this.JumpInTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.JumpInTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.JumpInTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.JumpInTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.JumpInTable.Size = new System.Drawing.Size(640, 299);
            this.JumpInTable.TabIndex = 0;
            // 
            // JumpInTokenLabel
            // 
            this.JumpInTokenLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JumpInTokenLabel.AutoSize = true;
            this.JumpInTokenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JumpInTokenLabel.Location = new System.Drawing.Point(264, 173);
            this.JumpInTokenLabel.Name = "JumpInTokenLabel";
            this.JumpInTokenLabel.Size = new System.Drawing.Size(111, 33);
            this.JumpInTokenLabel.TabIndex = 1;
            this.JumpInTokenLabel.Text = "123456";
            // 
            // JumpInWelcomeLabel
            // 
            this.JumpInWelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JumpInWelcomeLabel.AutoSize = true;
            this.JumpInWelcomeLabel.Location = new System.Drawing.Point(185, 144);
            this.JumpInWelcomeLabel.Name = "JumpInWelcomeLabel";
            this.JumpInWelcomeLabel.Size = new System.Drawing.Size(270, 13);
            this.JumpInWelcomeLabel.TabIndex = 0;
            this.JumpInWelcomeLabel.Text = "Welcome to Universal Presenter Remote! Your token is:\r\n";
            // 
            // JumpInButton
            // 
            this.JumpInButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JumpInButton.Location = new System.Drawing.Point(265, 243);
            this.JumpInButton.Name = "JumpInButton";
            this.JumpInButton.Size = new System.Drawing.Size(110, 23);
            this.JumpInButton.TabIndex = 2;
            this.JumpInButton.Text = "Click to start!";
            this.JumpInButton.UseVisualStyleBackColor = true;
            this.JumpInButton.Click += new System.EventHandler(this.JumpInButton_Click);
            // 
            // JumpInLogo
            // 
            this.JumpInLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JumpInLogo.Location = new System.Drawing.Point(222, 3);
            this.JumpInLogo.Name = "JumpInLogo";
            this.JumpInLogo.Size = new System.Drawing.Size(196, 126);
            this.JumpInLogo.TabIndex = 3;
            this.JumpInLogo.TabStop = false;
            // 
            // LoginPage
            // 
            this.LoginPage.Location = new System.Drawing.Point(4, 22);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(652, 311);
            this.LoginPage.TabIndex = 1;
            this.LoginPage.Text = "Login";
            this.LoginPage.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.LoginTabControl);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginTabControl.ResumeLayout(false);
            this.JumpInPage.ResumeLayout(false);
            this.JumpInTable.ResumeLayout(false);
            this.JumpInTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumpInLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LoginTabControl;
        private System.Windows.Forms.TabPage JumpInPage;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.TableLayoutPanel JumpInTable;
        private System.Windows.Forms.Label JumpInTokenLabel;
        private System.Windows.Forms.Label JumpInWelcomeLabel;
        private System.Windows.Forms.Button JumpInButton;
        private System.Windows.Forms.PictureBox JumpInLogo;
    }
}

