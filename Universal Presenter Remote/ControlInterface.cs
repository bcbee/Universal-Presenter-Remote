using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Universal_Presenter_Remote
{
    public partial class ControlInterface : Form
    {
        public ControlInterface()
        {
            InitializeComponent();
        }

        private void PreviousSlideButton_Click(object sender, EventArgs e)
        {
            if (!Server_Communication.sendCommand("SlideDown"))
            {
                MessageBox.Show("Sorry, there seems to be an issue with our servers. Check your internet and try again.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NextSlideButton_Click(object sender, EventArgs e)
        {
            if (!Server_Communication.sendCommand("SlideUp"))
            {
                MessageBox.Show("Sorry, there seems to be an issue with our servers. Check your internet and try again.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PlayMedia_Click(object sender, EventArgs e)
        {
            if (!Server_Communication.sendCommand("PlayMedia"))
            {
                MessageBox.Show("Sorry, there seems to be an issue with our servers. Check your internet and try again.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ControlInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
