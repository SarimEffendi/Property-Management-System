namespace DBProject.Admin
{
    partial class AddCountries
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
            this.idInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.pageTitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addUpdateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.nameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idInput
            // 
            this.idInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.idInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idInput.DefaultText = "";
            this.idInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idInput.Enabled = false;
            this.idInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idInput.Location = new System.Drawing.Point(8, 95);
            this.idInput.Name = "idInput";
            this.idInput.PasswordChar = '\0';
            this.idInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.idInput.PlaceholderText = "Country ID";
            this.idInput.ReadOnly = true;
            this.idInput.SelectedText = "";
            this.idInput.Size = new System.Drawing.Size(88, 34);
            this.idInput.TabIndex = 17;
            this.idInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pageTitleLbl
            // 
            this.pageTitleLbl.AutoSize = false;
            this.pageTitleLbl.BackColor = System.Drawing.Color.Transparent;
            this.pageTitleLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageTitleLbl.ForeColor = System.Drawing.Color.White;
            this.pageTitleLbl.Location = new System.Drawing.Point(0, 0);
            this.pageTitleLbl.Name = "pageTitleLbl";
            this.pageTitleLbl.Size = new System.Drawing.Size(748, 138);
            this.pageTitleLbl.TabIndex = 29;
            this.pageTitleLbl.Text = "Countries";
            this.pageTitleLbl.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // addUpdateBtn
            // 
            this.addUpdateBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.addUpdateBtn.BorderThickness = 3;
            this.addUpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUpdateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUpdateBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addUpdateBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.addUpdateBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.addUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.addUpdateBtn.Location = new System.Drawing.Point(0, 410);
            this.addUpdateBtn.Name = "addUpdateBtn";
            this.addUpdateBtn.Size = new System.Drawing.Size(748, 42);
            this.addUpdateBtn.TabIndex = 31;
            this.addUpdateBtn.Text = "Add/Update";
            this.addUpdateBtn.Click += new System.EventHandler(this.addUpdateBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.nameInput);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 138);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(8);
            this.guna2Panel1.Size = new System.Drawing.Size(748, 114);
            this.guna2Panel1.TabIndex = 32;
            // 
            // nameInput
            // 
            this.nameInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.nameInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameInput.DefaultText = "";
            this.nameInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameInput.Location = new System.Drawing.Point(8, 50);
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nameInput.PlaceholderText = "Name";
            this.nameInput.SelectedText = "";
            this.nameInput.Size = new System.Drawing.Size(732, 37);
            this.nameInput.TabIndex = 22;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(8, 8);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(732, 42);
            this.guna2HtmlLabel3.TabIndex = 21;
            this.guna2HtmlLabel3.Text = "Country Name";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(748, 452);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.addUpdateBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pageTitleLbl);
            this.Name = "AddCountries";
            this.Text = "AddCountries";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox idInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel pageTitleLbl;
        private Guna.UI2.WinForms.Guna2GradientButton addUpdateBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox nameInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}