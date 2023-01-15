namespace POS.AllUserControls
{
    partial class UC_PlaceOrder
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PlaceOrder));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantityUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.groupBoxPO = new System.Windows.Forms.GroupBox();
            this.btnAddToCart = new Guna.UI2.WinForms.Guna2Button();
            this.txtRemarks = new Guna.UI2.WinForms.Guna2TextBox();
            this.OrderDetailGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrintBill = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityUpDown)).BeginInit();
            this.groupBoxPO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.Gray;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(21, 124);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearch.PlaceholderText = "Search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(159, 36);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.BorderColor = System.Drawing.Color.Gray;
            this.txtCategory.BorderThickness = 2;
            this.txtCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtCategory.FocusedState.Parent = this.txtCategory;
            this.txtCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtCategory.ForeColor = System.Drawing.Color.Black;
            this.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtCategory.HoverState.Parent = this.txtCategory;
            this.txtCategory.ItemHeight = 30;
            this.txtCategory.ItemsAppearance.Parent = this.txtCategory;
            this.txtCategory.Location = new System.Drawing.Point(21, 70);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ShadowDecoration.Parent = this.txtCategory;
            this.txtCategory.Size = new System.Drawing.Size(159, 36);
            this.txtCategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCategory.TabIndex = 0;
            this.txtCategory.SelectedIndexChanged += new System.EventHandler(this.TxtCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(23, 50);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(79, 20);
            this.lblCategory.TabIndex = 13;
            this.lblCategory.Text = "Category";
            // 
            // itemListBox
            // 
            this.itemListBox.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.ItemHeight = 20;
            this.itemListBox.Location = new System.Drawing.Point(21, 179);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(159, 324);
            this.itemListBox.TabIndex = 2;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.Color.Transparent;
            this.txtItemName.BorderColor = System.Drawing.Color.Gray;
            this.txtItemName.BorderThickness = 2;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.DefaultText = "";
            this.txtItemName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtItemName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtItemName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.DisabledState.Parent = this.txtItemName;
            this.txtItemName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtItemName.Enabled = false;
            this.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtItemName.FocusedState.Parent = this.txtItemName;
            this.txtItemName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtItemName.HoverState.Parent = this.txtItemName;
            this.txtItemName.Location = new System.Drawing.Point(34, 44);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtItemName.PlaceholderText = "Item Name";
            this.txtItemName.SelectedText = "";
            this.txtItemName.ShadowDecoration.Parent = this.txtItemName;
            this.txtItemName.Size = new System.Drawing.Size(220, 36);
            this.txtItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItemName.TabIndex = 16;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BorderColor = System.Drawing.Color.Gray;
            this.txtPrice.BorderThickness = 2;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.Enabled = false;
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(327, 44);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPrice.PlaceholderText = "Unit Price";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(220, 36);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 17;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.BorderColor = System.Drawing.Color.Gray;
            this.txtTotal.BorderThickness = 2;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.Parent = this.txtTotal;
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtTotal.FocusedState.Parent = this.txtTotal;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtTotal.HoverState.Parent = this.txtTotal;
            this.txtTotal.Location = new System.Drawing.Point(327, 96);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTotal.PlaceholderText = "Total";
            this.txtTotal.SelectedText = "";
            this.txtTotal.ShadowDecoration.Parent = this.txtTotal;
            this.txtTotal.Size = new System.Drawing.Size(220, 36);
            this.txtTotal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotal.TabIndex = 18;
            // 
            // txtQuantityUpDown
            // 
            this.txtQuantityUpDown.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantityUpDown.BorderColor = System.Drawing.Color.Gray;
            this.txtQuantityUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantityUpDown.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantityUpDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantityUpDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantityUpDown.DisabledState.Parent = this.txtQuantityUpDown;
            this.txtQuantityUpDown.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.txtQuantityUpDown.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.txtQuantityUpDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtQuantityUpDown.FocusedState.Parent = this.txtQuantityUpDown;
            this.txtQuantityUpDown.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityUpDown.ForeColor = System.Drawing.Color.Black;
            this.txtQuantityUpDown.Location = new System.Drawing.Point(34, 96);
            this.txtQuantityUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantityUpDown.Name = "txtQuantityUpDown";
            this.txtQuantityUpDown.ShadowDecoration.Parent = this.txtQuantityUpDown;
            this.txtQuantityUpDown.Size = new System.Drawing.Size(220, 36);
            this.txtQuantityUpDown.TabIndex = 3;
            this.txtQuantityUpDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtQuantityUpDown.UpDownButtonForeColor = System.Drawing.Color.Gray;
            this.txtQuantityUpDown.ValueChanged += new System.EventHandler(this.TxtQuantity_ValueChanged);
            // 
            // groupBoxPO
            // 
            this.groupBoxPO.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPO.Controls.Add(this.txtItemName);
            this.groupBoxPO.Controls.Add(this.txtPrice);
            this.groupBoxPO.Controls.Add(this.txtQuantityUpDown);
            this.groupBoxPO.Controls.Add(this.btnAddToCart);
            this.groupBoxPO.Controls.Add(this.txtTotal);
            this.groupBoxPO.Controls.Add(this.txtRemarks);
            this.groupBoxPO.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPO.Location = new System.Drawing.Point(196, 14);
            this.groupBoxPO.Name = "groupBoxPO";
            this.groupBoxPO.Size = new System.Drawing.Size(579, 213);
            this.groupBoxPO.TabIndex = 22;
            this.groupBoxPO.TabStop = false;
            this.groupBoxPO.Text = "Place Order";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnAddToCart.BorderThickness = 2;
            this.btnAddToCart.CheckedState.Parent = this.btnAddToCart;
            this.btnAddToCart.CustomImages.Parent = this.btnAddToCart;
            this.btnAddToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnAddToCart.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnAddToCart.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddToCart.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnAddToCart.HoverState.Parent = this.btnAddToCart;
            this.btnAddToCart.Location = new System.Drawing.Point(422, 150);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.ShadowDecoration.Parent = this.btnAddToCart;
            this.btnAddToCart.Size = new System.Drawing.Size(125, 36);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.BackColor = System.Drawing.Color.Transparent;
            this.txtRemarks.BorderColor = System.Drawing.Color.Gray;
            this.txtRemarks.BorderThickness = 2;
            this.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemarks.DefaultText = "";
            this.txtRemarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRemarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRemarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemarks.DisabledState.Parent = this.txtRemarks;
            this.txtRemarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRemarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtRemarks.FocusedState.Parent = this.txtRemarks;
            this.txtRemarks.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.ForeColor = System.Drawing.Color.Black;
            this.txtRemarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtRemarks.HoverState.Parent = this.txtRemarks;
            this.txtRemarks.Location = new System.Drawing.Point(34, 150);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRemarks.PlaceholderText = "Remarks";
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.ShadowDecoration.Parent = this.txtRemarks;
            this.txtRemarks.Size = new System.Drawing.Size(220, 36);
            this.txtRemarks.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRemarks.TabIndex = 4;
            // 
            // OrderDetailGridView
            // 
            this.OrderDetailGridView.AllowUserToAddRows = false;
            this.OrderDetailGridView.AllowUserToDeleteRows = false;
            this.OrderDetailGridView.AllowUserToResizeColumns = false;
            this.OrderDetailGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.OrderDetailGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderDetailGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderDetailGridView.BackgroundColor = System.Drawing.Color.White;
            this.OrderDetailGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrderDetailGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDetailGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDetailGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderDetailGridView.ColumnHeadersHeight = 21;
            this.OrderDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDetailGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderDetailGridView.EnableHeadersVisualStyles = false;
            this.OrderDetailGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.OrderDetailGridView.Location = new System.Drawing.Point(196, 243);
            this.OrderDetailGridView.Name = "OrderDetailGridView";
            this.OrderDetailGridView.RowHeadersVisible = false;
            this.OrderDetailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDetailGridView.Size = new System.Drawing.Size(579, 200);
            this.OrderDetailGridView.TabIndex = 19;
            this.OrderDetailGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.OrderDetailGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.OrderDetailGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.OrderDetailGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.OrderDetailGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.OrderDetailGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.OrderDetailGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.OrderDetailGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.OrderDetailGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.OrderDetailGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderDetailGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrderDetailGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OrderDetailGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.OrderDetailGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.OrderDetailGridView.ThemeStyle.ReadOnly = false;
            this.OrderDetailGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.OrderDetailGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderDetailGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.OrderDetailGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.OrderDetailGridView.ThemeStyle.RowsStyle.Height = 22;
            this.OrderDetailGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.OrderDetailGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.OrderDetailGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderDetailGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Unit Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Remarks";
            this.Column5.Name = "Column5";
            // 
            // btnRemove
            // 
            this.btnRemove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnRemove.BorderThickness = 2;
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.CustomImages.Parent = this.btnRemove;
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnRemove.HoverState.FillColor = System.Drawing.Color.White;
            this.btnRemove.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Location = new System.Drawing.Point(503, 470);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(125, 36);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnPrintBill.BorderThickness = 2;
            this.btnPrintBill.CheckedState.Parent = this.btnPrintBill;
            this.btnPrintBill.CustomImages.Parent = this.btnPrintBill;
            this.btnPrintBill.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnPrintBill.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrintBill.ForeColor = System.Drawing.Color.White;
            this.btnPrintBill.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnPrintBill.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrintBill.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnPrintBill.HoverState.Parent = this.btnPrintBill;
            this.btnPrintBill.Location = new System.Drawing.Point(650, 470);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.ShadowDecoration.Parent = this.btnPrintBill;
            this.btnPrintBill.Size = new System.Drawing.Size(125, 36);
            this.btnPrintBill.TabIndex = 6;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(198, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Grand Total:";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.lblGrandTotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(200, 470);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(125, 36);
            this.lblGrandTotal.TabIndex = 28;
            this.lblGrandTotal.Text = "Rs: 00";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // UC_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.OrderDetailGridView);
            this.Controls.Add(this.itemListBox);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.groupBoxPO);
            this.Name = "UC_PlaceOrder";
            this.Size = new System.Drawing.Size(797, 527);
            this.Load += new System.EventHandler(this.UC_PlaceOrder_Load);
            this.Enter += new System.EventHandler(this.UC_PlaceOrder_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantityUpDown)).EndInit();
            this.groupBoxPO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ListBox itemListBox;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtQuantityUpDown;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private System.Windows.Forms.GroupBox groupBoxPO;
        private Guna.UI2.WinForms.Guna2TextBox txtRemarks;
        private Guna.UI2.WinForms.Guna2Button btnAddToCart;
        private Guna.UI2.WinForms.Guna2DataGridView OrderDetailGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnPrintBill;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
