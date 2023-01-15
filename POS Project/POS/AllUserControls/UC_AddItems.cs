using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace POS.AllUserControls
{
    public partial class UC_AddItems : UserControl
    {
        functionality fn = new functionality();
        string query;

        public UC_AddItems()
        {
            InitializeComponent();
            fillCategoryList();
        }

        // Dinamically Populate Category_ComboBox with Data:
        public void fillCategoryList()
        {
            txtCategory.Items.Clear();
            SqlConnection con = fn.getConnection();
            String qry = "SELECT DISTINCT item_category FROM tbl_items";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader sdr;
            try
            {
                con.Open();
                sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    String category = sdr.GetString(0);
                    txtCategory.Items.Add(category);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO tbl_items (item_category,item_name,item_price) VALUES ('" + txtCategory.Text + "','" + txtItemName.Text + "'," + txtPrice.Text + ")";
                fn.setData(query);
                clearAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddItems_Load(object sender, EventArgs e)
        {
            //Empty:
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            //Empty:
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Empty:
        }

        private void btnAddNewCategory_Click(object sender, EventArgs e)
        {
            if (txtAddNewCategory.Text != string.Empty)
            {
                query = "INSERT INTO tbl_items (item_category) VALUES ('" + txtAddNewCategory.Text + "')";
                fn.setData(query);
                txtAddNewCategory.Clear();

                fillCategoryList();
            }
            else
            {
                MessageBox.Show("Please Enter Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UC_AddItems_Enter(object sender, EventArgs e)
        {
            fillCategoryList();
        }
    }
}
