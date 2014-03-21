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
            if (!Server_Communication.slideDown())
            {
                MessageBox.Show("Sorry, there seems to be an issue with our servers. Check your internet and try again.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NextSlideButton_Click(object sender, EventArgs e)
        {
            if (!Server_Communication.slideUp())
            {
                MessageBox.Show("Sorry, there seems to be an issue with our servers. Check your internet and try again.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
