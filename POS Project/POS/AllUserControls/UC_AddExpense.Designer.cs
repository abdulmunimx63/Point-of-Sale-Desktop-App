
namespace POS.AllUserControls
{
    partial class UC_AddExpense
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
            this.groupBoxAddExp = new System.Windows.Forms.GroupBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddToList = new Guna.UI2.WinForms.Guna2Button();
            this.txtRemarks = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpenseDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtType = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddExpenseGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ElipseAddExpense = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.groupBoxAddExp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddExpenseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(276, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 44);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add Expense";
            // 
            // groupBoxAddExp
            // 
            this.groupBoxAddExp.Controls.Add(this.btnSave);
            this.groupBoxAddExp.Controls.Add(this.btnAddToList);
            this.groupBoxAddExp.Controls.Add(this.txtRemarks);
            this.groupBoxAddExp.Controls.Add(this.txtAmount);
            this.groupBoxAddExp.Controls.Add(this.label2);
            this.groupBoxAddExp.Controls.Add(this.ExpenseDatePicker);
            this.groupBoxAddExp.Controls.Add(this.txtType);
            this.groupBoxAddExp.Location = new System.Drawing.Point(26, 52);
            this.groupBoxAddExp.Name = "groupBoxAddExp";
            this.groupBoxAddExp.Size = new System.Drawing.Size(738, 208);
            this.groupBoxAddExp.TabIndex = 12;
            this.groupBoxAddExp.TabStop = false;
            this.groupBoxAddExp.Text = "Add Expense Details";
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnSave.HoverState.FillColor = System.Drawing.Color.White;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(585, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnAddToList.BorderThickness = 2;
            this.btnAddToList.CheckedState.Parent = this.btnAddToList;
            this.btnAddToList.CustomImages.Parent = this.btnAddToList;
            this.btnAddToList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnAddToList.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddToList.ForeColor = System.Drawing.Color.White;
            this.btnAddToList.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnAddToList.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAddToList.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnAddToList.HoverState.Parent = this.btnAddToList;
            this.btnAddToList.Location = new System.Drawing.Point(454, 157);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.ShadowDecoration.Parent = this.btnAddToList;
            this.btnAddToList.Size = new System.Drawing.Size(125, 36);
            this.btnAddToList.TabIndex = 5;
            this.btnAddToList.Text = "Add to List";
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
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
            this.txtRemarks.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtRemarks.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtRemarks.HoverState.Parent = this.txtRemarks;
            this.txtRemarks.Location = new System.Drawing.Point(419, 111);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtRemarks.PlaceholderText = "Remarks";
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.ShadowDecoration.Parent = this.txtRemarks;
            this.txtRemarks.Size = new System.Drawing.Size(291, 36);
            this.txtRemarks.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRemarks.TabIndex = 4;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BorderColor = System.Drawing.Color.Gray;
            this.txtAmount.BorderThickness = 2;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.DisabledState.Parent = this.txtAmount;
            this.txtAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtAmount.FocusedState.Parent = this.txtAmount;
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtAmount.HoverState.Parent = this.txtAmount;
            this.txtAmount.Location = new System.Drawing.Point(419, 52);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtAmount.PlaceholderText = "Amount";
            this.txtAmount.SelectedText = "";
            this.txtAmount.ShadowDecoration.Parent = this.txtAmount;
            this.txtAmount.Size = new System.Drawing.Size(291, 36);
            this.txtAmount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Date";
            // 
            // ExpenseDatePicker
            // 
            this.ExpenseDatePicker.CheckedState.Parent = this.ExpenseDatePicker;
            this.ExpenseDatePicker.CustomFormat = "yyyy-MM-dd";
            this.ExpenseDatePicker.FillColor = System.Drawing.Color.DarkGray;
            this.ExpenseDatePicker.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpenseDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpenseDatePicker.HoverState.Parent = this.ExpenseDatePicker;
            this.ExpenseDatePicker.Location = new System.Drawing.Point(37, 52);
            this.ExpenseDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ExpenseDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ExpenseDatePicker.Name = "ExpenseDatePicker";
            this.ExpenseDatePicker.ShadowDecoration.Parent = this.ExpenseDatePicker;
            this.ExpenseDatePicker.Size = new System.Drawing.Size(291, 36);
            this.ExpenseDatePicker.TabIndex = 0;
            this.ExpenseDatePicker.Value = new System.DateTime(2021, 3, 5, 0, 0, 0, 0);
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.Transparent;
            this.txtType.BorderColor = System.Drawing.Color.Gray;
            this.txtType.BorderThickness = 2;
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.DefaultText = "";
            this.txtType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtType.DisabledState.Parent = this.txtType;
            this.txtType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtType.FocusedState.Parent = this.txtType;
            this.txtType.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtType.HoverState.Parent = this.txtType;
            this.txtType.Location = new System.Drawing.Point(37, 111);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtType.PlaceholderText = "Expense Type";
            this.txtType.SelectedText = "";
            this.txtType.ShadowDecoration.Parent = this.txtType;
            this.txtType.Size = new System.Drawing.Size(291, 36);
            this.txtType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtType.TabIndex = 1;
            // 
            // AddExpenseGridView
            // 
            this.AddExpenseGridView.AllowUserToAddRows = false;
            this.AddExpenseGridView.AllowUserToDeleteRows = false;
            this.AddExpenseGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.AddExpenseGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AddExpenseGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AddExpenseGridView.BackgroundColor = System.Drawing.Color.White;
            this.AddExpenseGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddExpenseGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AddExpenseGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddExpenseGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AddExpenseGridView.ColumnHeadersHeight = 21;
            this.AddExpenseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AddExpenseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AddExpenseGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AddExpenseGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AddExpenseGridView.EnableHeadersVisualStyles = false;
            this.AddExpenseGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.AddExpenseGridView.Location = new System.Drawing.Point(26, 274);
            this.AddExpenseGridView.Name = "AddExpenseGridView";
            this.AddExpenseGridView.RowHeadersVisible = false;
            this.AddExpenseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddExpenseGridView.Size = new System.Drawing.Size(738, 239);
            this.AddExpenseGridView.TabIndex = 22;
            this.AddExpenseGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.AddExpenseGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.AddExpenseGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AddExpenseGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AddExpenseGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AddExpenseGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AddExpenseGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AddExpenseGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.AddExpenseGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.AddExpenseGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AddExpenseGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AddExpenseGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AddExpenseGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AddExpenseGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.AddExpenseGridView.ThemeStyle.ReadOnly = false;
            this.AddExpenseGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.AddExpenseGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AddExpenseGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AddExpenseGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AddExpenseGridView.ThemeStyle.RowsStyle.Height = 22;
            this.AddExpenseGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.AddExpenseGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AddExpenseGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AddExpenseGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Expense Type";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Expense Amount";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Remarks";
            this.Column4.Name = "Column4";
            // 
            // ElipseAddExpense
            // 
            this.ElipseAddExpense.BorderRadius = 0;
            this.ElipseAddExpense.TargetControl = this;
            // 
            // UC_AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AddExpenseGridView);
            this.Controls.Add(this.groupBoxAddExp);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddExpense";
            this.Size = new System.Drawing.Size(797, 527);
            this.groupBoxAddExp.ResumeLayout(false);
            this.groupBoxAddExp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddExpenseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAddExp;
        private Guna.UI2.WinForms.Guna2TextBox txtType;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker ExpenseDatePicker;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtRemarks;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnAddToList;
        private Guna.UI2.WinForms.Guna2DataGridView AddExpenseGridView;
        private Guna.UI2.WinForms.Guna2Elipse ElipseAddExpense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
