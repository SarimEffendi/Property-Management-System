using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
            using (DBHelper db = new DBHelper())
            {
                DataTable dt = db.QueryDataTable("SELECT * FROM Locations.Cities");
                foreach (DataRow item in dt.Rows)
                {
                    cityInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }
        }

        private void AddBtn_click(object sender, EventArgs e)
        {
            MiscHelpers.ShowForm(this, new EditAreas(), false);
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT a.id, a.name, a.description, c.name as City, a.createdAt from Locations.Areas a " +
               " JOIN Locations.Cities c ON c.id = a.cityId " +
               " WHERE 1=1 "; //1=1 for easy concatenation of AND/OR

            if (areaNameInput.Text != "")
            {
                query += " AND a.name LIKE '%" + areaNameInput.Text + "%' ";
            }
            if (cityInput.SelectedItem != null)
            {
                query += " AND a.cityId = " + ((ComboboxItem)cityInput.SelectedItem).Value + " ";
            }

            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt = dBHelper.QueryDataTable(query);
                guna2DataGridView1.DataSource = dt.DefaultView;
            }
        }


        private void guna2DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int? id = (int?)e.Row.Cells[0].Value;
            Console.WriteLine("UserDeletedRow: " + id + ", " + e.Row.Index);
            if (id != null)
            {
                using (DBHelper db = new DBHelper())
                {
                    if (db.SimpleQuery("DELETE FROM Locations.Areas WHERE id = " + id) >= 1)
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

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value;
            MiscHelpers.ShowForm(this, new EditAreas(id), false);
        }
    }
}
