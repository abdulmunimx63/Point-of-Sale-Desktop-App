
namespace POS.Winforms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.ExitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.btnBackupRestore = new Guna.UI2.WinForms.Guna2Button();
            this.btnResetPass = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ElipseBackupRestore = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseResetPass = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ElipseSettingWelcome = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_SettingWelcome1 = new POS.Winforms.Setting_s_UserControl.UC_SettingWelcome();
            this.uC_ResetPass1 = new POS.Winforms.Setting_s_UserControl.UC_ResetPass();
            this.uC_BackupRestore1 = new POS.Winforms.Setting_s_UserControl.UC_BackupRestore();
            this.uC_ResetPassword1 = new POS.Winforms.Setting_s_UserControl.UC_BackupRestore();
            this.ElipseAddUser = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_AddUser1 = new POS.Winforms.Setting_s_UserControl.UC_AddUser();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnAddUser);
            this.guna2Panel1.Controls.Add(this.ExitBtn);
            this.guna2Panel1.Controls.Add(this.btnBackupRestore);
            this.guna2Panel1.Controls.Add(this.btnResetPass);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(207, 407);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AutoRoundedCorners = true;
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.BorderRadius = 26;
            this.btnAddUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(12)))));
            this.btnAddUser.CheckedState.Parent = this.btnAddUser;
            this.btnAddUser.CustomImages.Parent = this.btnAddUser;
            this.btnAddUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.HoverState.Parent = this.btnAddUser;
            this.btnAddUser.Location = new System.Drawing.Point(23, 70);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.ShadowDecoration.Parent = this.btnAddUser;
            this.btnAddUser.Size = new System.Drawing.Size(211, 54);
            this.btnAddUser.TabIndex = 23;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor = System.Drawing.Color.Empty;
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.ExitBtn.Location = new System.Drawing.Point(170, 6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(32, 31);
            this.ExitBtn.TabIndex = 22;
            this.ExitBtn.UseTransparentBackground = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.AutoRoundedCorners = true;
            this.btnBackupRestore.BackColor = System.Drawing.Color.Transparent;
            this.btnBackupRestore.BorderRadius = 26;
            this.btnBackupRestore.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBackupRestore.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(12)))));
            this.btnBackupRestore.CheckedState.Parent = this.btnBackupRestore;
            this.btnBackupRestore.CustomImages.Parent = this.btnBackupRestore;
            this.btnBackupRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBackupRestore.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnBackupRestore.ForeColor = System.Drawing.Color.Black;
            this.btnBackupRestore.HoverState.Parent = this.btnBackupRestore;
            this.btnBackupRestore.Location = new System.Drawing.Point(23, 226);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.ShadowDecoration.Parent = this.btnBackupRestore;
            this.btnBackupRestore.Size = new System.Drawing.Size(211, 54);
            this.btnBackupRestore.TabIndex = 2;
            this.btnBackupRestore.Text = "Backup & Restore";
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // btnResetPass
            // 
            this.btnResetPass.AutoRoundedCorners = true;
            this.btnResetPass.BackColor = System.Drawing.Color.Transparent;
            this.btnResetPass.BorderRadius = 26;
            this.btnResetPass.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnResetPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(150)))), ((int)(((byte)(12)))));
            this.btnResetPass.CheckedState.Parent = this.btnResetPass;
            this.btnResetPass.CustomImages.Parent = this.btnResetPass;
            this.btnResetPass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnResetPass.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnResetPass.ForeColor = System.Drawing.Color.Black;
            this.btnResetPass.HoverState.Parent = this.btnResetPass;
            this.btnResetPass.Location = new System.Drawing.Point(23, 148);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.ShadowDecoration.Parent = this.btnResetPass;
            this.btnResetPass.Size = new System.Drawing.Size(211, 54);
            this.btnResetPass.TabIndex = 1;
            this.btnResetPass.Text = "Change Password";
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(207, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 10);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(207, 397);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 10);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(832, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 387);
            this.panel3.TabIndex = 6;
            // 
            // ElipseBackupRestore
            // 
            this.ElipseBackupRestore.BorderRadius = 0;
            this.ElipseBackupRestore.TargetControl = this;
            // 
            // ElipseResetPass
            // 
            this.ElipseResetPass.BorderRadius = 0;
            this.ElipseResetPass.TargetControl = this;
            // 
            // ElipseSettingWelcome
            // 
            this.ElipseSettingWelcome.BorderRadius = 0;
            this.ElipseSettingWelcome.TargetControl = this;
            // 
            // uC_SettingWelcome1
            // 
            this.uC_SettingWelcome1.BackColor = System.Drawing.Color.White;
            this.uC_SettingWelcome1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("uC_SettingWelcome1.BackgroundImage")));
            this.uC_SettingWelcome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_SettingWelcome1.Location = new System.Drawing.Point(207, 10);
            this.uC_SettingWelcome1.Name = "uC_SettingWelcome1";
            this.uC_SettingWelcome1.Size = new System.Drawing.Size(623, 387);
            this.uC_SettingWelcome1.TabIndex = 9;
            // 
            // uC_ResetPass1
            // 
            this.uC_ResetPass1.BackColor = System.Drawing.Color.White;
            this.uC_ResetPass1.Location = new System.Drawing.Point(207, 10);
            this.uC_ResetPass1.Name = "uC_ResetPass1";
            this.uC_ResetPass1.Size = new System.Drawing.Size(623, 387);
            this.uC_ResetPass1.TabIndex = 8;
            // 
            // uC_BackupRestore1
            // 
            this.uC_BackupRestore1.BackColor = System.Drawing.Color.White;
            this.uC_BackupRestore1.Location = new System.Drawing.Point(207, 10);
            this.uC_BackupRestore1.Name = "uC_BackupRestore1";
            this.uC_BackupRestore1.Size = new System.Drawing.Size(623, 387);
            this.uC_BackupRestore1.TabIndex = 7;
            // 
            // uC_ResetPassword1
            // 
            this.uC_ResetPassword1.BackColor = System.Drawing.Color.White;
            this.uC_ResetPassword1.Location = new System.Drawing.Point(208, 10);
            this.uC_ResetPassword1.Name = "uC_ResetPassword1";
            this.uC_ResetPassword1.Size = new System.Drawing.Size(623, 387);
            this.uC_ResetPassword1.TabIndex = 1;
            this.uC_ResetPassword1.Load += new System.EventHandler(this.uC_ResetPassword1_Load);
            // 
            // ElipseAddUser
            // 
            this.ElipseAddUser.BorderRadius = 0;
            this.ElipseAddUser.TargetControl = this;
            // 
            // uC_AddUser1
            // 
            this.uC_AddUser1.BackColor = System.Drawing.Color.White;
            this.uC_AddUser1.Location = new System.Drawing.Point(208, 10);
            this.uC_AddUser1.Name = "uC_AddUser1";
            this.uC_AddUser1.Size = new System.Drawing.Size(623, 387);
            this.uC_AddUser1.TabIndex = 10;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 407);
            this.Controls.Add(this.uC_AddUser1);
            this.Controls.Add(this.uC_SettingWelcome1);
            this.Controls.Add(this.uC_ResetPass1);
            this.Controls.Add(this.uC_BackupRestore1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnResetPass;
        private Guna.UI2.WinForms.Guna2Button btnBackupRestore;
        private Setting_s_UserControl.UC_BackupRestore uC_ResetPassword1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Elipse ElipseBackupRestore;
        private Setting_s_UserControl.UC_BackupRestore uC_BackupRestore1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseResetPass;
        private Setting_s_UserControl.UC_ResetPass uC_ResetPass1;
        private Guna.UI2.WinForms.Guna2Elipse ElipseSettingWelcome;
        private Setting_s_UserControl.UC_SettingWelcome uC_SettingWelcome1;
        private Guna.UI2.WinForms.Guna2Button ExitBtn;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
        private Guna.UI2.WinForms.Guna2Elipse ElipseAddUser;
        private Setting_s_UserControl.UC_AddUser uC_AddUser1;
    }
}