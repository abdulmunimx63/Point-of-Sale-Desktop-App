
namespace POS.AllUserControls
{
    partial class UC_RemoveWrkr
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
            this.ElipseRemoveWrkr = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.RemoveWorkerGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveWorkerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ElipseRemoveWrkr
            // 
            this.ElipseRemoveWrkr.BorderRadius = 0;
            this.ElipseRemoveWrkr.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(252, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remove Worker";
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
            this.txtSearchName.Location = new System.Drawing.Point(456, 91);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.PasswordChar = '\0';
            this.txtSearchName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchName.PlaceholderText = "Search Name";
            this.txtSearchName.SelectedText = "";
            this.txtSearchName.ShadowDecoration.Parent = this.txtSearchName;
            this.txtSearchName.Size = new System.Drawing.Size(291, 36);
            this.txtSearchName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchName.TabIndex = 13;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // RemoveWorkerGridView
            // 
            this.RemoveWorkerGridView.AllowUserToAddRows = false;
            this.RemoveWorkerGridView.AllowUserToDeleteRows = false;
            this.RemoveWorkerGridView.AllowUserToResizeColumns = false;
            this.RemoveWorkerGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RemoveWorkerGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RemoveWorkerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RemoveWorkerGridView.BackgroundColor = System.Drawing.Color.White;
            this.RemoveWorkerGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RemoveWorkerGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RemoveWorkerGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RemoveWorkerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RemoveWorkerGridView.ColumnHeadersHeight = 21;
            this.RemoveWorkerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RemoveWorkerGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.RemoveWorkerGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.RemoveWorkerGridView.EnableHeadersVisualStyles = false;
            this.RemoveWorkerGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.RemoveWorkerGridView.Location = new System.Drawing.Point(46, 153);
            this.RemoveWorkerGridView.Name = "RemoveWorkerGridView";
            this.RemoveWorkerGridView.RowHeadersVisible = false;
            this.RemoveWorkerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RemoveWorkerGridView.Size = new System.Drawing.Size(701, 253);
            this.RemoveWorkerGridView.TabIndex = 22;
            this.RemoveWorkerGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.RemoveWorkerGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RemoveWorkerGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.RemoveWorkerGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.RemoveWorkerGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.RemoveWorkerGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.RemoveWorkerGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.RemoveWorkerGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.RemoveWorkerGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.RemoveWorkerGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RemoveWorkerGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RemoveWorkerGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.RemoveWorkerGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.RemoveWorkerGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.RemoveWorkerGridView.ThemeStyle.ReadOnly = false;
            this.RemoveWorkerGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.RemoveWorkerGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.RemoveWorkerGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.RemoveWorkerGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.RemoveWorkerGridView.ThemeStyle.RowsStyle.Height = 22;
            this.RemoveWorkerGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.RemoveWorkerGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.RemoveWorkerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RemoveWorkerGridView_CellClick);
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
            this.btnRemove.Location = new System.Drawing.Point(622, 444);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(125, 36);
            this.btnRemove.TabIndex = 26;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // UC_RemoveWrkr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.RemoveWorkerGridView);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label1);
            this.Name = "UC_RemoveWrkr";
            this.Size = new System.Drawing.Size(797, 527);
            this.Load += new System.EventHandler(this.UC_RemoveWrkr_Load);
            this.Enter += new System.EventHandler(this.UC_RemoveWrkr_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveWorkerGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse ElipseRemoveWrkr;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchName;
        private Guna.UI2.WinForms.Guna2DataGridView RemoveWorkerGridView;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
    }
}
