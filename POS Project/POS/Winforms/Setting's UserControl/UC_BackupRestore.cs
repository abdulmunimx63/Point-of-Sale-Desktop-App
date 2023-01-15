using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.Winforms.Setting_s_UserControl
{
    public partial class UC_BackupRestore : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");

        public UC_BackupRestore()
        {
            InitializeComponent();
        }

        // Browse Folder_Dialouge for Backup:
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtBackupPath.Text = fbd.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        // Create Database Backup:
        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "BACKUP DATABASE [" + con.Database + "] TO  DISK = N'" + txtBackupPath.Text + "\\" + con.Database + ".bak'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Backup Creat Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBackupPath.Clear();
                btnBackup.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Open File_Dialouge for Restore:
        private void btnBrow_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Backup File(*.bak) | *.bak";
            ofd.Title = "Select Backup File";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                txtRestorePath.Text = ofd.FileName;
                btnRestore.Enabled = true;
            }
        }

        // Restore Database Backup:
        private void btnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String query = "USE [master] RESTORE DATABASE["+con.Database+"] FROM DISK = N'"+txtRestorePath.Text+"' WITH FILE = 1; ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Database Restore Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRestorePath.Clear();
                btnRestore.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UC_BackupRestore_Load(object sender, EventArgs e)
        {
            btnRestore.Enabled = false;
            btnBackup.Enabled = false;
        }
    }
}
