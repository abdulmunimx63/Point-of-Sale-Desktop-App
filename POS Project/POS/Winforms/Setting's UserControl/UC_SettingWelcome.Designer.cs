
namespace POS.Winforms.Setting_s_UserControl
{
    partial class UC_SettingWelcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SettingWelcome));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.ElipseSettingWelcome = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.label5.Location = new System.Drawing.Point(524, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 25;
            this.label5.Text = "ALOUSH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(562, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 33);
            this.label4.TabIndex = 24;
            this.label4.Text = "AT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "AL-ARBI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(93)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(477, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 41);
            this.label2.TabIndex = 27;
            this.label2.Text = "HAPPY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 20F);
            this.label3.Location = new System.Drawing.Point(512, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "MEAL";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Montserrat", 22F, System.Drawing.FontStyle.Bold);
            this.welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.welcome.Location = new System.Drawing.Point(363, 13);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(122, 41);
            this.welcome.TabIndex = 26;
            this.welcome.Text = "ENJOY";
            // 
            // ElipseSettingWelcome
            // 
            this.ElipseSettingWelcome.BorderRadius = 0;
            this.ElipseSettingWelcome.TargetControl = this;
            // 
            // UC_SettingWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "UC_SettingWelcome";
            this.Size = new System.Drawing.Size(623, 387);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label welcome;
        private Guna.UI2.WinForms.Guna2Elipse ElipseSettingWelcome;
    }
}
