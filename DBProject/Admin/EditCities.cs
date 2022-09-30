using System;
using System.Data;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class EditCities : Form
    {
        private bool isEditing = false;
        private int editId;

        public EditCities()
        {
            InitializeComponent();
            this.isEditing = false;
            checkEditing();
        }

        public EditCities(int editId)
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
                DataTable dt = db.QueryDataTable("SELECT * FROM Locations.Countries");
                foreach (DataRow item in dt.Rows)
                {
                    countryInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
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
                    DataRow dr = db.QueryDataRow("SELECT * FROM Locations.Cities WHERE id = " + editId.ToString());
                    nameInput.Text = dr["name"].ToString();
                    latInput.Text = dr["lat"].ToString();
                    longInput.Text = dr["long"].ToString();

                    foreach (ComboboxItem item in countryInput.Items)
                    {
                        if (item.Value == dr["countryId"].ToString())
                        {
                            countryInput.SelectedItem = item;
                        }
                    }
                }
            }
        }

        private void addUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameInput.Text != "" && latInput.Text != "" && longInput.Text != "" && ((ComboboxItem)countryInput.SelectedItem) != null)
                {
                    using (DBHelper db = new DBHelper())
                    {
                        if (!isEditing)
                        {
                            if (db.SimpleQuery("INSERT INTO Locations.Cities (name, lat, long, countryId) " +
                                " VALUES ('" + nameInput.Text + "', '" + latInput.Text + "', '" + longInput.Text + "', '" + ((ComboboxItem)countryInput.SelectedItem).Value + "')") >= 1)
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
                            if (db.SimpleQuery("UPDATE Locations.Cities SET " +
                                "name = '" + nameInput.Text + "', lat='" + latInput.Text + "', long='" + longInput.Text + "', countryId='" + ((ComboboxItem)countryInput.SelectedItem).Value + "' WHERE id = " + editId) >= 1)
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
            catch (Exception)
            {

                MessageBox.Show("Some Error Occured!");
            }
        }
    }
}
