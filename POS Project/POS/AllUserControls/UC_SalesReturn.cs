using DGVPrinterHelper;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_SalesReturn : UserControl
    {
        functionality fn = new functionality();
        String query;

        public UC_SalesReturn()
        {
            InitializeComponent();
        }

        private void UC_SalesReturn_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_SalesOrder";
            DataSet ds = fn.getData(query);
            Sales_ReturnGridView.DataSource = ds.Tables[0];
            Sales_ReturnGridView.Columns[0].Visible = false;

            lblTotalSale.Text = "Rs:" + ShowTotalSum(5); // Pass column # that you want to calculate:

            
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_SalesOrder WHERE ItemName LIKE '" + txtSearchName.Text + "%' ";
            DataSet ds = fn.getData(query);
            Sales_ReturnGridView.DataSource = ds.Tables[0];

            lblTotalSale.Text = "Rs:" + ShowTotalSum(5); // Pass column # that you want to calculate:
        }

        private void txtSearchRemarks_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_SalesOrder WHERE Remarks LIKE '" + txtSearchRemarks.Text + "%' ";
            DataSet ds = fn.getData(query);
            Sales_ReturnGridView.DataSource = ds.Tables[0];

            lblTotalSale.Text = "Rs:" + ShowTotalSum(5); // Pass column # that you want to calculate:
        }

        private void BtnDateSearch_Click(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_SalesOrder WHERE SaleDate BETWEEN '" + FromDate.Value+"' and '"+ToDate.Value+"' ";
            DataSet ds = fn.getData(query);
            Sales_ReturnGridView.DataSource = ds.Tables[0];

            lblTotalSale.Text = "Rs:" + ShowTotalSum(5); // Pass column # that you want to calculate:
        }

        private void UC_SalesReturn_Enter(object sender, EventArgs e)
        {
            query = "SELECT * FROM tbl_SalesOrder";
            DataSet ds = fn.getData(query);
            Sales_ReturnGridView.DataSource = ds.Tables[0];
            Sales_ReturnGridView.Columns[0].Visible = false;

            lblTotalSale.Text = "Rs:" + ShowTotalSum(5); // Pass column # that you want to calculate:
        }

        // Record Delete on Cell_Click Event:
        private void Sales_ReturnGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Record ?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(Sales_ReturnGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "DELETE FROM tbl_SalesOrder WHERE SalesOrderID = " + id + " ";
                fn.setData(query);

                query = "SELECT * FROM tbl_SalesOrder";
                DataSet ds = fn.getData(query);
                Sales_ReturnGridView.DataSource = ds.Tables[0];
                Sales_ReturnGridView.Columns[0].Visible = false;

                lblTotalSale.Text = "Rs:" + ShowTotalSum(5); // Pass column # that you want to calculate:
            }
        }

        // Method for Calculate the Sum of DGV Column:
        public Int32 ShowTotalSum(int v)
        {
            Int32 Total = 0;
            for (int i = 0; i < Sales_ReturnGridView.Rows.Count; i++)
            {
                Total += Convert.ToInt32(Sales_ReturnGridView.Rows[i].Cells[v].Value);
            }
            return Total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Sales Report";
            printer.SubTitle = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Sales During This Period : " + lblTotalSale.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(Sales_ReturnGridView);
        }
    }
}