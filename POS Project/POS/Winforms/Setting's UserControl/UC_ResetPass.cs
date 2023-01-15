using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.Winforms.Setting_s_UserControl
{
    public partial class UC_ResetPass : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");
            
        public UC_ResetPass()
        {
            InitializeComponent();
        }

        private void btnUpdatePass_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "SELECT Password FROM tbl_user WHERE Password = '" + txtCurrentPass.Text + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count.ToString() == "1")
                {
                    if (txtNewPass.Text == txtConfirmPass.Text)
                    {
                        con.Open();
                        String Query = "UPDATE tbl_user SET Password = '" + txtConfirmPass.Text + "' WHERE Password = '" + txtCurrentPass.Text + "' ";
                        SqlCommand cmd = new SqlCommand(Query, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Password Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        txtCurrentPass.Clear();
                        txtNewPass.Clear();
                        txtConfirmPass.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Password Not Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
