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
    public partial class PresentationInterface : Form
    {
        public PresentationInterface()
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
            if (SlideControl.supportedPrograms[SelectProgramDropdown.SelectedIndex].Name == "Manual Program Entry (Advanced)")
            {
                CustomProcessTextBox.Visible = true;
            }
            else
            {
                CustomProcessTextBox.Visible = false;
            }
            
            SlideControl.presentationSoftware = SelectProgramDropdown.SelectedIndex;
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            SelectProgramDropdown.DataSource = SlideControl.supportedPrograms;
            SelectProgramDropdown.DisplayMember = "Name";
            SelectProgramDropdown.ValueMember = "StartProcess";
            SelectProgramDropdown.SelectedIndex = 0;
            UpdateTimer.Start();

        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ConnectButton.Text == "Connect")
            {
                ConnectButton.Enabled = false;
                CustomProcessTextBox.Enabled = false;
                SelectProgramDropdown.Enabled = false;
                ConnectButton.Text = "Connecting...";
                if (slidectl.connect())
                {
                    ConnectButton.Text = "Disconnect";
                    ConnectButton.Enabled = true;
                    CustomProcessTextBox.Enabled = false;
                    SelectProgramDropdown.Enabled = false;
                    Server_Communication.enabled = true;
                }
                else
                {
                    ConnectButton.Text = "Connection Failed";
                    ConnectButton.Enabled = true;
                    CustomProcessTextBox.Enabled = true;
                    SelectProgramDropdown.Enabled = true;
                }
            }
            else
            {
                ConnectButton.Text = "Connect";
                CustomProcessTextBox.Enabled = true;
                SelectProgramDropdown.Enabled = true;
                Server_Communication.enabled = false;
            }
            

        }

        private void CustomProcessTextBox_TextChanged(object sender, EventArgs e)
        {
            SlideControl.supportedPrograms[SelectProgramDropdown.SelectedIndex].ControlWindow = CustomProcessTextBox.Text;
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            Server_Communication.update();
        }

        private void PresentLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
