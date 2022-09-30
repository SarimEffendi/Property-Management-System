using System;
using System.Data;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class PropertyType : Form
    {
        public PropertyType()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from Property.Types WHERE 1=1 "; //1=1 for easy concatenation of AND/OR

            if (typeNameInput.Text != "")
            {
                query += " AND name LIKE '%" + typeNameInput.Text + "%' ";
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
            MiscHelpers.ShowForm(this, new EditPropertyType(id), false);
        }

        private void guna2DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int? id = (int?)e.Row.Cells[0].Value;
            Console.WriteLine("UserDeletingRow: " + id + ", " + e.Row.Index);
            if (id != null)
            {
                using (DBHelper db = new DBHelper())
                {
                    if (db.SimpleQuery("DELETE FROM Property.Types WHERE id = " + id) >= 1)
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
            MiscHelpers.ShowForm(this, new EditPropertyType(), false);
        }
    }
}
