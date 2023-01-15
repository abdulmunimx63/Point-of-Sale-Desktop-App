using System;
using System.Data;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_RemoveItems : UserControl
    {
        functionality fn = new functionality();
        String query;

        public UC_RemoveItems()
        {
            InitializeComponent();
        }

        // Fill DeleteOrderGridView with Data on Load Event:
        private void UC_RemoveItems_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_items";
            lodaData(query);
            DeleteOrderGridView.Columns[0].Visible = false;
        }

        // Load Data Method:
        public void lodaData(String qry)
        {
            query = qry;
            DataSet ds = fn.getData(query);
            DeleteOrderGridView.DataSource = ds.Tables[0];
        }

        // Search Specific Item through name:
        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_items WHERE item_name LIKE '" + txtSearchItem.Text + "%' ";
            lodaData(query);
        }

        // Catch id from DeleteOrderGridView to Delete Record:
        int id;
        private void DeleteOrderGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(DeleteOrderGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        // Remove Items:
        private void btnRemove_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM tbl_items WHERE item_id = "+id+" ";
            fn.setData(query, id);

            String qry = "SELECT * FROM tbl_items";
            lodaData(qry);
        }

        private void UC_RemoveItems_Enter(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_items";
            lodaData(query);
        }
    }
}
