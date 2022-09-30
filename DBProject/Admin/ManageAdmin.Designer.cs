namespace DBProject.Admin
{
    partial class ManageAdmin
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
            this.adminIdInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminNameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminPhoneInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.adminSearchBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.adminGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.adminAddBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.adminIdInput);
            this.flowLayoutPanel1.Controls.Add(this.adminNameInput);
            this.flowLayoutPanel1.Controls.Add(this.adminPhoneInput);
            this.flowLayoutPanel1.Controls.Add(this.adminSearchBtn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 73);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(875, 58);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // adminIdInput
            // 
            this.adminIdInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminIdInput.DefaultText = "";
            this.adminIdInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminIdInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminIdInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminIdInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminIdInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminIdInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminIdInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminIdInput.Location = new System.Drawing.Point(11, 11);
            this.adminIdInput.Name = "adminIdInput";
            this.adminIdInput.PasswordChar = '\0';
            this.adminIdInput.PlaceholderText = "Search by id";
            this.adminIdInput.SelectedText = "";
            this.adminIdInput.Size = new System.Drawing.Size(200, 36);
            this.adminIdInput.TabIndex = 26;
            // 
            // adminNameInput
            // 
            this.adminNameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminNameInput.DefaultText = "";
            this.adminNameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminNameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminNameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminNameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminNameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminNameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminNameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminNameInput.Location = new System.Drawing.Point(217, 11);
            this.adminNameInput.Name = "adminNameInput";
            this.adminNameInput.PasswordChar = '\0';
            this.adminNameInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.adminNameInput.PlaceholderText = "Search by Name";
            this.adminNameInput.SelectedText = "";
            this.adminNameInput.Size = new System.Drawing.Size(283, 35);
            this.adminNameInput.TabIndex = 22;
            // 
            // adminPhoneInput
            // 
            this.adminPhoneInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adminPhoneInput.DefaultText = "";
            this.adminPhoneInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adminPhoneInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adminPhoneInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminPhoneInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adminPhoneInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminPhoneInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adminPhoneInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adminPhoneInput.Location = new System.Drawing.Point(506, 11);
            this.adminPhoneInput.Name = "adminPhoneInput";
            this.adminPhoneInput.PasswordChar = '\0';
            this.adminPhoneInput.PlaceholderText = "Phone Number";
            this.adminPhoneInput.SelectedText = "";
            this.adminPhoneInput.Size = new System.Drawing.Size(200, 36);
            this.adminPhoneInput.TabIndex = 25;
            // 
            // adminSearchBtn
            // 
            this.adminSearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminSearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminSearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminSearchBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminSearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminSearchBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.adminSearchBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.adminSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adminSearchBtn.ForeColor = System.Drawing.Color.White;
            this.adminSearchBtn.Location = new System.Drawing.Point(712, 11);
            this.adminSearchBtn.Name = "adminSearchBtn";
            this.adminSearchBtn.Size = new System.Drawing.Size(133, 36);
            this.adminSearchBtn.TabIndex = 23;
            this.adminSearchBtn.Text = "Search";
            this.adminSearchBtn.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // adminGrid
            // 
            this.adminGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.adminGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adminGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adminGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.adminGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adminGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.adminGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adminGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adminGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adminGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.adminGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminGrid.EnableHeadersVisualStyles = false;
            this.adminGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.adminGrid.Location = new System.Drawing.Point(0, 131);
            this.adminGrid.Name = "adminGrid";
            this.adminGrid.ReadOnly = true;
            this.adminGrid.RowHeadersVisible = false;
            this.adminGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adminGrid.Size = new System.Drawing.Size(875, 387);
            this.adminGrid.TabIndex = 27;
            this.adminGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.adminGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.adminGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.adminGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.adminGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.adminGrid.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.adminGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.adminGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.adminGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.adminGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.adminGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.adminGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.adminGrid.ThemeStyle.HeaderStyle.Height = 30;
            this.adminGrid.ThemeStyle.ReadOnly = true;
            this.adminGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.adminGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.adminGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.adminGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.adminGrid.ThemeStyle.RowsStyle.Height = 22;
            this.adminGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.adminGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.adminGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.adminGrid_CellDoubleClick);
            this.adminGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.adminGrid_UserDeletingRow);
            // 
            // adminAddBtn
            // 
            this.adminAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminAddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.adminAddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.adminAddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminAddBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.adminAddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.adminAddBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.adminAddBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.adminAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.adminAddBtn.ForeColor = System.Drawing.Color.White;
            this.adminAddBtn.Location = new System.Drawing.Point(730, 32);
            this.adminAddBtn.Name = "adminAddBtn";
            this.adminAddBtn.Size = new System.Drawing.Size(133, 35);
            this.adminAddBtn.TabIndex = 28;
            this.adminAddBtn.Text = "Add";
            this.adminAddBtn.Click += new System.EventHandler(this.buyerLoginBtn_Click);
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
            this.guna2HtmlLabel1.TabIndex = 26;
            this.guna2HtmlLabel1.Text = "Admins";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // ManageAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(875, 518);
            this.Controls.Add(this.adminGrid);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.adminAddBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "ManageAdmin";
            this.Text = "Admin";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox adminNameInput;
        private Guna.UI2.WinForms.Guna2GradientButton adminSearchBtn;
        private Guna.UI2.WinForms.Guna2DataGridView adminGrid;
        private Guna.UI2.WinForms.Guna2GradientButton adminAddBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox adminPhoneInput;
        private Guna.UI2.WinForms.Guna2TextBox adminIdInput;
    }
}