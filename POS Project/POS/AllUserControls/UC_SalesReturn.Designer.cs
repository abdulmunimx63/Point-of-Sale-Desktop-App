
namespace POS.AllUserControls
{
    partial class UC_SalesReturn
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Sales_ReturnGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnDateSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSearchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.ElipseSales_Return = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtSearchRemarks = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalSale = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sales_ReturnGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(270, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sales / Return";
            // 
            // Sales_ReturnGridView
            // 
            this.Sales_ReturnGridView.AllowUserToAddRows = false;
            this.Sales_ReturnGridView.AllowUserToDeleteRows = false;
            this.Sales_ReturnGridView.AllowUserToOrderColumns = true;
            this.Sales_ReturnGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Sales_ReturnGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Sales_ReturnGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Sales_ReturnGridView.BackgroundColor = System.Drawing.Color.White;
            this.Sales_ReturnGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sales_ReturnGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Sales_ReturnGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Sales_ReturnGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Sales_ReturnGridView.ColumnHeadersHeight = 21;
            this.Sales_ReturnGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Sales_ReturnGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.Sales_ReturnGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Sales_ReturnGridView.EnableHeadersVisualStyles = false;
            this.Sales_ReturnGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Sales_ReturnGridView.Location = new System.Drawing.Point(17, 205);
            this.Sales_ReturnGridView.Name = "Sales_ReturnGridView";
            this.Sales_ReturnGridView.RowHeadersVisible = false;
            this.Sales_ReturnGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Sales_ReturnGridView.Size = new System.Drawing.Size(761, 266);
            this.Sales_ReturnGridView.TabIndex = 20;
            this.Sales_ReturnGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.Sales_ReturnGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.Sales_ReturnGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Sales_ReturnGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Sales_ReturnGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Sales_ReturnGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Sales_ReturnGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Sales_ReturnGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.Sales_ReturnGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Sales_ReturnGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Sales_ReturnGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Sales_ReturnGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Sales_ReturnGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Sales_ReturnGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.Sales_ReturnGridView.ThemeStyle.ReadOnly = false;
            this.Sales_ReturnGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.Sales_ReturnGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Sales_ReturnGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Sales_ReturnGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Sales_ReturnGridView.ThemeStyle.RowsStyle.Height = 22;
            this.Sales_ReturnGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.Sales_ReturnGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.Sales_ReturnGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Sales_ReturnGridView_CellClick);
            // 
            // btnPrint
            // 
            this.btnPrint.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnPrint.BorderThickness = 2;
            this.btnPrint.CheckedState.Parent = this.btnPrint;
            this.btnPrint.CustomImages.Parent = this.btnPrint;
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnPrint.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPrint.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnPrint.HoverState.Parent = this.btnPrint;
            this.btnPrint.Location = new System.Drawing.Point(653, 477);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(125, 36);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnDateSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ToDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FromDate);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(400, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 142);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Filter";
            // 
            // BtnDateSearch
            // 
            this.BtnDateSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.BtnDateSearch.BorderThickness = 2;
            this.BtnDateSearch.CheckedState.Parent = this.BtnDateSearch;
            this.BtnDateSearch.CustomImages.Parent = this.BtnDateSearch;
            this.BtnDateSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.BtnDateSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDateSearch.ForeColor = System.Drawing.Color.White;
            this.BtnDateSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.BtnDateSearch.HoverState.FillColor = System.Drawing.Color.White;
            this.BtnDateSearch.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.BtnDateSearch.HoverState.Parent = this.BtnDateSearch;
            this.BtnDateSearch.Location = new System.Drawing.Point(271, 96);
            this.BtnDateSearch.Name = "BtnDateSearch";
            this.BtnDateSearch.ShadowDecoration.Parent = this.BtnDateSearch;
            this.BtnDateSearch.Size = new System.Drawing.Size(91, 36);
            this.BtnDateSearch.TabIndex = 4;
            this.BtnDateSearch.Text = "Search";
            this.BtnDateSearch.Click += new System.EventHandler(this.BtnDateSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(16, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "To Date";
            // 
            // ToDate
            // 
            this.ToDate.CheckedState.Parent = this.ToDate;
            this.ToDate.CustomFormat = "yyyy-MM-dd";
            this.ToDate.FillColor = System.Drawing.Color.DarkGray;
            this.ToDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDate.HoverState.Parent = this.ToDate;
            this.ToDate.Location = new System.Drawing.Point(16, 102);
            this.ToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.ShadowDecoration.Parent = this.ToDate;
            this.ToDate.Size = new System.Drawing.Size(234, 30);
            this.ToDate.TabIndex = 3;
            this.ToDate.Value = new System.DateTime(2021, 3, 5, 22, 38, 26, 414);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(16, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "From Date";
            // 
            // FromDate
            // 
            this.FromDate.CheckedState.Parent = this.FromDate;
            this.FromDate.CustomFormat = "yyyy-MM-dd";
            this.FromDate.FillColor = System.Drawing.Color.DarkGray;
            this.FromDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDate.HoverState.Parent = this.FromDate;
            this.FromDate.Location = new System.Drawing.Point(16, 48);
            this.FromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.FromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.ShadowDecoration.Parent = this.FromDate;
            this.FromDate.Size = new System.Drawing.Size(234, 30);
            this.FromDate.TabIndex = 2;
            this.FromDate.Value = new System.DateTime(2021, 3, 5, 22, 38, 26, 414);
            // 
            // txtSearchName
            // 
            this.txtSearchName.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchName.BorderColor = System.Drawing.Color.Gray;
            this.txtSearchName.BorderThickness = 2;
            this.txtSearchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchName.DefaultText = "";
            this.txtSearchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.DisabledState.Parent = this.txtSearchName;
            this.txtSearchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearchName.FocusedState.Parent = this.txtSearchName;
            this.txtSearchName.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSearchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearchName.HoverState.Parent = this.txtSearchName;
            this.txtSearchName.Location = new System.Drawing.Point(30, 38);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.PasswordChar = '\0';
            this.txtSearchName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchName.PlaceholderText = "Search by Item Name";
            this.txtSearchName.SelectedText = "";
            this.txtSearchName.ShadowDecoration.Parent = this.txtSearchName;
            this.txtSearchName.Size = new System.Drawing.Size(263, 36);
            this.txtSearchName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchName.TabIndex = 0;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // ElipseSales_Return
            // 
            this.ElipseSales_Return.BorderRadius = 0;
            this.ElipseSales_Return.TargetControl = this;
            // 
            // txtSearchRemarks
            // 
            this.txtSearchRemarks.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchRemarks.BorderColor = System.Drawing.Color.Gray;
            this.txtSearchRemarks.BorderThickness = 2;
            this.txtSearchRemarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchRemarks.DefaultText = "";
            this.txtSearchRemarks.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchRemarks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchRemarks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRemarks.DisabledState.Parent = this.txtSearchRemarks;
            this.txtSearchRemarks.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRemarks.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearchRemarks.FocusedState.Parent = this.txtSearchRemarks;
            this.txtSearchRemarks.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtSearchRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSearchRemarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearchRemarks.HoverState.Parent = this.txtSearchRemarks;
            this.txtSearchRemarks.Location = new System.Drawing.Point(30, 97);
            this.txtSearchRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchRemarks.Name = "txtSearchRemarks";
            this.txtSearchRemarks.PasswordChar = '\0';
            this.txtSearchRemarks.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchRemarks.PlaceholderText = "Search by Remarks";
            this.txtSearchRemarks.SelectedText = "";
            this.txtSearchRemarks.ShadowDecoration.Parent = this.txtSearchRemarks;
            this.txtSearchRemarks.Size = new System.Drawing.Size(263, 36);
            this.txtSearchRemarks.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchRemarks.TabIndex = 1;
            this.txtSearchRemarks.TextChanged += new System.EventHandler(this.txtSearchRemarks_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSearchName);
            this.groupBox2.Controls.Add(this.txtSearchRemarks);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(17, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 142);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 30;
            this.label4.Text = "Total Sale:";
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotalSale.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSale.Location = new System.Drawing.Point(108, 477);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(125, 36);
            this.lblTotalSale.TabIndex = 31;
            this.lblTotalSale.Text = "Rs: 00";
            this.lblTotalSale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_SalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblTotalSale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.Sales_ReturnGridView);
            this.Controls.Add(this.label1);
            this.Name = "UC_SalesReturn";
            this.Size = new System.Drawing.Size(797, 527);
            this.Load += new System.EventHandler(this.UC_SalesReturn_Load);
            this.Enter += new System.EventHandler(this.UC_SalesReturn_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Sales_ReturnGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView Sales_ReturnGridView;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchName;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDate;
        private Guna.UI2.WinForms.Guna2Elipse ElipseSales_Return;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchRemarks;
        private Guna.UI2.WinForms.Guna2Button BtnDateSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalSale;
    }
}
