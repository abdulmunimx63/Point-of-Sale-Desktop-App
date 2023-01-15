
namespace POS.Winforms.Setting_s_UserControl
{
    partial class UC_BackupRestore
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBackupPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBackup = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRestorePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRestore = new Guna.UI2.WinForms.Guna2Button();
            this.btnBrow = new Guna.UI2.WinForms.Guna2Button();
            this.ElipseBackupRestore = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBackupPath);
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(34, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup Database";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBackupPath.DefaultText = "";
            this.txtBackupPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBackupPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBackupPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBackupPath.DisabledState.Parent = this.txtBackupPath;
            this.txtBackupPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBackupPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBackupPath.FocusedState.Parent = this.txtBackupPath;
            this.txtBackupPath.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtBackupPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBackupPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBackupPath.HoverState.Parent = this.txtBackupPath;
            this.txtBackupPath.Location = new System.Drawing.Point(29, 52);
            this.txtBackupPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.PasswordChar = '\0';
            this.txtBackupPath.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtBackupPath.PlaceholderText = "Select Path";
            this.txtBackupPath.SelectedText = "";
            this.txtBackupPath.ShadowDecoration.Parent = this.txtBackupPath;
            this.txtBackupPath.Size = new System.Drawing.Size(364, 36);
            this.txtBackupPath.TabIndex = 0;
            // 
            // btnBackup
            // 
            this.btnBackup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBackup.BorderThickness = 2;
            this.btnBackup.CheckedState.Parent = this.btnBackup;
            this.btnBackup.CustomImages.Parent = this.btnBackup;
            this.btnBackup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBackup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBackup.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBackup.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBackup.HoverState.Parent = this.btnBackup;
            this.btnBackup.Location = new System.Drawing.Point(412, 104);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ShadowDecoration.Parent = this.btnBackup;
            this.btnBackup.Size = new System.Drawing.Size(109, 36);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Backup";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBrowse.BorderThickness = 2;
            this.btnBrowse.CheckedState.Parent = this.btnBrowse;
            this.btnBrowse.CustomImages.Parent = this.btnBrowse;
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBrowse.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBrowse.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBrowse.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBrowse.HoverState.Parent = this.btnBrowse;
            this.btnBrowse.Location = new System.Drawing.Point(412, 52);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.ShadowDecoration.Parent = this.btnBrowse;
            this.btnBrowse.Size = new System.Drawing.Size(109, 36);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRestorePath);
            this.groupBox2.Controls.Add(this.btnRestore);
            this.groupBox2.Controls.Add(this.btnBrow);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(34, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 165);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore Database";
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRestorePath.DefaultText = "";
            this.txtRestorePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRestorePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRestorePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestorePath.DisabledState.Parent = this.txtRestorePath;
            this.txtRestorePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRestorePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestorePath.FocusedState.Parent = this.txtRestorePath;
            this.txtRestorePath.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtRestorePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRestorePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRestorePath.HoverState.Parent = this.txtRestorePath;
            this.txtRestorePath.Location = new System.Drawing.Point(29, 52);
            this.txtRestorePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.PasswordChar = '\0';
            this.txtRestorePath.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRestorePath.PlaceholderText = "Select Path";
            this.txtRestorePath.SelectedText = "";
            this.txtRestorePath.ShadowDecoration.Parent = this.txtRestorePath;
            this.txtRestorePath.Size = new System.Drawing.Size(364, 36);
            this.txtRestorePath.TabIndex = 0;
            // 
            // btnRestore
            // 
            this.btnRestore.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnRestore.BorderThickness = 2;
            this.btnRestore.CheckedState.Parent = this.btnRestore;
            this.btnRestore.CustomImages.Parent = this.btnRestore;
            this.btnRestore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnRestore.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnRestore.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRestore.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnRestore.HoverState.Parent = this.btnRestore;
            this.btnRestore.Location = new System.Drawing.Point(412, 105);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.ShadowDecoration.Parent = this.btnRestore;
            this.btnRestore.Size = new System.Drawing.Size(109, 36);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrow
            // 
            this.btnBrow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBrow.BorderThickness = 2;
            this.btnBrow.CheckedState.Parent = this.btnBrow;
            this.btnBrow.CustomImages.Parent = this.btnBrow;
            this.btnBrow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBrow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrow.ForeColor = System.Drawing.Color.White;
            this.btnBrow.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBrow.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBrow.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnBrow.HoverState.Parent = this.btnBrow;
            this.btnBrow.Location = new System.Drawing.Point(412, 52);
            this.btnBrow.Name = "btnBrow";
            this.btnBrow.ShadowDecoration.Parent = this.btnBrow;
            this.btnBrow.Size = new System.Drawing.Size(109, 36);
            this.btnBrow.TabIndex = 2;
            this.btnBrow.Text = "Browse";
            this.btnBrow.Click += new System.EventHandler(this.btnBrow_Click);
            // 
            // ElipseBackupRestore
            // 
            this.ElipseBackupRestore.BorderRadius = 0;
            this.ElipseBackupRestore.TargetControl = this;
            // 
            // UC_BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_BackupRestore";
            this.Size = new System.Drawing.Size(623, 387);
            this.Load += new System.EventHandler(this.UC_BackupRestore_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtBackupPath;
        private Guna.UI2.WinForms.Guna2Button btnBackup;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtRestorePath;
        private Guna.UI2.WinForms.Guna2Button btnRestore;
        private Guna.UI2.WinForms.Guna2Button btnBrow;
        private Guna.UI2.WinForms.Guna2Elipse ElipseBackupRestore;
    }
}
