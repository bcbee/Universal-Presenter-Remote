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
            this.components = new System.ComponentModel.Container();
            this.LoginTabControl = new System.Windows.Forms.TabControl();
            this.PresentTab = new System.Windows.Forms.TabPage();
            this.JumpInTable = new System.Windows.Forms.TableLayoutPanel();
            this.PresentButton = new System.Windows.Forms.Button();
            this.PresentLogo = new System.Windows.Forms.PictureBox();
            this.PresentWelcome = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.token6 = new System.Windows.Forms.TextBox();
            this.token5 = new System.Windows.Forms.TextBox();
            this.token4 = new System.Windows.Forms.TextBox();
            this.token3 = new System.Windows.Forms.TextBox();
            this.token2 = new System.Windows.Forms.TextBox();
            this.token1 = new System.Windows.Forms.TextBox();
            this.ControlTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ControlToken = new System.Windows.Forms.Label();
            this.ControlWelcome = new System.Windows.Forms.Label();
            this.ControlButton = new System.Windows.Forms.Button();
            this.ControlLogo = new System.Windows.Forms.PictureBox();
            this.ServerTimer = new System.Windows.Forms.Timer(this.components);
            this.LoginTabControl.SuspendLayout();
            this.PresentTab.SuspendLayout();
            this.JumpInTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PresentLogo)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.ControlTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTabControl
            // 
            this.LoginTabControl.Controls.Add(this.PresentTab);
            this.LoginTabControl.Controls.Add(this.ControlTab);
            this.LoginTabControl.Location = new System.Drawing.Point(12, 12);
            this.LoginTabControl.Name = "LoginTabControl";
            this.LoginTabControl.SelectedIndex = 0;
            this.LoginTabControl.Size = new System.Drawing.Size(660, 337);
            this.LoginTabControl.TabIndex = 0;
            // 
            // PresentTab
            // 
            this.PresentTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(2)))), ((int)(((byte)(152)))));
            this.PresentTab.Controls.Add(this.JumpInTable);
            this.PresentTab.Location = new System.Drawing.Point(4, 22);
            this.PresentTab.Name = "PresentTab";
            this.PresentTab.Padding = new System.Windows.Forms.Padding(3);
            this.PresentTab.Size = new System.Drawing.Size(652, 311);
            this.PresentTab.TabIndex = 0;
            this.PresentTab.Text = "Present";
            // 
            // JumpInTable
            // 
            this.JumpInTable.ColumnCount = 3;
            this.JumpInTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.JumpInTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.JumpInTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.JumpInTable.Controls.Add(this.PresentButton, 1, 3);
            this.JumpInTable.Controls.Add(this.PresentLogo, 1, 0);
            this.JumpInTable.Controls.Add(this.PresentWelcome, 1, 1);
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
            this.PresentButton.Text = "Connecting...";
            this.PresentButton.UseVisualStyleBackColor = true;
            this.PresentButton.Click += new System.EventHandler(this.Present_Click);
            // 
            // PresentLogo
            // 
            this.PresentLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PresentLogo.Image = global::Universal_Presenter_Remote.Properties.Resources.UPR_Wide;
            this.PresentLogo.Location = new System.Drawing.Point(190, 3);
            this.PresentLogo.Name = "PresentLogo";
            this.PresentLogo.Size = new System.Drawing.Size(260, 126);
            this.PresentLogo.TabIndex = 3;
            this.PresentLogo.TabStop = false;
            // 
            // PresentWelcome
            // 
            this.PresentWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PresentWelcome.AutoSize = true;
            this.PresentWelcome.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentWelcome.ForeColor = System.Drawing.SystemColors.Control;
            this.PresentWelcome.Location = new System.Drawing.Point(198, 144);
            this.PresentWelcome.Name = "PresentWelcome";
            this.PresentWelcome.Size = new System.Drawing.Size(243, 29);
            this.PresentWelcome.TabIndex = 0;
            this.PresentWelcome.Text = "Please enter your token:";
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
            this.token6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.token6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token6.ForeColor = System.Drawing.Color.White;
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
            this.token5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.token5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token5.ForeColor = System.Drawing.Color.White;
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
            this.token4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.token4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token4.ForeColor = System.Drawing.Color.White;
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
            this.token3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.token3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token3.ForeColor = System.Drawing.Color.White;
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
            this.token2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.token2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token2.ForeColor = System.Drawing.Color.White;
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
            this.token1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.token1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token1.ForeColor = System.Drawing.Color.White;
            this.token1.Location = new System.Drawing.Point(3, 3);
            this.token1.MaxLength = 1;
            this.token1.Name = "token1";
            this.token1.Size = new System.Drawing.Size(34, 53);
            this.token1.TabIndex = 0;
            this.token1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.token1.TextChanged += new System.EventHandler(this.token1_TextChanged);
            // 
            // ControlTab
            // 
            this.ControlTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(2)))), ((int)(((byte)(152)))));
            this.ControlTab.Controls.Add(this.tableLayoutPanel1);
            this.ControlTab.Location = new System.Drawing.Point(4, 22);
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.Padding = new System.Windows.Forms.Padding(3);
            this.ControlTab.Size = new System.Drawing.Size(652, 311);
            this.ControlTab.TabIndex = 1;
            this.ControlTab.Text = "Control";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ControlToken, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ControlWelcome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ControlButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ControlLogo, 1, 0);
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
            // ControlToken
            // 
            this.ControlToken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ControlToken.AutoSize = true;
            this.ControlToken.Font = new System.Drawing.Font("Bebas Neue", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlToken.ForeColor = System.Drawing.SystemColors.Control;
            this.ControlToken.Location = new System.Drawing.Point(291, 173);
            this.ControlToken.Name = "ControlToken";
            this.ControlToken.Size = new System.Drawing.Size(58, 64);
            this.ControlToken.TabIndex = 1;
            this.ControlToken.Text = "...";
            // 
            // ControlWelcome
            // 
            this.ControlWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ControlWelcome.AutoSize = true;
            this.ControlWelcome.Font = new System.Drawing.Font("Bebas Neue", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ControlWelcome.ForeColor = System.Drawing.SystemColors.Control;
            this.ControlWelcome.Location = new System.Drawing.Point(249, 144);
            this.ControlWelcome.Name = "ControlWelcome";
            this.ControlWelcome.Size = new System.Drawing.Size(141, 29);
            this.ControlWelcome.TabIndex = 0;
            this.ControlWelcome.Text = "Your token is:\r\n";
            // 
            // ControlButton
            // 
            this.ControlButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ControlButton.Enabled = false;
            this.ControlButton.Location = new System.Drawing.Point(265, 243);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(110, 23);
            this.ControlButton.TabIndex = 2;
            this.ControlButton.Text = "Connecting...";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // ControlLogo
            // 
            this.ControlLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ControlLogo.Image = global::Universal_Presenter_Remote.Properties.Resources.UPR_Wide;
            this.ControlLogo.Location = new System.Drawing.Point(190, 3);
            this.ControlLogo.Name = "ControlLogo";
            this.ControlLogo.Size = new System.Drawing.Size(260, 126);
            this.ControlLogo.TabIndex = 3;
            this.ControlLogo.TabStop = false;
            // 
            // ServerTimer
            // 
            this.ServerTimer.Enabled = true;
            this.ServerTimer.Interval = 1000;
            this.ServerTimer.Tick += new System.EventHandler(this.ServerTimer_Tick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(6)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.LoginTabControl);
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginTabControl.ResumeLayout(false);
            this.PresentTab.ResumeLayout(false);
            this.JumpInTable.ResumeLayout(false);
            this.JumpInTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PresentLogo)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ControlTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl LoginTabControl;
        private System.Windows.Forms.TabPage PresentTab;
        private System.Windows.Forms.TabPage ControlTab;
        private System.Windows.Forms.TableLayoutPanel JumpInTable;
        private System.Windows.Forms.Label PresentWelcome;
        private System.Windows.Forms.Button PresentButton;
        private System.Windows.Forms.PictureBox PresentLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label ControlToken;
        private System.Windows.Forms.Label ControlWelcome;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.PictureBox ControlLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox token1;
        private System.Windows.Forms.TextBox token5;
        private System.Windows.Forms.TextBox token4;
        private System.Windows.Forms.TextBox token3;
        private System.Windows.Forms.TextBox token2;
        private System.Windows.Forms.TextBox token6;
        private System.Windows.Forms.Timer ServerTimer;
    }
}

