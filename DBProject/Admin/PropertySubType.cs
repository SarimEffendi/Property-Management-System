using System;
using System.Data;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class PropertySubType : Form
    {
        public PropertySubType()
        {
            InitializeComponent();
            using (DBHelper db = new DBHelper())
            {
                DataTable dt = db.QueryDataTable("SELECT * FROM Property.Types");
                foreach (DataRow item in dt.Rows)
                {
                    typeInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT st.id, st.name, st.description, t.name as Type, st.createdAt from Property.SubTypes st" +
                " JOIN Property.Types t ON st.typeId = t.id" +
                " WHERE 1=1 "; //1=1 for easy concatenation of AND/OR

            if (nameInput.Text != "")
            {
                query += " AND st.name LIKE '%" + nameInput.Text + "%' ";
            }
            if (typeInput.SelectedItem != null)
            {
                query += " AND st.typeId = " + ((ComboboxItem)typeInput.SelectedItem).Value + " ";
            }

            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt = dBHelper.QueryDataTable(query);
                guna2DataGridView1.DataSource = dt.DefaultView;
            }
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO: handle RowIndex -1 in all places like this one!
            int id = (int)guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value;
            MiscHelpers.ShowForm(this, new EditPropertySubType(id), false);
        }

        private void guna2DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int? id = (int?)e.Row.Cells[0].Value;
            Console.WriteLine("UserDeletingRow: " + id + ", " + e.Row.Index);
            if (id != null)
            {
                using (DBHelper db = new DBHelper())
                {
                    if (db.SimpleQuery("DELETE FROM Property.SubTypes WHERE id = " + id) >= 1)
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            MiscHelpers.ShowForm(this, new EditPropertySubType(), false);
        }
    }
}
