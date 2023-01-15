using System;
using System.Data;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_UpdateItems : UserControl
    {
        functionality fn = new functionality();
        String query;

        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        // Fill UpdateOrderGridView with Data:
        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_items";
            lodaData(query);
            UpdateOrderGridView.Columns[0].Visible = false;
        }

        // Search Specific Item through name:
        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_items WHERE item_name LIKE '" + txtSearchItem.Text + "%' ";
            lodaData(query);
        }

        // Load Data Method:
        public void lodaData(String qur)
        {
            query = qur;
            DataSet ds = fn.getData(query);
            UpdateOrderGridView.DataSource = ds.Tables[0];
        }

        // Set Data to Text_Boxes from UpdateOrderGridView:
        int id;
        private void UpdateOrderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(UpdateOrderGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                String category = UpdateOrderGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                String name = UpdateOrderGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                int price = int.Parse(UpdateOrderGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

                txtCategory.Text = category;
                txtItemName.Text = name;
                txtPrice.Text = price.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Update Items:
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "UPDATE tbl_items SET item_category = '" + txtCategory.Text+"', item_name = '"+txtItemName.Text+"', item_price = '"+txtPrice.Text+ "' WHERE item_id = "+id+" ";
            fn.setData(query);

            String qry = "SELECT * FROM tbl_items";
            lodaData(qry);

            txtCategory.Clear();
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void UpdateOrderGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_UpdateItems_Enter(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_items";
            lodaData(query);
        }
    }
}
