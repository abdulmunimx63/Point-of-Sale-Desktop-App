using POS.Winforms;
using System;
using System.Windows.Forms;

namespace POS
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string user)
        {
            InitializeComponent();

            if(user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdateItems.Hide();
                btnRemoveItems.Hide();
                btnManageWorkers.Hide();
                btnExpense.Hide();
                btnSalesReturn.Hide();
            }
            else if (user == "Admin")
            {
                btnAddItems.Show();
                btnUpdateItems.Show();
                btnRemoveItems.Show();
                btnManageWorkers.Show();
                btnExpense.Show();
                btnSalesReturn.Show();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            String currentDT = DateTime.Now.ToString("ddd, dd MMM yyyy");
            MyLabel.Text = currentDT;

            hideSubMenu();
            uC_AddItems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItems1.Visible = false;

            PanelWorkerMenu.Visible = false;
            uC_ViewWorkers1.Visible = false;

            uC_AddWorkers1.Visible = false;
            uC_UpdatWrkr1.Visible = false;
            uC_RemoveWrkr1.Visible = false;

            uC_AddExpense1.Visible = false;
            uC_ExpenseRecord1.Visible = false;

            uC_SalesReturn1.Visible = false;
        }

        //private void UC_AddItem1_Load(object sender, EventArgs e)
        //{

        //}

        private void UC_AddItems1_Load(object sender, EventArgs e)
        {

        }

        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            uC_Welcome1.SendToBack();
            guna2Transition1.ShowSync(uC_PlaceOrder1);
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
            hideSubMenu();
        }

        private void UpdateItems_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible = true;
            uC_UpdateItems1.BringToFront();
            hideSubMenu();
        }

        private void AddItems_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;
            uC_AddItems1.BringToFront();
            hideSubMenu();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Login ln = new Login();
            this.Hide();
            ln.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemoveItems_Click(object sender, EventArgs e)
        {
            uC_RemoveItems1.Visible = true;
            uC_RemoveItems1.BringToFront();
            hideSubMenu();
        }

        private void uC_RemoveItems1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hideSubMenu()
        {
            if (PanelExpenseMenu.Visible == true)
            {
                PanelExpenseMenu.Visible = false;
            }

            if (PanelWorkerMenu.Visible == true)
            {
                PanelWorkerMenu.Visible = false;
            }
            
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        // Btn Manage Workers Dropdown:
        private void btnManageWorkers_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelWorkerMenu);
        }

        private void btnViewWorker_Click(object sender, EventArgs e)
        {
            uC_ViewWorkers1.Visible = true;
            uC_ViewWorkers1.BringToFront();
            hideSubMenu();
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            uC_AddWorkers1.Visible = true;
            uC_AddWorkers1.BringToFront();
            hideSubMenu();
        }

        private void btnUpdateWorker_Click(object sender, EventArgs e)
        {
            uC_UpdatWrkr1.Visible = true;
            uC_UpdatWrkr1.BringToFront();
            hideSubMenu();
        }

        private void btnRemoveWorker_Click(object sender, EventArgs e)
        {
            uC_RemoveWrkr1.Visible = true;
            uC_RemoveWrkr1.BringToFront();
            hideSubMenu();
        }

        private void uC_RemoveWrkr1_Load(object sender, EventArgs e)
        {

        }

        
        //private void btnRemoveWorkers_Click(object sender, EventArgs e)
        //{
        //    
        //}

        // Btn Expense Dropdown:
        private void btnExpense_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelExpenseMenu);
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            uC_AddExpense1.Visible = true;
            uC_AddExpense1.BringToFront();
            hideSubMenu();
        }

        private void btnExpenseRecord_Click(object sender, EventArgs e)
        {
            uC_ExpenseRecord1.Visible = true;
            uC_ExpenseRecord1.BringToFront();
            hideSubMenu();
        }

        private void PanelExpenseMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {
            uC_SalesReturn1.Visible = true;
            uC_SalesReturn1.BringToFront();
            hideSubMenu();
        }

        // Setting winform:
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings St = new Settings();
            St.Show();
        }
    }
}
