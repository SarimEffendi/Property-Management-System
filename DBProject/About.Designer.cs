
namespace DBProject
{
    partial class About
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
            this.label1 = new System.Windows.Forms.Label();
            this.pageTitleLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1170, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "This project is mainly about making a Database System for Property/Real Estate Ma" +
    "nagement System with a user-friendly UI.  \r\n";
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
            this.pageTitleLbl.Size = new System.Drawing.Size(1079, 76);
            this.pageTitleLbl.TabIndex = 49;
            this.pageTitleLbl.Text = "About ";
            this.pageTitleLbl.TextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1079, 523);
            this.Controls.Add(this.pageTitleLbl);
            this.Controls.Add(this.label1);
            this.Name = "About";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel pageTitleLbl;
    }
}