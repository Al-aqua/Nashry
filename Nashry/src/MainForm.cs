using System.Runtime.InteropServices;

namespace Nashry.src
{
    public partial class MainForm : Form
    {

        private Button? currentBtn;


        public MainForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                maxButton.Image = Properties.Resources.max2;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                maxButton.Image = Properties.Resources.max1;
                this.WindowState = FormWindowState.Normal;
            }
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

        private void DisableButton()
        {
            foreach (Control button in sidePanel.Controls)
            {
                if (button is Button)
                {
                    button.BackColor = Color.FromArgb(245, 249, 255);
                }
            }
        }

        private void ActiveButton(object btnSender)
        {
            if (currentBtn != btnSender)
            {
                DisableButton();
                currentBtn = (Button)btnSender;
                currentBtn.BackColor = Color.FromArgb(20, 148, 250);

            }
        }

        private void inDevButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void outDevButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void empButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void cusButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
    }
}
