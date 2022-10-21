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
using static System.Windows.Forms.DataFormats;

namespace Nashry.src
{
    public partial class LoginForm : Form
    {

        private bool isPasswordShowed = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void controlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void showPassButton_Click(object sender, EventArgs e)
        {
            if(isPasswordShowed)
            {
                showPassButton.Image = Properties.Resources.eye;
                isPasswordShowed = false;
            }
            else
            {
                showPassButton.Image = Properties.Resources.eye__1_;
                isPasswordShowed = true;

            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainFomr = new MainForm();
            mainFomr.Closed += (s, args) => this.Close();
            mainFomr.Show();
        }
    }
}
