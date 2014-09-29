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
            if (Server_Communication.joinSession())
            {
                this.Hide();
                PresentationInterface interfaceWindow = new PresentationInterface();
                interfaceWindow.ShowDialog();
                this.Show();
                reset();
                SlideControl.currentSlide = 5000;
            }
            else
            {
                MessageBox.Show("Sorry, there seems to be an issue with that token. Please get a new token from the control app.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset();
            }
        }

        private void reset()
        {
            token1.Text = "";
            token2.Text = "";
            token3.Text = "";
            token4.Text = "";
            token5.Text = "";
            token6.Text = "";
            token1.Select();
            Server_Communication.reset();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Server_Communication.setupUid();
            token1.Select();
            float dpiX = 96, dpiY = 96;
            using (Graphics graphics = this.CreateGraphics())
            {
                dpiX = graphics.DpiX;
                dpiY = graphics.DpiY;
            }

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

            if (token1.Text != "" && token2.Text != "" && token3.Text != "" && token4.Text != "" && token5.Text != "" && token6.Text != "" && Server_Communication.serverAvailable)
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

        private void ServerTimer_Tick(object sender, EventArgs e)
        {
            Server_Communication.checkStatus();
            if (Server_Communication.serverAvailable)
            {
                PresentButton.Text = "Click to start!";
                ControlToken.Text = Server_Communication.temptoken.ToString();
                switch (Server_Communication.controlmode)
                {
                    case 0:
                        ControlButton.Text = "Connecting...";
                        ControlButton.Enabled = false;
                        Server_Communication.temptoken = 0;
                        break;
                    case 1:
                        ControlButton.Text = "Waiting...";
                        ControlButton.Enabled = false;
                        break;
                    case 2:
                        ControlButton.Text = "Click to start!";
                        ControlButton.Enabled = true;
                        break;
                }
                
            }
            else
            {
                PresentButton.Text = "Connecting...";
                ControlButton.Text = "Connecting...";
                ControlButton.Enabled = false;
            }
            validate();
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            Server_Communication.token = Server_Communication.temptoken;
            this.Hide();
            ControlInterface interfaceWindow = new ControlInterface();
            interfaceWindow.ShowDialog();
            reset();
            this.Show();
        }
    }
}
