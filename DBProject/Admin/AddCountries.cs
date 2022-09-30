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
    public partial class AddCountries : Form
    {
        private bool isEditing = false;
        private int editId;

        public AddCountries()
        {
            InitializeComponent();
            this.isEditing = false;
            checkEditing();
        }

        public AddCountries(int editId)
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
                // is Editing Then
                idInput.Text = editId.ToString();
            }
        }
        private void addUpdateBtn_Click(object sender, EventArgs e)
        {
            if (nameInput.Text != "")
            {
                using (DBHelper db = new DBHelper())
                {
                    if (!isEditing)
                    {
                        if (db.SimpleQuery("INSERT INTO Locations.Countries (name) VALUES ('" + nameInput.Text + "')") >= 1)
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
                        if (db.SimpleQuery("UPDATE Locations.Countries SET name = '" + nameInput.Text + "'") >= 1)
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
            }
            else
            {
                MessageBox.Show("Please input correct values!");
            }
        }
    }
}
