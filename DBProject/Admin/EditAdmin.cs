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
    public partial class EditAdmin : Form
    {
        private bool isEditing = false;
        private int editId;

        public EditAdmin()
        {
            InitializeComponent();
            this.isEditing = false;
            checkEditing();
        }

        public EditAdmin(int editId)
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
                idInput.Hide();
            }
            else
            {
                // is Editing
                idInput.Text = editId.ToString();
                using (DBHelper db = new DBHelper())
                {
                    DataRow dr = db.QueryDataRow("SELECT * FROM Persons.Admin WHERE id = " + editId.ToString());
                    adminNameInput.Text = dr["first_name"].ToString();
                    adminLastNameInput.Text = dr["last_name"].ToString();
                    adminUsernameInput.Text = dr["login"].ToString();
                    //adminPasswordInput.Text = dr["first_name"].ToString();
                    phoneInput.Text = dr["phone"].ToString();
                }
            }
        }

        private void adminAddUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (adminNameInput.Text != "" && adminLastNameInput.Text != "" && adminUsernameInput.Text != "" && phoneInput.Text != "")
                {
                    using (DBHelper db = new DBHelper())
                    {
                        if (!isEditing)
                        {
                            if (adminPasswordInput.Text != "")
                            {

                                if (db.SimpleQuery("INSERT INTO Persons.Admin (first_name, last_name, login, password, phone) " +
                                    " VALUES ('" + adminNameInput.Text + "', '" + adminLastNameInput.Text + "', '" + adminUsernameInput.Text + "', '" + MiscHelpers.CreateMD5(adminPasswordInput.Text) + "', '" + phoneInput.Text + "')") >= 1)
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
                                MessageBox.Show("Please input correct values!");
                            }
                        }
                        else
                        {
                            if (db.SimpleQuery("UPDATE Persons.Admin SET " +
                                "first_name = '" + adminNameInput.Text + "', last_name='" + adminLastNameInput.Text + "', login='" + adminUsernameInput.Text + "', phone='" + phoneInput.Text + "' WHERE id = " + editId) >= 1)
                            {
                                if (adminPasswordInput.Text != "")
                                {
                                    db.SimpleQuery("UPDATE Persons.Admin SET " +
                                            "password='" + MiscHelpers.CreateMD5(adminPasswordInput.Text) + "' WHERE id = " + editId);
                                }
                                MessageBox.Show("UPDATED!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Some Error Occured while Updating!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please input correct values!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Some Error Occured!");

            }
        }
    }
}
