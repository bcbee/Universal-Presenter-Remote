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
            slidectl.slidebackward();
        }

        private void ManualForward_Click(object sender, EventArgs e)
        {
            slidectl.slideforward();
        }

        private void SelectProgramDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            slidectl.presentationSoftware = this.SelectProgramDropdown.SelectedIndex;
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            this.SelectProgramDropdown.DataSource = slidectl.supportedPrograms;
            this.SelectProgramDropdown.DisplayMember = "Name";
            this.SelectProgramDropdown.ValueMember = "StartProcess";
            this.SelectProgramDropdown.SelectedIndex = 0;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (this.ConnectButton.Text == "Connect")
            {
                this.ConnectButton.Enabled = false;
                this.ConnectButton.Text = "Connecting...";
                if (this.slidectl.connect())
                {
                    this.ConnectButton.Text = "Disconnect";
                    this.ConnectButton.Enabled = true;
                    this.ManualForward.Enabled = true;
                    this.ManualBack.Enabled = true;
                }
                else
                {
                    this.ConnectButton.Text = "Connection Failed";
                    this.ConnectButton.Enabled = true;
                    this.ManualForward.Enabled = false;
                    this.ManualBack.Enabled = false;
                }
            }
            else
            {
                this.ConnectButton.Text = "Connect";
                this.ManualForward.Enabled = false;
                this.ManualBack.Enabled = false;
            }
            

        }
    }
}
