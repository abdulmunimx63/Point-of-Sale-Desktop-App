using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace POS.AllUserControls
{
    public partial class UC_PlaceOrder : UserControl
    {
        functionality fn = new functionality();
        string query;

        public UC_PlaceOrder()
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // ListBox1 Selected Index Changed:
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();
            txtRemarks.Clear();

            String text = itemListBox.GetItemText(itemListBox.SelectedItem);
            txtItemName.Text = text;

            query = "SELECT item_price FROM tbl_items WHERE item_name = '"+text+"' ";
            DataSet ds = fn.getData(query);

            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // TxtQuantity ValueChanged:
        private void TxtQuantity_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Int64 quantity = Int64.Parse(txtQuantityUpDown.Value.ToString());
                Int16 price = Int16.Parse(txtPrice.Text);
                txtTotal.Text = (quantity * price).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void UC_PlaceOrder_Load(object sender, EventArgs e)
        {
            
        }

        // Search Items With Category:
        private void TxtCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = txtCategory.Text;
            query = "SELECT item_name FROM tbl_items WHERE item_category = '" + category+"' ";
            showItemList(query);
        }

        // Search Item With Specific Name:
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            String category = txtCategory.Text;
            query = "SELECT item_name FROM tbl_items WHERE item_category = '" + category + "' AND item_name LIKE '" + txtSearch.Text + "%' ";
            showItemList(query);
        }

        // Show_Item_List Method:
        private void showItemList(string query)
        {
            itemListBox.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                itemListBox.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        // Btn Add to Cart:
        public int n, total = 0;
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = OrderDetailGridView.Rows.Add();
                OrderDetailGridView.Rows[n].Cells[0].Value = txtItemName.Text;
                OrderDetailGridView.Rows[n].Cells[1].Value = txtPrice.Text;
                OrderDetailGridView.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                OrderDetailGridView.Rows[n].Cells[3].Value = txtTotal.Text;
                OrderDetailGridView.Rows[n].Cells[4].Value = txtRemarks.Text;

                total += int.Parse(txtTotal.Text);
                lblGrandTotal.Text = "Rs: " + total;

                txtItemName.Clear();
                txtPrice.Clear();
                txtQuantityUpDown.ResetText();
                txtTotal.Clear();
                txtRemarks.Clear();
            }
            else
            {
                MessageBox.Show("Minimum Quantity Need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        int amount;
        private void OrderDetailGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(OrderDetailGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // [Tow Functionalitys] => (1st Save Sales into Database), (2nd Print Invoice)
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            if (OrderDetailGridView.Rows.Count != 0)
            {
                String currentDT = DateTime.Now.ToString("yyyy-MM-dd");
                SqlConnection con = fn.getConnection();

                // Save Bulk Record into DB:
                for (int i = 0; i < OrderDetailGridView.Rows.Count; i++)
                {
                    String query = "INSERT INTO tbl_SalesOrder (SaleDate,ItemName,UnitPrice,Quantity,Total,Remarks) VALUES ('" + currentDT + "','" + OrderDetailGridView.Rows[i].Cells[0].Value + "', " + OrderDetailGridView.Rows[i].Cells[1].Value + ", " + OrderDetailGridView.Rows[i].Cells[2].Value + ", " + OrderDetailGridView.Rows[i].Cells[3].Value + ", '" + OrderDetailGridView.Rows[i].Cells[4].Value + "') ";
                    SqlCommand cmd = new SqlCommand(query, con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                txtCategory.SelectedIndex = -1;
                itemListBox.Items.Clear();


                // [2nd Functionality: => Print Invoice]

                /* printPreviewDialog1.Document = printDocument1; */

                // Generate Dynamically Recipt Size:
                if (OrderDetailGridView.Rows.Count <= 5)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 360);
                }
                else if (OrderDetailGridView.Rows.Count <= 10)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 450);
                }
                else if (OrderDetailGridView.Rows.Count <= 15)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 535);
                }
                else if (OrderDetailGridView.Rows.Count > 15)
                {
                    printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                }

                /* printPreviewDialog1.ShowDialog(); */

                // Print Bill Twice:
                for(int i=0; i < 2; i++)
                {
                    printDocument1.Print();
                }

                OrderDetailGridView.Rows.Clear();
                total = 0;
                lblGrandTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Cart Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void UC_PlaceOrder_Enter(object sender, EventArgs e)
        {
            fillCategoryList();
        }

        // Print Invoice:
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Aloush Al-Arbi Restaurant", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(43, 40));

            e.Graphics.DrawString("Ghalla Mandi Road, Model Town B, Bahawalpur.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(20, 58));

            e.Graphics.DrawString("PH# 0309-3974640", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(90, 73));


            e.Graphics.DrawString("___________________________________________", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 85));

            e.Graphics.DrawString("Date: " + DateTime.Now.ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 115));

            e.Graphics.DrawString("Sale Recipt:", new Font("Arial", 8, FontStyle.Underline), Brushes.Black, new Point(212, 115));


            e.Graphics.DrawString("--------------------------------------------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 140));

            e.Graphics.DrawString("Item Name", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(7, 152));
            e.Graphics.DrawString("Price", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(144, 152));
            e.Graphics.DrawString("Qty", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(180, 152));
            e.Graphics.DrawString("Total", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(210, 152));
            e.Graphics.DrawString("Remrk", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(245, 152));

            e.Graphics.DrawString("--------------------------------------------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 160));

            int yPos = 175;
            for (int i = 0; i < OrderDetailGridView.Rows.Count; i++)
            {
                String itemName = OrderDetailGridView.Rows[i].Cells[0].Value.ToString();
                String price = OrderDetailGridView.Rows[i].Cells[1].Value.ToString();
                String qty = OrderDetailGridView.Rows[i].Cells[2].Value.ToString();
                String total = OrderDetailGridView.Rows[i].Cells[3].Value.ToString();
                String remarks = OrderDetailGridView.Rows[i].Cells[4].Value.ToString();

                e.Graphics.DrawString(itemName, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(7, yPos));
                e.Graphics.DrawString(price, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(144, yPos));
                e.Graphics.DrawString(qty, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(180, yPos));
                e.Graphics.DrawString(total, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(210, yPos));
                e.Graphics.DrawString(remarks, new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(245, yPos));

                yPos += 16;
            }
            
            e.Graphics.DrawString("--------------------------------------------------------------------------", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos));
            e.Graphics.DrawString("Grand Total:", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(200, yPos += 20));
            e.Graphics.DrawString(lblGrandTotal.Text, new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(205, yPos += 15));
            e.Graphics.DrawString("Thanks For Purchasing.", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos += 4));

            e.Graphics.DrawString("___________________________________________", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, yPos += 15));
            e.Graphics.DrawString("Software Developed by TECH Arena Bahawalpur.", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, yPos += 15));
            e.Graphics.DrawString("PH: 0305-8893986, 0302-7827679", new Font("Arial", 7, FontStyle.Regular), Brushes.Black, new Point(5, yPos += 14));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetailGridView.Rows.RemoveAt(this.OrderDetailGridView.SelectedRows[0].Index);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

            total -= amount;
            lblGrandTotal.Text = "Rs: " + total;
        }
    }
}
