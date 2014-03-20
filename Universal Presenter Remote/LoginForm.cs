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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Present_Click(object sender, EventArgs e)
        {
            this.Hide();
            PresentationInterface interfaceWindow = new PresentationInterface();
            interfaceWindow.ShowDialog();
            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            token1.Select();
        }

        private void JumpInWelcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void token1_TextChanged(object sender, EventArgs e)
        {
            token2.Select();
            validate();
        }

        private void token2_TextChanged(object sender, EventArgs e)
        {
            token3.Select();
            validate();
        }

        private void token3_TextChanged(object sender, EventArgs e)
        {
            token4.Select();
            validate();
        }

        private void token4_TextChanged(object sender, EventArgs e)
        {
            token5.Select();
            validate();
        }

        private void token5_TextChanged(object sender, EventArgs e)
        {
            token6.Select();
            validate();
        }

        private void token6_TextChanged(object sender, EventArgs e)
        {
            validate();
            PresentButton.Select();
        }

        private void validate()
        {
            bool cont = false;
            int t = 0;

            if (token1.Text != "" && token2.Text != "" && token3.Text != "" && token4.Text != "" && token5.Text != "" && token6.Text != "")
            {
                string token = token1.Text + token2.Text + token3.Text + token4.Text + token5.Text + token6.Text;
                cont = true;
                try
                {
                    t = Int32.Parse(token);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    cont = false;
                }
            }
            else
            {
                cont = false;
            }

            if (cont)
            {
                Server_Communication.token = t;
                PresentButton.Enabled = true;
            }
            else
            {
                PresentButton.Enabled = false;
            }
        }
    }
}
