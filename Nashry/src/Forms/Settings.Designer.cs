namespace Nashry.src.Forms
{
    partial class Settings
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.cusButton = new System.Windows.Forms.Button();
            this.empButton = new System.Windows.Forms.Button();
            this.devButton = new System.Windows.Forms.Button();
            this.chiledPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.cusButton);
            this.topPanel.Controls.Add(this.empButton);
            this.topPanel.Controls.Add(this.devButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(10, 10);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(976, 30);
            this.topPanel.TabIndex = 0;
            // 
            // cusButton
            // 
            this.cusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.cusButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.cusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cusButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cusButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.cusButton.Location = new System.Drawing.Point(650, 0);
            this.cusButton.Name = "cusButton";
            this.cusButton.Size = new System.Drawing.Size(325, 30);
            this.cusButton.TabIndex = 2;
            this.cusButton.Text = "حسابات التجار";
            this.cusButton.UseVisualStyleBackColor = false;
            this.cusButton.Click += new System.EventHandler(this.cusButton_Click);
            // 
            // empButton
            // 
            this.empButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.empButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.empButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.empButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.empButton.Location = new System.Drawing.Point(325, 0);
            this.empButton.Name = "empButton";
            this.empButton.Size = new System.Drawing.Size(325, 30);
            this.empButton.TabIndex = 1;
            this.empButton.Text = "حسابات العمال";
            this.empButton.UseVisualStyleBackColor = false;
            this.empButton.Click += new System.EventHandler(this.empButton_Click);
            // 
            // devButton
            // 
            this.devButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.devButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.devButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.devButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.devButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.devButton.Location = new System.Drawing.Point(0, 0);
            this.devButton.Name = "devButton";
            this.devButton.Size = new System.Drawing.Size(325, 30);
            this.devButton.TabIndex = 0;
            this.devButton.Text = "الاجهزة";
            this.devButton.UseVisualStyleBackColor = false;
            this.devButton.Click += new System.EventHandler(this.devButton_Click);
            // 
            // chiledPanel
            // 
            this.chiledPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chiledPanel.Location = new System.Drawing.Point(10, 40);
            this.chiledPanel.Name = "chiledPanel";
            this.chiledPanel.Padding = new System.Windows.Forms.Padding(10);
            this.chiledPanel.Size = new System.Drawing.Size(976, 616);
            this.chiledPanel.TabIndex = 1;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(996, 666);
            this.Controls.Add(this.chiledPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Settings";
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel topPanel;
        private Button devButton;
        private Button cusButton;
        private Button empButton;
        private Panel chiledPanel;
    }
}