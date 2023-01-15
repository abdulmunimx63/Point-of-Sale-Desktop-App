using DGVPrinterHelper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_ExpenseRecord : UserControl
    {
        functionality fn = new functionality();
        String query;

        public UC_ExpenseRecord()
        {
            InitializeComponent();
        }

        private void UC_ExpenseRecord_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_expense";
            DataSet ds = fn.getData(query);
            ExpenseRecordGridView.DataSource = ds.Tables[0];
            ExpenseRecordGridView.Columns[0].Visible = false;

            lblTotalExpense.Text = "Rs:" + ShowTotalSum(3); // Pass column # that you want to calculate:
        }

        private void UC_ExpenseRecord_Enter(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_expense";
            DataSet ds = fn.getData(query);
            ExpenseRecordGridView.DataSource = ds.Tables[0];
        }

        private void txtSearchType_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_expense WHERE Type LIKE '" + txtSearchType.Text + "%' ";
            DataSet ds = fn.getData(query);
            ExpenseRecordGridView.DataSource = ds.Tables[0];

            lblTotalExpense.Text = "Rs:" + ShowTotalSum(3); // Pass column # that you want to calculate:
        }


        private void BtnDateSearch_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_expense WHERE Date BETWEEN '" + FromDate.Value + "' and '" + ToDate.Value + "' ";
            DataSet ds = fn.getData(query);
            ExpenseRecordGridView.DataSource = ds.Tables[0];

            lblTotalExpense.Text = "Rs:" + ShowTotalSum(3); // Pass column # that you want to calculate:
        }


        // Method for Calculate the Sum of DGV Column:
        public Int32 ShowTotalSum(int v)
        {
            Int32 Total = 0;
            for (int i = 0; i < ExpenseRecordGridView.Rows.Count; i++)
            {
                Total += Convert.ToInt32(ExpenseRecordGridView.Rows[i].Cells[v].Value);
            }
            return Total;
        }

        private void ExpenseRecordGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Record ?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(ExpenseRecordGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "DELETE FROM tbl_expense WHERE Expense_id = " + id + " ";
                fn.setData(query);

                query = "SELECT * FROM tbl_expense";
                DataSet ds = fn.getData(query);
                ExpenseRecordGridView.DataSource = ds.Tables[0];
                ExpenseRecordGridView.Columns[0].Visible = false;

                lblTotalExpense.Text = "Rs:" + ShowTotalSum(3); // Pass column # that you want to calculate:
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Expense Report";
            printer.SubTitle = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Expense During This Period : " + lblTotalExpense.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(ExpenseRecordGridView);
        }
    }
}
