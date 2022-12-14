using Nashry.src.Forms;
using System.Runtime.InteropServices;

namespace Nashry.src
{
    public partial class MainForm : Form
    {

        private Button? currentBtn;
        private new Form? ActiveForm;

        public MainForm()
        {
            Icon = Properties.Resources.repairingIcon;
            InitializeComponent();
        }

        private void DisableButton()
        {
            foreach (Control button in sidePanel.Controls)
            {
                if (button is Button && button.Name != usernameButton.Name)
                {
                    button.BackColor = Color.FromArgb(245, 249, 255);
                }
                else if (button.Name == usernameButton.Name)
                {
                    button.BackColor = Color.FromArgb(11, 19, 32);
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

        private void OpenChiledForm(Form chiled, object sender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveButton(sender);
            ActiveForm = chiled;
            chiled.TopLevel = false;
            chiled.FormBorderStyle = FormBorderStyle.None;
            chiled.Dock = DockStyle.Fill;
            this.chiledPanel.Controls.Add(chiled);
            this.chiledPanel.Tag = chiled;
            chiled.BringToFront();
            chiled.Show();
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

        private void inDevButton_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new Forms.InDevForm(), sender);
        }

        private void empButton_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new Forms.EmpForm(), sender);
        }

        private void cusButton_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new Forms.CustForm(), sender);
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new Forms.ReportsForm(), sender);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginFrom = new LoginForm();
            loginFrom.Closed += (s, args) => this.Close();
            loginFrom.Show();
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new Forms.Settings(), sender);
            settingButton.BackColor = Color.FromArgb(11, 19, 32);
        }

        private void usernameButton_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new UserAccountsForm(), sender);
        }
    }
}
