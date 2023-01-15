using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.Winforms.Setting_s_UserControl
{
    public partial class UC_AddUser : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");

        public UC_AddUser()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUsername.Text != string.Empty && txtPass.Text != string.Empty && txtConfirmPass.Text != string.Empty)
                {
                    if (txtPass.Text == txtConfirmPass.Text)
                    {
                        con.Open();
                        String query = "INSERT INTO tbl_user (UserName,Password) VALUES ('" + txtUsername.Text + "','" + txtConfirmPass.Text + "')";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("New User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtUsername.Clear();
                        txtPass.Clear();
                        txtConfirmPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Password Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Enter All Required Fields", "Required Fields are Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
