
namespace POS.Winforms.Setting_s_UserControl
{
    partial class UC_ResetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ResetPass));
            this.txtCurrentPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdatePass = new Guna.UI2.WinForms.Guna2Button();
            this.txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.ElipseResetPass = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrentPass.BorderColor = System.Drawing.Color.Gray;
            this.txtCurrentPass.BorderThickness = 2;
            this.txtCurrentPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentPass.DefaultText = "";
            this.txtCurrentPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrentPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrentPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPass.DisabledState.Parent = this.txtCurrentPass;
            this.txtCurrentPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrentPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtCurrentPass.FocusedState.Parent = this.txtCurrentPass;
            this.txtCurrentPass.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtCurrentPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtCurrentPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtCurrentPass.HoverState.Parent = this.txtCurrentPass;
            this.txtCurrentPass.Location = new System.Drawing.Point(294, 78);
            this.txtCurrentPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.PasswordChar = '*';
            this.txtCurrentPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCurrentPass.PlaceholderText = "Current Password";
            this.txtCurrentPass.SelectedText = "";
            this.txtCurrentPass.ShadowDecoration.Parent = this.txtCurrentPass;
            this.txtCurrentPass.Size = new System.Drawing.Size(291, 36);
            this.txtCurrentPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCurrentPass.TabIndex = 0;
            this.txtCurrentPass.UseSystemPasswordChar = true;
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnUpdatePass.BorderThickness = 2;
            this.btnUpdatePass.CheckedState.Parent = this.btnUpdatePass;
            this.btnUpdatePass.CustomImages.Parent = this.btnUpdatePass;
            this.btnUpdatePass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnUpdatePass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePass.ForeColor = System.Drawing.Color.White;
            this.btnUpdatePass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnUpdatePass.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdatePass.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnUpdatePass.HoverState.Parent = this.btnUpdatePass;
            this.btnUpdatePass.Location = new System.Drawing.Point(446, 270);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.ShadowDecoration.Parent = this.btnUpdatePass;
            this.btnUpdatePass.Size = new System.Drawing.Size(139, 42);
            this.btnUpdatePass.TabIndex = 3;
            this.btnUpdatePass.Text = "Update";
            this.btnUpdatePass.Click += new System.EventHandler(this.btnUpdatePass_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPass.BorderColor = System.Drawing.Color.Gray;
            this.txtNewPass.BorderThickness = 2;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.DefaultText = "";
            this.txtNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.DisabledState.Parent = this.txtNewPass;
            this.txtNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtNewPass.FocusedState.Parent = this.txtNewPass;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtNewPass.HoverState.Parent = this.txtNewPass;
            this.txtNewPass.Location = new System.Drawing.Point(294, 135);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtNewPass.PlaceholderText = "New Password";
            this.txtNewPass.SelectedText = "";
            this.txtNewPass.ShadowDecoration.Parent = this.txtNewPass;
            this.txtNewPass.Size = new System.Drawing.Size(291, 36);
            this.txtNewPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPass.BorderColor = System.Drawing.Color.Gray;
            this.txtConfirmPass.BorderThickness = 2;
            this.txtConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtConfirmPass.DefaultText = "";
            this.txtConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.DisabledState.Parent = this.txtConfirmPass;
            this.txtConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtConfirmPass.FocusedState.Parent = this.txtConfirmPass;
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtConfirmPass.HoverState.Parent = this.txtConfirmPass;
            this.txtConfirmPass.Location = new System.Drawing.Point(294, 193);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtConfirmPass.PlaceholderText = "Confirm Password";
            this.txtConfirmPass.SelectedText = "";
            this.txtConfirmPass.ShadowDecoration.Parent = this.txtConfirmPass;
            this.txtConfirmPass.Size = new System.Drawing.Size(291, 36);
            this.txtConfirmPass.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtConfirmPass.TabIndex = 2;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // ElipseResetPass
            // 
            this.ElipseResetPass.BorderRadius = 0;
            this.ElipseResetPass.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UC_ResetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtCurrentPass);
            this.Controls.Add(this.btnUpdatePass);
            this.Name = "UC_ResetPass";
            this.Size = new System.Drawing.Size(623, 387);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtCurrentPass;
        private Guna.UI2.WinForms.Guna2Button btnUpdatePass;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPass;
        private Guna.UI2.WinForms.Guna2Elipse ElipseResetPass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
