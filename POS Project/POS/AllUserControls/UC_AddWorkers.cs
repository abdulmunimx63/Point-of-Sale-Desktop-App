using System;
using System.Data;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_AddWorkers : UserControl
    {
        functionality fn = new functionality();
        String query;

        public UC_AddWorkers()
        {
            InitializeComponent();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            query = "INSERT INTO tbl_workers (full_name,age,contact,salary,join_date,job_status) VALUES ('" + txtFullName.Text + "'," + txtAge.Text + ",'" + txtContact.Text + "'," + txtSalary.Text + ",'" + JoinDatePicker.Text + "','" + txtStatus.Text + "')";
            fn.setData(query);
        }

    }
}
