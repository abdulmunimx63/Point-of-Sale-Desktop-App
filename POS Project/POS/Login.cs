using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // for testing purpose:
        }

        // LOGIN Button:
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (isFormValid())
            {
                if (checkLogin())
                {
                    Dashboard ds = new Dashboard("Admin");
                    this.Hide();
                    ds.Show();
                }
            }
        }

        // Verify Login Credentials:
        private bool checkLogin()
        {
            functionality fn = new functionality();
            SqlConnection con = fn.getConnection();

            string query = "SELECT * FROM tbl_user WHERE UserName = '" + txtUsername.Text.Trim() + "' AND Password = '" + txtPassword.Text.Trim() + "'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect.", "Incorrect Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Login Form Validation:
        private bool isFormValid()
        {
            if(txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Required Fields are Empty.", "Please Fill All Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }
    }
}
