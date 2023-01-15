using System;
using System.Data;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_UpdatWrkr : UserControl
    {
        functionality fn = new functionality();
        String query;

        public UC_UpdatWrkr()
        {
            InitializeComponent();
        }

        private void UC_UpdatWrkr_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_workers";
            DataSet ds = fn.getData(query);
            UpdateWorkersGridView.DataSource = ds.Tables[0];
            UpdateWorkersGridView.Columns[0].Visible = false;
        }

        // Search Specific Worker through name:
        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_workers WHERE full_name LIKE '" + txtSearchName.Text + "%' ";
            lodaData(query);
        }

        private void lodaData(string qur)
        {
            query = qur;
            DataSet ds = fn.getData(query);
            UpdateWorkersGridView.DataSource = ds.Tables[0];
        }

        // Set Data to Text_Boxes from UpdateWorkerGridView:
        int id;
        private void UpdateWorkersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(UpdateWorkersGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            String name = UpdateWorkersGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            String age = UpdateWorkersGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            String contact = UpdateWorkersGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            String salary = UpdateWorkersGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            String job_status = UpdateWorkersGridView.Rows[e.RowIndex].Cells[6].Value.ToString();

            txtFullName.Text = name;
            txtAge.Text = age;
            txtContact.Text = contact;
            txtSalary.Text = salary;
            txtStatus.Text = job_status;
        }

        // Update Workers:
        private void btnUpdateWorker_Click(object sender, EventArgs e)
        {
            query = "UPDATE tbl_workers SET full_name = '" + txtFullName.Text + "', age = " + txtAge.Text + ", contact = '" + txtContact.Text + "', salary = "+txtSalary.Text+ ", job_status = '"+txtStatus.Text+ "' WHERE worker_id = " + id + " ";
            fn.setData(query);

            String qry = "SELECT * FROM tbl_workers";
            lodaData(qry);

            txtFullName.Clear();
            txtAge.Clear();
            txtContact.Clear();
            txtSalary.Clear();
            txtStatus.SelectedIndex = -1;
        }

        private void UC_UpdatWrkr_Enter(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_workers";
            DataSet ds = fn.getData(query);
            UpdateWorkersGridView.DataSource = ds.Tables[0];
        }
    }
}
