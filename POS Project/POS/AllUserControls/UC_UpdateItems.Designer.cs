
namespace POS.AllUserControls
{
    partial class UC_UpdateItems
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
            this.Elipse_UpdateItems = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdateOrderGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateOrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse_UpdateItems
            // 
            this.Elipse_UpdateItems.BorderRadius = 0;
            this.Elipse_UpdateItems.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(266, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "UPDATE ITEM";
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchItem.BorderColor = System.Drawing.Color.Gray;
            this.txtSearchItem.BorderThickness = 2;
            this.txtSearchItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchItem.DefaultText = "";
            this.txtSearchItem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchItem.DisabledState.Parent = this.txtSearchItem;
            this.txtSearchItem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearchItem.FocusedState.Parent = this.txtSearchItem;
            this.txtSearchItem.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtSearchItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtSearchItem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtSearchItem.HoverState.Parent = this.txtSearchItem;
            this.txtSearchItem.Location = new System.Drawing.Point(457, 80);
            this.txtSearchItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PasswordChar = '\0';
            this.txtSearchItem.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchItem.PlaceholderText = "Search Item";
            this.txtSearchItem.SelectedText = "";
            this.txtSearchItem.ShadowDecoration.Parent = this.txtSearchItem;
            this.txtSearchItem.Size = new System.Drawing.Size(291, 36);
            this.txtSearchItem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchItem.TabIndex = 11;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // UpdateOrderGridView
            // 
            this.UpdateOrderGridView.AllowUserToAddRows = false;
            this.UpdateOrderGridView.AllowUserToDeleteRows = false;
            this.UpdateOrderGridView.AllowUserToResizeColumns = false;
            this.UpdateOrderGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.UpdateOrderGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UpdateOrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UpdateOrderGridView.BackgroundColor = System.Drawing.Color.White;
            this.UpdateOrderGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UpdateOrderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UpdateOrderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateOrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UpdateOrderGridView.ColumnHeadersHeight = 21;
            this.UpdateOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UpdateOrderGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UpdateOrderGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.UpdateOrderGridView.EnableHeadersVisualStyles = false;
            this.UpdateOrderGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.UpdateOrderGridView.Location = new System.Drawing.Point(48, 135);
            this.UpdateOrderGridView.Name = "UpdateOrderGridView";
            this.UpdateOrderGridView.RowHeadersVisible = false;
            this.UpdateOrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UpdateOrderGridView.Size = new System.Drawing.Size(701, 222);
            this.UpdateOrderGridView.TabIndex = 20;
            this.UpdateOrderGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.UpdateOrderGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.UpdateOrderGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.UpdateOrderGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.UpdateOrderGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.UpdateOrderGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.UpdateOrderGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UpdateOrderGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.UpdateOrderGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.UpdateOrderGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UpdateOrderGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UpdateOrderGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.UpdateOrderGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.UpdateOrderGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.UpdateOrderGridView.ThemeStyle.ReadOnly = false;
            this.UpdateOrderGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.UpdateOrderGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UpdateOrderGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.UpdateOrderGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.UpdateOrderGridView.ThemeStyle.RowsStyle.Height = 22;
            this.UpdateOrderGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.UpdateOrderGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.UpdateOrderGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateOrderGridView_CellClick);
            this.UpdateOrderGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpdateOrderGridView_CellContentClick);
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.BorderColor = System.Drawing.Color.Gray;
            this.txtCategory.BorderThickness = 2;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.DefaultText = "";
            this.txtCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategory.DisabledState.Parent = this.txtCategory;
            this.txtCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtCategory.FocusedState.Parent = this.txtCategory;
            this.txtCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtCategory.ForeColor = System.Drawing.Color.Black;
            this.txtCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtCategory.HoverState.Parent = this.txtCategory;
            this.txtCategory.Location = new System.Drawing.Point(99, 378);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtCategory.PlaceholderText = "Category";
            this.txtCategory.SelectedText = "";
            this.txtCategory.ShadowDecoration.Parent = this.txtCategory;
            this.txtCategory.Size = new System.Drawing.Size(244, 36);
            this.txtCategory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCategory.TabIndex = 21;
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
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(434, 378);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtPrice.PlaceholderText = "Unit Price";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(244, 36);
            this.txtPrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPrice.TabIndex = 22;
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
            this.txtItemName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtItemName.FocusedState.Parent = this.txtItemName;
            this.txtItemName.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtItemName.ForeColor = System.Drawing.Color.Black;
            this.txtItemName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.txtItemName.HoverState.Parent = this.txtItemName;
            this.txtItemName.Location = new System.Drawing.Point(99, 462);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtItemName.PlaceholderText = "Item Name";
            this.txtItemName.SelectedText = "";
            this.txtItemName.ShadowDecoration.Parent = this.txtItemName;
            this.txtItemName.Size = new System.Drawing.Size(244, 36);
            this.txtItemName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtItemName.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnUpdate.BorderThickness = 2;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnUpdate.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(194)))), ((int)(((byte)(16)))));
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Location = new System.Drawing.Point(553, 462);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(125, 36);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UC_UpdateItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.UpdateOrderGridView);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.label1);
            this.Name = "UC_UpdateItems";
            this.Size = new System.Drawing.Size(797, 527);
            this.Load += new System.EventHandler(this.UC_UpdateItems_Load);
            this.Enter += new System.EventHandler(this.UC_UpdateItems_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateOrderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse_UpdateItems;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchItem;
        private Guna.UI2.WinForms.Guna2DataGridView UpdateOrderGridView;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private Guna.UI2.WinForms.Guna2TextBox txtCategory;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
    }
}
