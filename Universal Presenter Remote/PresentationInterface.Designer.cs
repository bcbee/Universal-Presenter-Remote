namespace Universal_Presenter_Remote
{
    partial class PresentationInterface
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
            this.SelectProgramDropdown = new System.Windows.Forms.ComboBox();
            this.CustomProcessTextBox = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SelectProgramDropdown
            // 
            this.SelectProgramDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectProgramDropdown.FormattingEnabled = true;
            this.SelectProgramDropdown.Items.AddRange(new object[] {
            "DataSource Failure"});
            this.SelectProgramDropdown.Location = new System.Drawing.Point(12, 12);
            this.SelectProgramDropdown.Name = "SelectProgramDropdown";
            this.SelectProgramDropdown.Size = new System.Drawing.Size(260, 21);
            this.SelectProgramDropdown.TabIndex = 2;
            this.SelectProgramDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectProgramDropdown_SelectedIndexChanged);
            // 
            // CustomProcessTextBox
            // 
            this.CustomProcessTextBox.Location = new System.Drawing.Point(12, 39);
            this.CustomProcessTextBox.Name = "CustomProcessTextBox";
            this.CustomProcessTextBox.Size = new System.Drawing.Size(260, 20);
            this.CustomProcessTextBox.TabIndex = 3;
            this.CustomProcessTextBox.Visible = false;
            this.CustomProcessTextBox.TextChanged += new System.EventHandler(this.CustomProcessTextBox_TextChanged);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 65);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(260, 23);
            this.ConnectButton.TabIndex = 4;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 750;
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // PresentationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.CustomProcessTextBox);
            this.Controls.Add(this.SelectProgramDropdown);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "PresentationInterface";
            this.Text = "Presenter Interface";
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectProgramDropdown;
        private System.Windows.Forms.TextBox CustomProcessTextBox;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Timer UpdateTimer;
    }
}