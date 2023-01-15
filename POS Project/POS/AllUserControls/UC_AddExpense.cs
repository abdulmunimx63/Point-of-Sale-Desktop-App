using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_AddExpense : UserControl
    {
        functionality fn = new functionality();
        //String query;

        public UC_AddExpense()
        {
            InitializeComponent();
        }

        private void AddExpenseGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        // Btn Add Expense to List:
        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                int n = AddExpenseGridView.Rows.Add();
                AddExpenseGridView.Rows[n].Cells[0].Value = ExpenseDatePicker.Text;
                AddExpenseGridView.Rows[n].Cells[1].Value = txtType.Text;
                AddExpenseGridView.Rows[n].Cells[2].Value = txtAmount.Text;
                AddExpenseGridView.Rows[n].Cells[3].Value = txtRemarks.Text;

                txtType.Clear();
                txtAmount.Clear();
                txtRemarks.Clear();
            }
            
        }

        // Add_Expense Form Validation:
        private bool IsFormValid()
        {
            if (txtType.Text.Trim() == String.Empty || txtAmount.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Required Fields are Empty.", "Please Fill All Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        // Insert all Expense data of a DataGridView to Database At Once:
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AppDB;Integrated Security=True");

            for(int i = 0; i < AddExpenseGridView.Rows.Count; i++)
            {
                String query = "INSERT INTO tbl_expense (Date,Type,Amount,Remarks) VALUES ('"+AddExpenseGridView.Rows[i].Cells[0].Value+"', '"+ AddExpenseGridView.Rows[i].Cells[1].Value + "', "+ AddExpenseGridView.Rows[i].Cells[2].Value + ", '"+ AddExpenseGridView.Rows[i].Cells[3].Value + "') ";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            AddExpenseGridView.Rows.Clear();
            MessageBox.Show("New Expenses are Successfully Saved to the System.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
