using System;
using System.Data;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class Cities : Form
    {
        public Cities()
        {
            InitializeComponent();

            using (DBHelper db = new DBHelper())
            {
                DataTable dt = db.QueryDataTable("SELECT * FROM Locations.Countries");
                foreach (DataRow item in dt.Rows)
                {
                    countryInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }
        }

        private void buyerLoginBtn_Click(object sender, EventArgs e)
        {
            MiscHelpers.ShowForm(this, new EditCities(), false);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT c.id, c.name, c.lat, c.long, o.name as Country, c.createdAt from Locations.Cities c " +
                " JOIN Locations.Countries o ON o.id = c.countryId " +
                " WHERE 1=1 "; //1=1 for easy concatenation of AND/OR

            if (cityNameInput.Text != "")
            {
                query += " AND c.name LIKE '%" + cityNameInput.Text + "%' ";
            }
            if (countryInput.SelectedItem != null)
            {
                query += " AND c.countryId = " + ((ComboboxItem)countryInput.SelectedItem).Value + " ";
            }

            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt = dBHelper.QueryDataTable(query);
                guna2DataGridView1.DataSource = dt.DefaultView;
            }
        }



        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value;
            MiscHelpers.ShowForm(this, new EditCities(id), false);
        }

        private void guna2DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int? id = (int?)e.Row.Cells[0].Value;
            Console.WriteLine("UserDeletedRow: " + id + ", " + e.Row.Index);
            if (id != null)
            {
                using (DBHelper db = new DBHelper())
                {
                    if (db.SimpleQuery("DELETE FROM Locations.Cities WHERE id = " + id) >= 1)
                    {
                        MessageBox.Show("DELETED!");
                    }
                    else
                    {
                        MessageBox.Show("Some Error Occured while Deleting!");
                    }
                }
            }
        }
    }
}
