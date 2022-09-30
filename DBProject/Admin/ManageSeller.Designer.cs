namespace DBProject.Admin
{
    partial class ManageSeller
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.sellerIdInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.sellerNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.sellerCompanyInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.sellerPhoneInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.sellerSearchBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sellerGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sellerAddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.sellerIdInput);
            this.flowLayoutPanel1.Controls.Add(this.sellerNameInput);
            this.flowLayoutPanel1.Controls.Add(this.sellerCompanyInput);
            this.flowLayoutPanel1.Controls.Add(this.sellerPhoneInput);
            this.flowLayoutPanel1.Controls.Add(this.sellerSearchBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(875, 100);
            this.flowLayoutPanel1.TabIndex = 33;
            // 
            // sellerIdInput
            // 
            this.sellerIdInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellerIdInput.DefaultText = "";
            this.sellerIdInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sellerIdInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sellerIdInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sellerIdInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sellerIdInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellerIdInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sellerIdInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellerIdInput.Location = new System.Drawing.Point(11, 11);
            this.sellerIdInput.Name = "sellerIdInput";
            this.sellerIdInput.PasswordChar = '\0';
            this.sellerIdInput.PlaceholderText = "Search by id";
            this.sellerIdInput.SelectedText = "";
            this.sellerIdInput.Size = new System.Drawing.Size(200, 36);
            this.sellerIdInput.TabIndex = 37;
            // 
            // sellerNameInput
            // 
            this.sellerNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellerNameInput.DefaultText = "";
            this.sellerNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sellerNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sellerNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sellerNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sellerNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellerNameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sellerNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellerNameInput.Location = new System.Drawing.Point(217, 11);
            this.sellerNameInput.Name = "sellerNameInput";
            this.sellerNameInput.PasswordChar = '\0';
            this.sellerNameInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sellerNameInput.PlaceholderText = "search by name";
            this.sellerNameInput.SelectedText = "";
            this.sellerNameInput.Size = new System.Drawing.Size(348, 35);
            this.sellerNameInput.TabIndex = 22;
            // 
            // sellerCompanyInput
            // 
            this.sellerCompanyInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellerCompanyInput.DefaultText = "";
            this.sellerCompanyInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sellerCompanyInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sellerCompanyInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sellerCompanyInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sellerCompanyInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellerCompanyInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sellerCompanyInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellerCompanyInput.Location = new System.Drawing.Point(571, 11);
            this.sellerCompanyInput.Name = "sellerCompanyInput";
            this.sellerCompanyInput.PasswordChar = '\0';
            this.sellerCompanyInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.sellerCompanyInput.PlaceholderText = "search by company name";
            this.sellerCompanyInput.SelectedText = "";
            this.sellerCompanyInput.Size = new System.Drawing.Size(285, 35);
            this.sellerCompanyInput.TabIndex = 25;
            // 
            // sellerPhoneInput
            // 
            this.sellerPhoneInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellerPhoneInput.DefaultText = "";
            this.sellerPhoneInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sellerPhoneInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sellerPhoneInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sellerPhoneInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sellerPhoneInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellerPhoneInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sellerPhoneInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sellerPhoneInput.Location = new System.Drawing.Point(11, 53);
            this.sellerPhoneInput.Name = "sellerPhoneInput";
            this.sellerPhoneInput.PasswordChar = '\0';
            this.sellerPhoneInput.PlaceholderText = "Phone Number";
            this.sellerPhoneInput.SelectedText = "";
            this.sellerPhoneInput.Size = new System.Drawing.Size(200, 36);
            this.sellerPhoneInput.TabIndex = 36;
            // 
            // sellerSearchBtn
            // 
            this.sellerSearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sellerSearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sellerSearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sellerSearchBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sellerSearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sellerSearchBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.sellerSearchBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.sellerSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sellerSearchBtn.ForeColor = System.Drawing.Color.White;
            this.sellerSearchBtn.Location = new System.Drawing.Point(217, 53);
            this.sellerSearchBtn.Name = "sellerSearchBtn";
            this.sellerSearchBtn.Size = new System.Drawing.Size(133, 36);
            this.sellerSearchBtn.TabIndex = 23;
            this.sellerSearchBtn.Text = "Search";
            this.sellerSearchBtn.Click += new System.EventHandler(this.sellerSearchBtn_Click);
            // 
            // sellerGrid
            // 
            this.sellerGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.sellerGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sellerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sellerGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.sellerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sellerGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellerGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sellerGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sellerGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sellerGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.sellerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellerGrid.EnableHeadersVisualStyles = false;
            this.sellerGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellerGrid.Location = new System.Drawing.Point(0, 173);
            this.sellerGrid.Name = "sellerGrid";
            this.sellerGrid.ReadOnly = true;
            this.sellerGrid.RowHeadersVisible = false;
            this.sellerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sellerGrid.Size = new System.Drawing.Size(875, 345);
            this.sellerGrid.TabIndex = 31;
            this.sellerGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.sellerGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.sellerGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.sellerGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.sellerGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.sellerGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.sellerGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellerGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.sellerGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sellerGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellerGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.sellerGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.sellerGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.sellerGrid.ThemeStyle.ReadOnly = true;
            this.sellerGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.sellerGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.sellerGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.sellerGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellerGrid.ThemeStyle.RowsStyle.Height = 22;
            this.sellerGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.sellerGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.sellerGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellerGrid_CellDoubleClick);
            this.sellerGrid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.sellerGrid_UserDeletedRow);
            // 
            // sellerAddBtn
            // 
            this.sellerAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sellerAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sellerAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sellerAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sellerAddBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sellerAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sellerAddBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.sellerAddBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.sellerAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sellerAddBtn.ForeColor = System.Drawing.Color.White;
            this.sellerAddBtn.Location = new System.Drawing.Point(719, 32);
            this.sellerAddBtn.Name = "sellerAddBtn";
            this.sellerAddBtn.Size = new System.Drawing.Size(133, 35);
            this.sellerAddBtn.TabIndex = 32;
            this.sellerAddBtn.Text = "Add";
            this.sellerAddBtn.Click += new System.EventHandler(this.sellerAddBtn_Click);
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
            this.guna2HtmlLabel1.Text = "Sellers";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ManageSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(875, 518);
            this.Controls.Add(this.sellerGrid);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.sellerAddBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ManageSeller";
            this.Text = "Seller";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellerGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox sellerNameInput;
        private Guna.UI2.WinForms.Guna2GradientButton sellerSearchBtn;
        private Guna.UI2.WinForms.Guna2TextBox sellerCompanyInput;
        private Guna.UI2.WinForms.Guna2DataGridView sellerGrid;
        private Guna.UI2.WinForms.Guna2GradientButton sellerAddBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox sellerIdInput;
        private Guna.UI2.WinForms.Guna2TextBox sellerPhoneInput;
    }
}