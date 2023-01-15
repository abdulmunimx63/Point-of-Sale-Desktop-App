using System;
using System.Data;
using System.Windows.Forms;

namespace POS.Winforms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        // Setting_Form Load Event:
        private void Settings_Load(object sender, EventArgs e)
        {
            uC_SettingWelcome1.Visible = true;
            uC_BackupRestore1.Visible = false;
            uC_ResetPass1.Visible = false;
            uC_AddUser1.Visible = false;
        }

        private void uC_ResetPassword1_Load(object sender, EventArgs e)
        {

        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            uC_BackupRestore1.Visible = true;
            uC_BackupRestore1.BringToFront();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            uC_ResetPass1.Visible = true;
            uC_ResetPass1.BringToFront();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            uC_AddUser1.Visible = true;
            uC_AddUser1.BringToFront();
        }
    }
}
