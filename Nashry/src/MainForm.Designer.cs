namespace Nashry.src
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.chiledPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.usernameButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.custButton = new System.Windows.Forms.Button();
            this.empButton = new System.Windows.Forms.Button();
            this.outDevButton = new System.Windows.Forms.Button();
            this.inDevButton = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.chiledPanel);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.controlPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1276, 716);
            this.panel1.TabIndex = 0;
            // 
            // chiledPanel
            // 
            this.chiledPanel.BackColor = System.Drawing.Color.Transparent;
            this.chiledPanel.Location = new System.Drawing.Point(10, 40);
            this.chiledPanel.Name = "chiledPanel";
            this.chiledPanel.Size = new System.Drawing.Size(996, 666);
            this.chiledPanel.TabIndex = 2;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.sidePanel.Controls.Add(this.usernameButton);
            this.sidePanel.Controls.Add(this.logoutButton);
            this.sidePanel.Controls.Add(this.reportsButton);
            this.sidePanel.Controls.Add(this.custButton);
            this.sidePanel.Controls.Add(this.empButton);
            this.sidePanel.Controls.Add(this.outDevButton);
            this.sidePanel.Controls.Add(this.inDevButton);
            this.sidePanel.Location = new System.Drawing.Point(1016, 40);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(250, 666);
            this.sidePanel.TabIndex = 1;
            // 
            // usernameButton
            // 
            this.usernameButton.BackColor = System.Drawing.Color.Transparent;
            this.usernameButton.FlatAppearance.BorderSize = 0;
            this.usernameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.usernameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.usernameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.usernameButton.Image = global::Nashry.Properties.Resources.profile;
            this.usernameButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.usernameButton.Location = new System.Drawing.Point(10, 10);
            this.usernameButton.Name = "usernameButton";
            this.usernameButton.Padding = new System.Windows.Forms.Padding(35, 0, 35, 0);
            this.usernameButton.Size = new System.Drawing.Size(230, 50);
            this.usernameButton.TabIndex = 6;
            this.usernameButton.Text = "اسم المستخدم";
            this.usernameButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.usernameButton.UseVisualStyleBackColor = false;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.logoutButton.Location = new System.Drawing.Point(10, 606);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(230, 50);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "تسجيل الخروج";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.reportsButton.Location = new System.Drawing.Point(10, 350);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(230, 50);
            this.reportsButton.TabIndex = 4;
            this.reportsButton.Text = "التقارير";
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // custButton
            // 
            this.custButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.custButton.FlatAppearance.BorderSize = 0;
            this.custButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.custButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.custButton.Location = new System.Drawing.Point(10, 290);
            this.custButton.Name = "custButton";
            this.custButton.Size = new System.Drawing.Size(230, 50);
            this.custButton.TabIndex = 3;
            this.custButton.Text = "حسابات التجار";
            this.custButton.UseVisualStyleBackColor = false;
            this.custButton.Click += new System.EventHandler(this.cusButton_Click);
            // 
            // empButton
            // 
            this.empButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.empButton.FlatAppearance.BorderSize = 0;
            this.empButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.empButton.Location = new System.Drawing.Point(10, 230);
            this.empButton.Name = "empButton";
            this.empButton.Size = new System.Drawing.Size(230, 50);
            this.empButton.TabIndex = 2;
            this.empButton.Text = "العمال";
            this.empButton.UseVisualStyleBackColor = false;
            this.empButton.Click += new System.EventHandler(this.empButton_Click);
            // 
            // outDevButton
            // 
            this.outDevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.outDevButton.FlatAppearance.BorderSize = 0;
            this.outDevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outDevButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outDevButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.outDevButton.Location = new System.Drawing.Point(10, 170);
            this.outDevButton.Name = "outDevButton";
            this.outDevButton.Size = new System.Drawing.Size(230, 50);
            this.outDevButton.TabIndex = 1;
            this.outDevButton.Text = "البضاعة المسلم";
            this.outDevButton.UseVisualStyleBackColor = false;
            this.outDevButton.Click += new System.EventHandler(this.outDevButton_Click);
            // 
            // inDevButton
            // 
            this.inDevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.inDevButton.FlatAppearance.BorderSize = 0;
            this.inDevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inDevButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inDevButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.inDevButton.Location = new System.Drawing.Point(10, 110);
            this.inDevButton.Name = "inDevButton";
            this.inDevButton.Size = new System.Drawing.Size(230, 50);
            this.inDevButton.TabIndex = 0;
            this.inDevButton.Text = "البضاعة الواصل";
            this.inDevButton.UseVisualStyleBackColor = false;
            this.inDevButton.Click += new System.EventHandler(this.inDevButton_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.controlPanel.Controls.Add(this.settingButton);
            this.controlPanel.Controls.Add(this.minButton);
            this.controlPanel.Controls.Add(this.closeButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(1276, 30);
            this.controlPanel.TabIndex = 0;
            this.controlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseDown);
            // 
            // minButton
            // 
            this.minButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Image = global::Nashry.Properties.Resources.min;
            this.minButton.Location = new System.Drawing.Point(30, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.TabIndex = 4;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Image = global::Nashry.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(0, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Image = global::Nashry.Properties.Resources.setting;
            this.settingButton.Location = new System.Drawing.Point(1246, 0);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(30, 30);
            this.settingButton.TabIndex = 5;
            this.settingButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormv2";
            this.panel1.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel controlPanel;
        private Button closeButton;
        private Button minButton;
        private Panel sidePanel;
        private Button inDevButton;
        private Button empButton;
        private Button outDevButton;
        private Button usernameButton;
        private Button logoutButton;
        private Button reportsButton;
        private Button custButton;
        private Panel chiledPanel;
        private Button settingButton;
    }
}