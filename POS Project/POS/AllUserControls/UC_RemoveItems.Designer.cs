
namespace POS.AllUserControls
{
    partial class UC_RemoveItems
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
            this.ElipseRemoveItems = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchItem = new Guna.UI2.WinForms.Guna2TextBox();
            this.DeleteOrderGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteOrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseRemoveItems
            // 
            this.ElipseRemoveItems.BorderRadius = 0;
            this.ElipseRemoveItems.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(226, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "REMOVE ITEM";
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
            this.txtSearchItem.Location = new System.Drawing.Point(456, 91);
            this.txtSearchItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.PasswordChar = '\0';
            this.txtSearchItem.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchItem.PlaceholderText = "Search Item";
            this.txtSearchItem.SelectedText = "";
            this.txtSearchItem.ShadowDecoration.Parent = this.txtSearchItem;
            this.txtSearchItem.Size = new System.Drawing.Size(291, 36);
            this.txtSearchItem.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchItem.TabIndex = 12;
            this.txtSearchItem.TextChanged += new System.EventHandler(this.txtSearchItem_TextChanged);
            // 
            // DeleteOrderGridView
            // 
            this.DeleteOrderGridView.AllowUserToAddRows = false;
            this.DeleteOrderGridView.AllowUserToDeleteRows = false;
            this.DeleteOrderGridView.AllowUserToResizeColumns = false;
            this.DeleteOrderGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DeleteOrderGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DeleteOrderGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeleteOrderGridView.BackgroundColor = System.Drawing.Color.White;
            this.DeleteOrderGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeleteOrderGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DeleteOrderGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteOrderGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DeleteOrderGridView.ColumnHeadersHeight = 21;
            this.DeleteOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteOrderGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DeleteOrderGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DeleteOrderGridView.EnableHeadersVisualStyles = false;
            this.DeleteOrderGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.DeleteOrderGridView.Location = new System.Drawing.Point(46, 158);
            this.DeleteOrderGridView.Name = "DeleteOrderGridView";
            this.DeleteOrderGridView.RowHeadersVisible = false;
            this.DeleteOrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeleteOrderGridView.Size = new System.Drawing.Size(701, 253);
            this.DeleteOrderGridView.TabIndex = 21;
            this.DeleteOrderGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.DeleteOrderGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DeleteOrderGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DeleteOrderGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DeleteOrderGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DeleteOrderGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DeleteOrderGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DeleteOrderGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.DeleteOrderGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.DeleteOrderGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DeleteOrderGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DeleteOrderGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DeleteOrderGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DeleteOrderGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.DeleteOrderGridView.ThemeStyle.ReadOnly = false;
            this.DeleteOrderGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DeleteOrderGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DeleteOrderGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DeleteOrderGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DeleteOrderGridView.ThemeStyle.RowsStyle.Height = 22;
            this.DeleteOrderGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.DeleteOrderGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DeleteOrderGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteOrderGridView_CellClick);
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
            this.btnRemove.Location = new System.Drawing.Point(622, 441);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(125, 36);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // UC_RemoveItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.DeleteOrderGridView);
            this.Controls.Add(this.txtSearchItem);
            this.Controls.Add(this.label1);
            this.Name = "UC_RemoveItems";
            this.Size = new System.Drawing.Size(797, 527);
            this.Load += new System.EventHandler(this.UC_RemoveItems_Load);
            this.Enter += new System.EventHandler(this.UC_RemoveItems_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteOrderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse ElipseRemoveItems;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchItem;
        private Guna.UI2.WinForms.Guna2DataGridView DeleteOrderGridView;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
    }
}
