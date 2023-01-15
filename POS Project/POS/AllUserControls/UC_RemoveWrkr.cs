using System;
using System.Data;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_RemoveWrkr : UserControl
    {
        functionality fn = new functionality();
        String query;

        public UC_RemoveWrkr()
        {
            InitializeComponent();
        }

        // Remove Worker:
        private void btnRemove_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM tbl_workers WHERE worker_id = "+id+" ";
            fn.setData(query, id);

            String qry = "SELECT * FROM tbl_workers";
            lodaData(qry);
        }

        // Fill DeleteOrderGridView with Data on Load Event:
        private void UC_RemoveWrkr_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_workers";
            lodaData(query);
            RemoveWorkerGridView.Columns[0].Visible = false;
        }

        // Load Data Method:
        public void lodaData(String qry)
        {
            query = qry;
            DataSet ds = fn.getData(query);
            RemoveWorkerGridView.DataSource = ds.Tables[0];
        }

        // Search Specific Worker through name:
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_workers WHERE full_name LIKE '" + txtSearchName.Text + "%' ";
            lodaData(query);
        }

        // Catch id from RemoveWorkerGridView to Delete Worker:
        int id;
        private void RemoveWorkerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(RemoveWorkerGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void UC_RemoveWrkr_Enter(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_workers";
            lodaData(query);
        }
    }
}
