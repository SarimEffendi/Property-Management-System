namespace DBProject.Admin
{
    partial class AddCities
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
            this.countryInput = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.longInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.latInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.nameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idInput
            // 
            this.idInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.idInput.BorderThickness = 5;
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
            this.idInput.Location = new System.Drawing.Point(3, 71);
            this.idInput.Name = "idInput";
            this.idInput.PasswordChar = '\0';
            this.idInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.idInput.PlaceholderText = "City ID";
            this.idInput.ReadOnly = true;
            this.idInput.SelectedText = "";
            this.idInput.Size = new System.Drawing.Size(83, 38);
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
            this.pageTitleLbl.Size = new System.Drawing.Size(748, 109);
            this.pageTitleLbl.TabIndex = 29;
            this.pageTitleLbl.Text = "Cities";
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
            this.addUpdateBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUpdateBtn.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.addUpdateBtn.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.addUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.addUpdateBtn.Location = new System.Drawing.Point(0, 486);
            this.addUpdateBtn.Name = "addUpdateBtn";
            this.addUpdateBtn.Size = new System.Drawing.Size(748, 39);
            this.addUpdateBtn.TabIndex = 30;
            this.addUpdateBtn.Text = "Add/Update";
            this.addUpdateBtn.Click += new System.EventHandler(this.addUpdateBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.countryInput);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.longInput);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.latInput);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel1.Controls.Add(this.nameInput);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 109);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(8);
            this.guna2Panel1.Size = new System.Drawing.Size(748, 377);
            this.guna2Panel1.TabIndex = 32;
            // 
            // countryInput
            // 
            this.countryInput.BackColor = System.Drawing.Color.Transparent;
            this.countryInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.countryInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.countryInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.countryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryInput.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countryInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.countryInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.countryInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.countryInput.ItemHeight = 30;
            this.countryInput.Location = new System.Drawing.Point(8, 274);
            this.countryInput.Name = "countryInput";
            this.countryInput.Size = new System.Drawing.Size(732, 36);
            this.countryInput.TabIndex = 28;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(8, 238);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(732, 36);
            this.guna2HtmlLabel4.TabIndex = 27;
            this.guna2HtmlLabel4.Text = "Country";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // longInput
            // 
            this.longInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.longInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.longInput.DefaultText = "";
            this.longInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.longInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.longInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.longInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.longInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.longInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.longInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.longInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.longInput.Location = new System.Drawing.Point(8, 199);
            this.longInput.Name = "longInput";
            this.longInput.PasswordChar = '\0';
            this.longInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.longInput.PlaceholderText = "Longitude";
            this.longInput.SelectedText = "";
            this.longInput.Size = new System.Drawing.Size(732, 39);
            this.longInput.TabIndex = 26;
            this.longInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(8, 163);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(732, 36);
            this.guna2HtmlLabel2.TabIndex = 25;
            this.guna2HtmlLabel2.Text = "longitude";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latInput
            // 
            this.latInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.latInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.latInput.DefaultText = "";
            this.latInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.latInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.latInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.latInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.latInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.latInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.latInput.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.latInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.latInput.Location = new System.Drawing.Point(8, 123);
            this.latInput.Name = "latInput";
            this.latInput.PasswordChar = '\0';
            this.latInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.latInput.PlaceholderText = "latitude";
            this.latInput.SelectedText = "";
            this.latInput.Size = new System.Drawing.Size(732, 40);
            this.latInput.TabIndex = 24;
            this.latInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(8, 88);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(732, 35);
            this.guna2HtmlLabel6.TabIndex = 23;
            this.guna2HtmlLabel6.Text = "latitude";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.nameInput.Location = new System.Drawing.Point(8, 46);
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nameInput.PlaceholderText = "Name";
            this.nameInput.SelectedText = "";
            this.nameInput.Size = new System.Drawing.Size(732, 42);
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
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(732, 38);
            this.guna2HtmlLabel3.TabIndex = 21;
            this.guna2HtmlLabel3.Text = "City Name";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(748, 565);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.addUpdateBtn);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pageTitleLbl);
            this.Name = "AddCities";
            this.Text = "AddCities";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox idInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel pageTitleLbl;
        private Guna.UI2.WinForms.Guna2GradientButton addUpdateBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox nameInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox countryInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox longInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox latInput;
    }
}