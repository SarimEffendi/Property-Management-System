using System;
using System.Data;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class ManageCustomer : Form
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void customerSearchBtn_Click(object sender, EventArgs e)
        {
            //SEARCH BTN
            string query = "SELECT * from Persons.Customer WHERE 1=1 "; //1=1 for easy concatenation of AND/OR

            if (customerNameInput.Text != "")
            {
                query += " AND (first_name LIKE '%" + customerNameInput.Text + "%' OR last_name  LIKE '%" + customerNameInput.Text + "%') ";
            }

            if (customerIdInput.Text != "")
            {
                query += " AND id = " + customerIdInput.Text + " ";
            }

            if (customerPhoneInput.Text != "")
            {
                query += " AND phone LIKE '%" + customerPhoneInput.Text + "%' ";
            }

            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt = dBHelper.QueryDataTable(query);
                customerGrid.DataSource = dt.DefaultView;
            }
        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            MiscHelpers.ShowForm(this, new EditCustomer(), false);
        }

        private void customerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)customerGrid.Rows[e.RowIndex].Cells[0].Value;
            MiscHelpers.ShowForm(this, new EditCustomer(id), false);
        }
        private void customerGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int? id = (int?)e.Row.Cells[0].Value;
            Console.WriteLine("UserDeletedRow: " + id + ", " + e.Row.Index);
            if (id != null)
            {
                using (DBHelper db = new DBHelper())
                {
                    if (db.SimpleQuery("DELETE FROM Persons.Customer WHERE id = " + id) >= 1)
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
