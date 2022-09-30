using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class EditSeller : Form
    {
        private bool isEditing = false;
        private int editId;
        public EditSeller()
        {
            InitializeComponent();
            this.isEditing = false;
            checkEditing();
        }

        public EditSeller(int editId)
        {
            InitializeComponent();
            this.isEditing = true;
            this.editId = editId;
            checkEditing();

        }

        private void checkEditing()
        {
            if (!isEditing)
            {
                sellerIdInput.Hide();
            }
            else
            {
                // is Editing
                sellerIdInput.Text = editId.ToString();
                using (DBHelper db = new DBHelper())
                {
                    DataRow dr = db.QueryDataRow("SELECT * FROM Persons.Seller WHERE id = " + editId.ToString());
                    sellerNameInput.Text = dr["first_name"].ToString();
                    sellerLastNameInput.Text = dr["last_name"].ToString();
                    phoneInput.Text = dr["phone"].ToString();
                    sellerWebsiteInput.Text = dr["website"].ToString();
                    sellerCompanyInput.Text = dr["company_name"].ToString();
                    sellerDescriptionInput.Text = dr["profile_description"].ToString();
                    
                }
            }
        }


        private void sellerAddUpdateBtn_Click(object sender, EventArgs e)
        {
            if (sellerNameInput.Text != "" && sellerLastNameInput.Text != "" && sellerWebsiteInput.Text != "" && sellerCompanyInput.Text != "" && phoneInput.Text != "" && sellerDescriptionInput.Text != "")
            {
                using (DBHelper db = new DBHelper())
                {
                    try
                    {
                        if (!isEditing)
                        {
                            if (db.SimpleQuery("INSERT INTO Persons.Seller (first_name, last_name, website, company_name, profile_description, phone) " +
                                " VALUES ('" + MiscHelpers.escapeSQL(sellerNameInput.Text) + "', '" + MiscHelpers.escapeSQL(sellerLastNameInput.Text) + "', '" + MiscHelpers.escapeSQL(sellerWebsiteInput.Text) + "', '" + MiscHelpers.escapeSQL(sellerCompanyInput.Text) + "', '" + MiscHelpers.escapeSQL(sellerDescriptionInput.Text) + "', '" + MiscHelpers.escapeSQL(phoneInput.Text) + "')") >= 1)
                            {
                                MessageBox.Show("Created!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Some Error Occured while Creating!");
                            }

                        }
                        else
                        {
                            if (db.SimpleQuery("UPDATE Persons.Seller SET " +
                                "first_name = '" + MiscHelpers.escapeSQL(sellerNameInput.Text) + "', last_name='" + MiscHelpers.escapeSQL(sellerLastNameInput.Text) + "', phone='" + MiscHelpers.escapeSQL(phoneInput.Text) + "', website='" + MiscHelpers.escapeSQL(sellerWebsiteInput.Text) + "' WHERE id = " + editId) >= 1)
                            {
                                MessageBox.Show("UPDATED!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Some Error Occured while Updating!");
                            }
                        }

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Some Error Occured!" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input correct values!");
            }
        }
    }
}