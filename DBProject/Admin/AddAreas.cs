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
    public partial class AddAreas : Form
    {
        private bool isEditing = false;
        private int editId;

        public AddAreas()
        {
            InitializeComponent();
            this.isEditing = false;
            checkEditing();
        }

        public AddAreas(int editId)
        {
            InitializeComponent();
            this.isEditing = true;
            this.editId = editId;
            checkEditing();
        }

        private void checkEditing()
        {
            using (DBHelper db = new DBHelper())
            {
                DataTable dt = db.QueryDataTable("SELECT * FROM Locations.Cities");
                foreach (DataRow item in dt.Rows)
                {
                    cityInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }

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
                    DataRow dr = db.QueryDataRow("SELECT * FROM Locations.Areas WHERE id = " + editId.ToString());
                    nameInput.Text = dr["name"].ToString();
                    descriptionInput.Text = dr["lat"].ToString();

                    foreach (ComboboxItem item in cityInput.Items)
                    {
                        if (item.Value == dr["cityId"].ToString())
                        {
                            cityInput.SelectedItem = item;
                        }
                    }
                }
            }
        }

        private void addUpdateBtn_Click(object sender, EventArgs e)
        {
            if (nameInput.Text != "" && descriptionInput.Text != "" && ((ComboboxItem)cityInput.SelectedItem) != null)
            {
                using (DBHelper db = new DBHelper())
                {
                    if (!isEditing)
                    {
                        if (db.SimpleQuery("INSERT INTO Locations.Areas (name, description, cityId) " +
                            " VALUES ('" + nameInput.Text + "', '" + descriptionInput.Text + "', '" + ((ComboboxItem)cityInput.SelectedItem).Value + "')") >= 1)
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
                        if (db.SimpleQuery("UPDATE Locations.Areas SET " +
                            "name = '" + nameInput.Text + "', description='" + descriptionInput.Text + "', cityId='" + ((ComboboxItem)cityInput.SelectedItem).Value + "'") >= 1)
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
