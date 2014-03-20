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
            this.PresentButton = new System.Windows.Forms.Button();
            this.JumpInLogo = new System.Windows.Forms.PictureBox();
            this.JumpInWelcomeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.token6 = new System.Windows.Forms.TextBox();
            this.token5 = new System.Windows.Forms.TextBox();
            this.token4 = new System.Windows.Forms.TextBox();
            this.token3 = new System.Windows.Forms.TextBox();
            this.token2 = new System.Windows.Forms.TextBox();
            this.token1 = new System.Windows.Forms.TextBox();
            this.LoginPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginTabControl.SuspendLayout();
            this.JumpInPage.SuspendLayout();
            this.JumpInTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.JumpInLogo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.LoginPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.JumpInPage.Text = "Present";
            this.JumpInPage.UseVisualStyleBackColor = true;
            // 
            // JumpInTable
            // 
            this.JumpInTable.ColumnCount = 3;
            this.JumpInTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.JumpInTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.JumpInTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.JumpInTable.Controls.Add(this.PresentButton, 1, 3);
            this.JumpInTable.Controls.Add(this.JumpInLogo, 1, 0);
            this.JumpInTable.Controls.Add(this.JumpInWelcomeLabel, 1, 1);
            this.JumpInTable.Controls.Add(this.tableLayoutPanel2, 1, 2);
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
            // PresentButton
            // 
            this.PresentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PresentButton.Enabled = false;
            this.PresentButton.Location = new System.Drawing.Point(265, 243);
            this.PresentButton.Name = "PresentButton";
            this.PresentButton.Size = new System.Drawing.Size(110, 23);
            this.PresentButton.TabIndex = 2;
            this.PresentButton.Text = "Click to start!";
            this.PresentButton.UseVisualStyleBackColor = true;
            this.PresentButton.Click += new System.EventHandler(this.Present_Click);
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
            // JumpInWelcomeLabel
            // 
            this.JumpInWelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JumpInWelcomeLabel.AutoSize = true;
            this.JumpInWelcomeLabel.Location = new System.Drawing.Point(160, 144);
            this.JumpInWelcomeLabel.Name = "JumpInWelcomeLabel";
            this.JumpInWelcomeLabel.Size = new System.Drawing.Size(320, 13);
            this.JumpInWelcomeLabel.TabIndex = 0;
            this.JumpInWelcomeLabel.Text = "Welcome to Universal Presenter Remote! Please enter your token:";
            this.JumpInWelcomeLabel.Click += new System.EventHandler(this.JumpInWelcomeLabel_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Controls.Add(this.token6, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.token5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.token4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.token3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.token2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.token1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(199, 176);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(242, 61);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // token6
            // 
            this.token6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token6.Location = new System.Drawing.Point(203, 3);
            this.token6.MaxLength = 1;
            this.token6.Name = "token6";
            this.token6.Size = new System.Drawing.Size(34, 53);
            this.token6.TabIndex = 5;
            this.token6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.token6.TextChanged += new System.EventHandler(this.token6_TextChanged);
            // 
            // token5
            // 
            this.token5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token5.Location = new System.Drawing.Point(163, 3);
            this.token5.MaxLength = 1;
            this.token5.Name = "token5";
            this.token5.Size = new System.Drawing.Size(34, 53);
            this.token5.TabIndex = 4;
            this.token5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.token5.TextChanged += new System.EventHandler(this.token5_TextChanged);
            // 
            // token4
            // 
            this.token4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token4.Location = new System.Drawing.Point(123, 3);
            this.token4.MaxLength = 1;
            this.token4.Name = "token4";
            this.token4.Size = new System.Drawing.Size(34, 53);
            this.token4.TabIndex = 3;
            this.token4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.token4.TextChanged += new System.EventHandler(this.token4_TextChanged);
            // 
            // token3
            // 
            this.token3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token3.Location = new System.Drawing.Point(83, 3);
            this.token3.MaxLength = 1;
            this.token3.Name = "token3";
            this.token3.Size = new System.Drawing.Size(34, 53);
            this.token3.TabIndex = 2;
            this.token3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.token3.TextChanged += new System.EventHandler(this.token3_TextChanged);
            // 
            // token2
            // 
            this.token2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token2.Location = new System.Drawing.Point(43, 3);
            this.token2.MaxLength = 1;
            this.token2.Name = "token2";
            this.token2.Size = new System.Drawing.Size(34, 53);
            this.token2.TabIndex = 1;
            this.token2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.token2.TextChanged += new System.EventHandler(this.token2_TextChanged);
            // 
            // token1
            // 
            this.token1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token1.Location = new System.Drawing.Point(3, 3);
            this.token1.MaxLength = 1;
            this.token1.Name = "token1";
            this.token1.Size = new System.Drawing.Size(34, 53);
            this.token1.TabIndex = 0;
            this.token1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.token1.TextChanged += new System.EventHandler(this.token1_TextChanged);
            // 
            // LoginPage
            // 
            this.LoginPage.Controls.Add(this.tableLayoutPanel1);
            this.LoginPage.Location = new System.Drawing.Point(4, 22);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoginPage.Size = new System.Drawing.Size(652, 311);
            this.LoginPage.TabIndex = 1;
            this.LoginPage.Text = "Control";
            this.LoginPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 299);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "123456";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome to Universal Presenter Remote! Your token is:\r\n";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(265, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click to start!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Location = new System.Drawing.Point(222, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 126);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.LoginPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LoginTabControl;
        private System.Windows.Forms.TabPage JumpInPage;
        private System.Windows.Forms.TabPage LoginPage;
        private System.Windows.Forms.TableLayoutPanel JumpInTable;
        private System.Windows.Forms.Label JumpInWelcomeLabel;
        private System.Windows.Forms.Button PresentButton;
        private System.Windows.Forms.PictureBox JumpInLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox token1;
        private System.Windows.Forms.TextBox token5;
        private System.Windows.Forms.TextBox token4;
        private System.Windows.Forms.TextBox token3;
        private System.Windows.Forms.TextBox token2;
        private System.Windows.Forms.TextBox token6;
    }
}

