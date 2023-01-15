
namespace POS.AllUserControls
{
    partial class UC_ExpenseRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.ExpenseRecordGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchType = new Guna.UI2.WinForms.Guna2TextBox();
            this.ElipseExpenseRecord = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnDateSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.FromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseRecordGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(253, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Expense Record";
            // 
            // ExpenseRecordGridView
            // 
            this.ExpenseRecordGridView.AllowUserToAddRows = false;
            this.ExpenseRecordGridView.AllowUserToDeleteRows = false;
            this.ExpenseRecordGridView.AllowUserToResizeColumns = false;
            this.ExpenseRecordGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ExpenseRecordGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ExpenseRecordGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExpenseRecordGridView.BackgroundColor = System.Drawing.Color.White;
            this.ExpenseRecordGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ExpenseRecordGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpenseRecordGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExpenseRecordGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ExpenseRecordGridView.ColumnHeadersHeight = 21;
            this.ExpenseRecordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpenseRecordGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExpenseRecordGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ExpenseRecordGridView.EnableHeadersVisualStyles = false;
            this.ExpenseRecordGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.ExpenseRecordGridView.Location = new System.Drawing.Point(18, 208);
            this.ExpenseRecordGridView.Name = "ExpenseRecordGridView";
            this.ExpenseRecordGridView.RowHeadersVisible = false;
            this.ExpenseRecordGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExpenseRecordGridView.Size = new System.Drawing.Size(761, 266);
            this.ExpenseRecordGridView.TabIndex = 6;
            this.ExpenseRecordGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.ExpenseRecordGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.ExpenseRecordGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ExpenseRecordGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ExpenseRecordGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ExpenseRecordGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ExpenseRecordGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ExpenseRecordGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.ExpenseRecordGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ExpenseRecordGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ExpenseRecordGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ExpenseRecordGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ExpenseRecordGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ExpenseRecordGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.ExpenseRecordGridView.ThemeStyle.ReadOnly = false;
            this.ExpenseRecordGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ExpenseRecordGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExpenseRecordGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ExpenseRecordGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ExpenseRecordGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ExpenseRecordGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.ExpenseRecordGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ExpenseRecordGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExpenseRecordGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchType);
            this.groupBox1.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(18, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 142);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Record";
            // 
            // txtSearchType
            // 
            this.txtSearchType.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchType.BorderColor = System.Drawing.Color.Gray;
            this.txtSearchType.BorderThickness = 2;
            this.txtSearchType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchType.DefaultText = "";
            this.txtSearchType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchType.DisabledState.Parent = this.txtSearchType;
            this.txtSearchType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearchType.FocusedState.Parent = this.txtSearchType;
            this.txtSearchType.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtSearchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSearchType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearchType.HoverState.Parent = this.txtSearchType;
            this.txtSearchType.Location = new System.Drawing.Point(20, 64);
            this.txtSearchType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchType.Name = "txtSearchType";
            this.txtSearchType.PasswordChar = '\0';
            this.txtSearchType.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchType.PlaceholderText = "Expense Type";
            this.txtSearchType.SelectedText = "";
            this.txtSearchType.ShadowDecoration.Parent = this.txtSearchType;
            this.txtSearchType.Size = new System.Drawing.Size(263, 36);
            this.txtSearchType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchType.TabIndex = 0;
            this.txtSearchType.TextChanged += new System.EventHandler(this.txtSearchType_TextChanged);
            // 
            // ElipseExpenseRecord
            // 
            this.ElipseExpenseRecord.BorderRadius = 0;
            this.ElipseExpenseRecord.TargetControl = this;
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
            this.btnPrint.Location = new System.Drawing.Point(653, 480);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.ShadowDecoration.Parent = this.btnPrint;
            this.btnPrint.Size = new System.Drawing.Size(125, 36);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDateSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ToDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.FromDate);
            this.groupBox2.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(401, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 142);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date Filter";
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
            this.BtnDateSearch.TabIndex = 3;
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
            this.ToDate.TabIndex = 2;
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
            this.FromDate.TabIndex = 1;
            this.FromDate.Value = new System.DateTime(2021, 3, 5, 22, 38, 26, 414);
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTotalExpense.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalExpense.Location = new System.Drawing.Point(160, 480);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(125, 36);
            this.lblTotalExpense.TabIndex = 29;
            this.lblTotalExpense.Text = "Rs: 00";
            this.lblTotalExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(34, 487);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Total Expense:";
            // 
            // UC_ExpenseRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalExpense);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExpenseRecordGridView);
            this.Controls.Add(this.label1);
            this.Name = "UC_ExpenseRecord";
            this.Size = new System.Drawing.Size(797, 527);
            this.Load += new System.EventHandler(this.UC_ExpenseRecord_Load);
            this.Enter += new System.EventHandler(this.UC_ExpenseRecord_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseRecordGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ExpenseRecordGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchType;
        private Guna.UI2.WinForms.Guna2Elipse ElipseExpenseRecord;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button BtnDateSearch;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker ToDate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker FromDate;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label label4;
    }
}
