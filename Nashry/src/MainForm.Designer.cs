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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.reportsButton = new System.Windows.Forms.Button();
            this.cusButton = new System.Windows.Forms.Button();
            this.empButton = new System.Windows.Forms.Button();
            this.outDevButton = new System.Windows.Forms.Button();
            this.inDevButton = new System.Windows.Forms.Button();
            this.controlPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.controlPanel.Controls.Add(this.minButton);
            this.controlPanel.Controls.Add(this.maxButton);
            this.controlPanel.Controls.Add(this.closeButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(10, 10);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(882, 30);
            this.controlPanel.TabIndex = 1;
            this.controlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlPanel_MouseDown);
            // 
            // minButton
            // 
            this.minButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.minButton.FlatAppearance.BorderSize = 0;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Image = global::Nashry.Properties.Resources.min;
            this.minButton.Location = new System.Drawing.Point(60, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(30, 30);
            this.minButton.TabIndex = 2;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.maxButton.FlatAppearance.BorderSize = 0;
            this.maxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxButton.Image = global::Nashry.Properties.Resources.max1;
            this.maxButton.Location = new System.Drawing.Point(30, 0);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(30, 30);
            this.maxButton.TabIndex = 1;
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
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
            this.closeButton.TabIndex = 0;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.sidePanel.Controls.Add(this.logoutButton);
            this.sidePanel.Controls.Add(this.reportsButton);
            this.sidePanel.Controls.Add(this.cusButton);
            this.sidePanel.Controls.Add(this.empButton);
            this.sidePanel.Controls.Add(this.outDevButton);
            this.sidePanel.Controls.Add(this.inDevButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel.Location = new System.Drawing.Point(642, 40);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Padding = new System.Windows.Forms.Padding(10);
            this.sidePanel.Size = new System.Drawing.Size(250, 532);
            this.sidePanel.TabIndex = 2;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatAppearance.BorderSize = 0;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.logoutButton.Location = new System.Drawing.Point(10, 462);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(230, 60);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "تسجيل الخروج";
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.reportsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.reportsButton.Location = new System.Drawing.Point(10, 250);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(230, 60);
            this.reportsButton.TabIndex = 4;
            this.reportsButton.Text = "التقارير";
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // cusButton
            // 
            this.cusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.cusButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.cusButton.FlatAppearance.BorderSize = 0;
            this.cusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.cusButton.Location = new System.Drawing.Point(10, 190);
            this.cusButton.Name = "cusButton";
            this.cusButton.Size = new System.Drawing.Size(230, 60);
            this.cusButton.TabIndex = 3;
            this.cusButton.Text = "حسابات التجار";
            this.cusButton.UseVisualStyleBackColor = false;
            this.cusButton.Click += new System.EventHandler(this.cusButton_Click);
            // 
            // empButton
            // 
            this.empButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.empButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.empButton.FlatAppearance.BorderSize = 0;
            this.empButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.empButton.Location = new System.Drawing.Point(10, 130);
            this.empButton.Name = "empButton";
            this.empButton.Size = new System.Drawing.Size(230, 60);
            this.empButton.TabIndex = 2;
            this.empButton.Text = "العمال";
            this.empButton.UseVisualStyleBackColor = false;
            this.empButton.Click += new System.EventHandler(this.empButton_Click);
            // 
            // outDevButton
            // 
            this.outDevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.outDevButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.outDevButton.FlatAppearance.BorderSize = 0;
            this.outDevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outDevButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outDevButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.outDevButton.Location = new System.Drawing.Point(10, 70);
            this.outDevButton.Name = "outDevButton";
            this.outDevButton.Size = new System.Drawing.Size(230, 60);
            this.outDevButton.TabIndex = 1;
            this.outDevButton.Text = "البضاعة المسلم";
            this.outDevButton.UseVisualStyleBackColor = false;
            this.outDevButton.Click += new System.EventHandler(this.outDevButton_Click);
            // 
            // inDevButton
            // 
            this.inDevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.inDevButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.inDevButton.FlatAppearance.BorderSize = 0;
            this.inDevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inDevButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inDevButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.inDevButton.Location = new System.Drawing.Point(10, 10);
            this.inDevButton.Name = "inDevButton";
            this.inDevButton.Size = new System.Drawing.Size(230, 60);
            this.inDevButton.TabIndex = 0;
            this.inDevButton.Text = "البضاعة الواصل";
            this.inDevButton.UseVisualStyleBackColor = false;
            this.inDevButton.Click += new System.EventHandler(this.inDevButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(902, 582);
            this.ControlBox = false;
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.controlPanel);
            this.MinimumSize = new System.Drawing.Size(920, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.controlPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel controlPanel;
        private Panel sidePanel;
        private Button closeButton;
        private Button minButton;
        private Button maxButton;
        private Button logoutButton;
        private Button reportsButton;
        private Button cusButton;
        private Button empButton;
        private Button outDevButton;
        private Button inDevButton;
    }
}