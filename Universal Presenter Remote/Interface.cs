using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_Presenter_Remote
{
    public partial class Interface : Form
    {
        public Interface()
        {
            InitializeComponent();
        }

        SlideControl slidectl = new SlideControl();

        


        private void ManualBack_Click(object sender, EventArgs e)
        {
            SlideControl.slidebackward();
        }

        private void ManualForward_Click(object sender, EventArgs e)
        {
            SlideControl.slideforward();
        }

        private void SelectProgramDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SlideControl.supportedPrograms[this.SelectProgramDropdown.SelectedIndex].Name == "Manual Program Entry (Advanced)")
            {
                this.CustomProcessTextBox.Visible = true;
            }
            else
            {
                this.CustomProcessTextBox.Visible = false;
            }
            
            SlideControl.presentationSoftware = this.SelectProgramDropdown.SelectedIndex;
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            this.SelectProgramDropdown.DataSource = SlideControl.supportedPrograms;
            this.SelectProgramDropdown.DisplayMember = "Name";
            this.SelectProgramDropdown.ValueMember = "StartProcess";
            this.SelectProgramDropdown.SelectedIndex = 0;
            this.UpdateTimer.Start();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (this.ConnectButton.Text == "Connect")
            {
                this.ConnectButton.Enabled = false;
                this.CustomProcessTextBox.Enabled = false;
                this.SelectProgramDropdown.Enabled = false;
                this.ConnectButton.Text = "Connecting...";
                if (this.slidectl.connect())
                {
                    this.ConnectButton.Text = "Disconnect";
                    this.ConnectButton.Enabled = true;
                    this.CustomProcessTextBox.Enabled = false;
                    this.SelectProgramDropdown.Enabled = false;
                    this.ManualForward.Enabled = true;
                    this.ManualBack.Enabled = true;
                    Server_Communication.enabled = true;
                }
                else
                {
                    this.ConnectButton.Text = "Connection Failed";
                    this.ConnectButton.Enabled = true;
                    this.CustomProcessTextBox.Enabled = true;
                    this.SelectProgramDropdown.Enabled = true;
                    this.ManualForward.Enabled = false;
                    this.ManualBack.Enabled = false;
                }
            }
            else
            {
                this.ConnectButton.Text = "Connect";
                this.CustomProcessTextBox.Enabled = true;
                this.SelectProgramDropdown.Enabled = true;
                this.ManualForward.Enabled = false;
                this.ManualBack.Enabled = false;
                Server_Communication.enabled = false;
            }
            

        }

        private void CustomProcessTextBox_TextChanged(object sender, EventArgs e)
        {
            SlideControl.supportedPrograms[this.SelectProgramDropdown.SelectedIndex].ControlWindow = this.CustomProcessTextBox.Text;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            Server_Communication.update();
        }
    }
}
