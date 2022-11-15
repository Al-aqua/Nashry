using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nashry.src.Forms
{
    public partial class Settings : Form
    {

        private Button? currentBtn;
        private new Form? ActiveForm;

        public Settings()
        {
            InitializeComponent();
        }

        private void DisableButton()
        {
            foreach (Control button in topPanel.Controls)
            {
                if (button is Button)
                    button.BackColor = Color.FromArgb(11, 19, 32);
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

        private void cusButton_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new CusAccountsForm(), sender);
        }

        private void empButton_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new EmpAccountsForm(), sender);
        }

        private void devButton_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new DevInfoForm(), sender);
        }
    }
}
