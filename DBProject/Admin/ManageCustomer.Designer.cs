namespace DBProject.Admin
{
    partial class ManageCustomer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.customerIdInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerPhoneInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.customerSearchBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.customerGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.customerAddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.customerIdInput);
            this.flowLayoutPanel1.Controls.Add(this.customerNameInput);
            this.flowLayoutPanel1.Controls.Add(this.customerPhoneInput);
            this.flowLayoutPanel1.Controls.Add(this.customerSearchBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(875, 58);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // customerIdInput
            // 
            this.customerIdInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerIdInput.DefaultText = "";
            this.customerIdInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerIdInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerIdInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIdInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerIdInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIdInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerIdInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerIdInput.Location = new System.Drawing.Point(11, 11);
            this.customerIdInput.Name = "customerIdInput";
            this.customerIdInput.PasswordChar = '\0';
            this.customerIdInput.PlaceholderText = "Search by id";
            this.customerIdInput.SelectedText = "";
            this.customerIdInput.Size = new System.Drawing.Size(200, 36);
            this.customerIdInput.TabIndex = 35;
            // 
            // customerNameInput
            // 
            this.customerNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerNameInput.DefaultText = "";
            this.customerNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerNameInput.Location = new System.Drawing.Point(217, 11);
            this.customerNameInput.Name = "customerNameInput";
            this.customerNameInput.PasswordChar = '\0';
            this.customerNameInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.customerNameInput.PlaceholderText = "search by name";
            this.customerNameInput.SelectedText = "";
            this.customerNameInput.Size = new System.Drawing.Size(318, 35);
            this.customerNameInput.TabIndex = 22;
            // 
            // customerPhoneInput
            // 
            this.customerPhoneInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerPhoneInput.DefaultText = "";
            this.customerPhoneInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.customerPhoneInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.customerPhoneInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerPhoneInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.customerPhoneInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerPhoneInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerPhoneInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.customerPhoneInput.Location = new System.Drawing.Point(541, 11);
            this.customerPhoneInput.Name = "customerPhoneInput";
            this.customerPhoneInput.PasswordChar = '\0';
            this.customerPhoneInput.PlaceholderText = "Phone Number";
            this.customerPhoneInput.SelectedText = "";
            this.customerPhoneInput.Size = new System.Drawing.Size(200, 36);
            this.customerPhoneInput.TabIndex = 34;
            // 
            // customerSearchBtn
            // 
            this.customerSearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerSearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerSearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerSearchBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerSearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerSearchBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.customerSearchBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.customerSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customerSearchBtn.ForeColor = System.Drawing.Color.White;
            this.customerSearchBtn.Location = new System.Drawing.Point(747, 11);
            this.customerSearchBtn.Name = "customerSearchBtn";
            this.customerSearchBtn.Size = new System.Drawing.Size(114, 36);
            this.customerSearchBtn.TabIndex = 23;
            this.customerSearchBtn.Text = "Search";
            this.customerSearchBtn.Click += new System.EventHandler(this.customerSearchBtn_Click);
            // 
            // customerGrid
            // 
            this.customerGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.customerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.customerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.customerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.customerGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.customerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerGrid.EnableHeadersVisualStyles = false;
            this.customerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerGrid.Location = new System.Drawing.Point(0, 131);
            this.customerGrid.Name = "customerGrid";
            this.customerGrid.ReadOnly = true;
            this.customerGrid.RowHeadersVisible = false;
            this.customerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerGrid.Size = new System.Drawing.Size(875, 387);
            this.customerGrid.TabIndex = 31;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.customerGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.customerGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.customerGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.customerGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.customerGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.customerGrid.ThemeStyle.ReadOnly = true;
            this.customerGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.customerGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customerGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.customerGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerGrid.ThemeStyle.RowsStyle.Height = 22;
            this.customerGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.customerGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.customerGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGrid_CellDoubleClick);
            this.customerGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.customerGrid_UserDeletingRow);
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.customerAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.customerAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerAddBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.customerAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.customerAddBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.customerAddBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.customerAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.customerAddBtn.ForeColor = System.Drawing.Color.White;
            this.customerAddBtn.Location = new System.Drawing.Point(728, 32);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(133, 35);
            this.customerAddBtn.TabIndex = 32;
            this.customerAddBtn.Text = "Add";
            this.customerAddBtn.Click += new System.EventHandler(this.customerAddBtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(875, 73);
            this.guna2HtmlLabel1.TabIndex = 30;
            this.guna2HtmlLabel1.Text = "Customer";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(875, 518);
            this.Controls.Add(this.customerGrid);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.customerAddBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ManageCustomer";
            this.Text = "Customer";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox customerNameInput;
        private Guna.UI2.WinForms.Guna2GradientButton customerSearchBtn;
        private Guna.UI2.WinForms.Guna2DataGridView customerGrid;
        private Guna.UI2.WinForms.Guna2GradientButton customerAddBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox customerIdInput;
        private Guna.UI2.WinForms.Guna2TextBox customerPhoneInput;
    }
}