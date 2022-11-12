namespace Nashry.src
{
    partial class LoginForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.showPassButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.minButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.controlPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 344);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showPassButton);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.userNameTextBox);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(544, 314);
            this.panel2.TabIndex = 7;
            // 
            // showPassButton
            // 
            this.showPassButton.FlatAppearance.BorderSize = 0;
            this.showPassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassButton.Image = global::Nashry.Properties.Resources.eye;
            this.showPassButton.Location = new System.Drawing.Point(280, 141);
            this.showPassButton.Name = "showPassButton";
            this.showPassButton.Size = new System.Drawing.Size(23, 20);
            this.showPassButton.TabIndex = 4;
            this.showPassButton.UseVisualStyleBackColor = true;
            this.showPassButton.Click += new System.EventHandler(this.showPassButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(148)))), ((int)(((byte)(250)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(275, 176);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(261, 29);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "تسجيل الدخول";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.passwordTextBox.Location = new System.Drawing.Point(275, 136);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.PlaceholderText = "كلمة السر";
            this.passwordTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.passwordTextBox.Size = new System.Drawing.Size(225, 30);
            this.passwordTextBox.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Nashry.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(506, 136);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.userNameTextBox.Location = new System.Drawing.Point(275, 96);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.PlaceholderText = "اسم المستخدم";
            this.userNameTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameTextBox.Size = new System.Drawing.Size(225, 30);
            this.userNameTextBox.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Nashry.Properties.Resources.profile__1_;
            this.pictureBox2.Location = new System.Drawing.Point(506, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.label3.Location = new System.Drawing.Point(51, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "NASHRY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.label1.Location = new System.Drawing.Point(365, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "تسجيل الدخول";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Nashry.Properties.Resources.repairing__5_;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.controlPanel.Controls.Add(this.minButton);
            this.controlPanel.Controls.Add(this.closeButton);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(544, 30);
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
            this.minButton.TabIndex = 6;
            this.minButton.TabStop = false;
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
            this.closeButton.TabIndex = 5;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(40)))), ((int)(((byte)(67)))));
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel controlPanel;
        private Button minButton;
        private Button closeButton;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
        private Button showPassButton;
        private Button loginButton;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private Label label1;
    }
}