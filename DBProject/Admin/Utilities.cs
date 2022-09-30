using System;
using System.Data;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class Utilities : Form
    {
        public Utilities()
        {
            InitializeComponent();
        }

        private void utilityAddBtn_Click(object sender, EventArgs e)
        {
            MiscHelpers.ShowForm(this, new EditUtilities(), false);
        }

        private void utilitySearchBtn_Click(object sender, EventArgs e)
        {
            string query = "SELECT a.* from Property.Utilities a " +
               " WHERE 1=1 "; //1=1 for easy concatenation of AND/OR

            if (utilityNameInput.Text != "")
            {
                query += " AND a.name LIKE '%" + utilityNameInput.Text + "%' ";
            }

            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt = dBHelper.QueryDataTable(query);
                utilityGridView.DataSource = dt.DefaultView;
            }
        }

        private void utilityGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)utilityGridView.Rows[e.RowIndex].Cells[0].Value;
            MiscHelpers.ShowForm(this, new EditUtilities(id), false);
        }

        private void utilityGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int? id = (int?)e.Row.Cells[0].Value;
            Console.WriteLine("UserDeletedRow: " + id + ", " + e.Row.Index);
            if (id != null)
            {
                using (DBHelper db = new DBHelper())
                {
                    if (db.SimpleQuery("DELETE FROM Property.Utilities WHERE id = " + id) >= 1)
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
