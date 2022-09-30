namespace DBProject.Admin
{
    partial class EditUtilities
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.nameInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.utilityNameLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.utilityLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.addUpdateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
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
            this.idInput.Location = new System.Drawing.Point(3, 42);
            this.idInput.Name = "idInput";
            this.idInput.PasswordChar = '\0';
            this.idInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.idInput.PlaceholderText = "Utility ID";
            this.idInput.SelectedText = "";
            this.idInput.Size = new System.Drawing.Size(67, 34);
            this.idInput.TabIndex = 30;
            this.idInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.nameInput);
            this.guna2Panel1.Controls.Add(this.utilityNameLbl);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 76);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(8);
            this.guna2Panel1.Size = new System.Drawing.Size(682, 192);
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
            this.nameInput.Location = new System.Drawing.Point(8, 40);
            this.nameInput.Name = "nameInput";
            this.nameInput.PasswordChar = '\0';
            this.nameInput.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.nameInput.PlaceholderText = "Name";
            this.nameInput.SelectedText = "";
            this.nameInput.Size = new System.Drawing.Size(666, 47);
            this.nameInput.TabIndex = 22;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // utilityNameLbl
            // 
            this.utilityNameLbl.AutoSize = false;
            this.utilityNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.utilityNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.utilityNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilityNameLbl.ForeColor = System.Drawing.Color.White;
            this.utilityNameLbl.Location = new System.Drawing.Point(8, 8);
            this.utilityNameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.utilityNameLbl.Name = "utilityNameLbl";
            this.utilityNameLbl.Size = new System.Drawing.Size(666, 32);
            this.utilityNameLbl.TabIndex = 21;
            this.utilityNameLbl.Text = "Utility Name";
            this.utilityNameLbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // utilityLbl
            // 
            this.utilityLbl.AutoSize = false;
            this.utilityLbl.BackColor = System.Drawing.Color.Transparent;
            this.utilityLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.utilityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilityLbl.ForeColor = System.Drawing.Color.White;
            this.utilityLbl.Location = new System.Drawing.Point(0, 0);
            this.utilityLbl.Name = "utilityLbl";
            this.utilityLbl.Size = new System.Drawing.Size(682, 76);
            this.utilityLbl.TabIndex = 29;
            this.utilityLbl.Text = "Utilities";
            this.utilityLbl.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // addUpdateBtn
            // 
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
            this.addUpdateBtn.Location = new System.Drawing.Point(0, 402);
            this.addUpdateBtn.Name = "addUpdateBtn";
            this.addUpdateBtn.Size = new System.Drawing.Size(682, 42);
            this.addUpdateBtn.TabIndex = 31;
            this.addUpdateBtn.Text = "Add/Update";
            this.addUpdateBtn.Click += new System.EventHandler(this.addUpdateBtn_Click);
            // 
            // AddUtilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(682, 444);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.utilityLbl);
            this.Controls.Add(this.addUpdateBtn);
            this.Name = "AddUtilities";
            this.Text = "AddUtilities";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox idInput;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox nameInput;
        private Guna.UI2.WinForms.Guna2HtmlLabel utilityNameLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel utilityLbl;
        private Guna.UI2.WinForms.Guna2GradientButton addUpdateBtn;
    }
}