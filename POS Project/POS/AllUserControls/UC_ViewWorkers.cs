using System;
using System.Data;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_ViewWorkers : UserControl
    {
        functionality fn = new functionality();
        String query;

        public UC_ViewWorkers()
        {
            InitializeComponent();
        }

        private void UC_ViewWorkers_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_workers";
            DataSet ds = fn.getData(query);
            ViewWorkersGridView.DataSource = ds.Tables[0];
            ViewWorkersGridView.Columns[0].Visible = false;
        }

        private void UC_ViewWorkers_Enter(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_workers";
            DataSet ds = fn.getData(query);
            ViewWorkersGridView.DataSource = ds.Tables[0];

        }
    }
}
