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
    public partial class EditCustomer : Form
    {

        private bool isEditing = false;
        private int editId;

        public EditCustomer()
        {
            InitializeComponent();
            this.isEditing = false;
            checkEditing();
        }

        public EditCustomer(int editId)
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
                customerIdInput.Hide();
            }
            else
            {
                // is Editing
                customerIdInput.Text = editId.ToString();
                using (DBHelper db = new DBHelper())
                {
                    DataRow dr = db.QueryDataRow("SELECT * FROM Persons.Customer WHERE id = " + editId.ToString());
                    customerNameInput.Text = dr["first_name"].ToString();
                    customerLastNameInput.Text = dr["last_name"].ToString();
                    customerUsernameInput.Text = dr["login"].ToString();
                    //customerPasswordInput.Text = dr["password"].ToString();
                    customerPhoneInput.Text = dr["phone"].ToString();
                }
            }
        }


        private void customerAddUpdateBtn_Click(object sender, EventArgs e)
        {
            if (customerNameInput.Text != "" && customerLastNameInput.Text != "" && customerUsernameInput.Text != "" && customerPhoneInput.Text != "")
            {
                using (DBHelper db = new DBHelper())
                {
                    if (!isEditing)
                    {
                        if (customerPasswordInput.Text != "")
                        {

                            if (db.SimpleQuery("INSERT INTO Persons.Customer(first_name, last_name, login, password, phone) " +
                                " VALUES ('" + customerNameInput.Text + "', '" + customerLastNameInput.Text + "', '" + customerUsernameInput.Text + "', '" + MiscHelpers.CreateMD5(customerPasswordInput.Text) + "', '" + customerPhoneInput.Text + "')") >= 1)
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
                        if (db.SimpleQuery("UPDATE Persons.Customer SET " +
                            "first_name = '" + customerNameInput.Text + "', last_name='" + customerLastNameInput.Text + "', login='" + customerUsernameInput.Text + "', phone='" + customerPhoneInput.Text + "' WHERE id = " + editId) >= 1)
                        {
                            if (customerPasswordInput.Text != "")
                            {
                                db.SimpleQuery("UPDATE Persons.Customer SET " +
                                        "password='" + MiscHelpers.CreateMD5(customerPasswordInput.Text) + "' WHERE id = " + editId);
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
    }
}

