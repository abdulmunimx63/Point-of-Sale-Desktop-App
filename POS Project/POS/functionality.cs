using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS
{
    class functionality
    {
        // Database Connection:
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True";
            return con;
        }

        // Fetch Data From DB:
        public DataSet getData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }

        // Insert Data Into DB:
        public void setData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            // Acknowledgement Msg For User:
            MessageBox.Show("Data Processed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Function Overload [Insert Data Into DB]:
        public void setData(string query, int id)
        {
            if (query == "DELETE FROM tbl_items WHERE item_id = " + id + " " || query == "DELETE FROM tbl_workers WHERE worker_id = " + id + " ")
            {
                if(MessageBox.Show("Delete Item ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    SqlConnection con = getConnection();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

    }
}
