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
    public partial class ManageAdmin : Form
    {
        public ManageAdmin()
        {
            InitializeComponent();
        }

        private void buyerLoginBtn_Click(object sender, EventArgs e)
        {
            //ADD BTN
            MiscHelpers.ShowForm(this, new EditAdmin(), false);
        }
        

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            //SEARCH BTN
            string query = "SELECT * from Persons.Admin WHERE 1=1 "; //1=1 for easy concatenation of AND/OR

            if (adminNameInput.Text != "")
            {
                query += " AND name LIKE '%" + adminNameInput.Text + "%' ";
            }

            if (adminIdInput.Text != "")
            {
                query += " AND id = " + adminIdInput.Text + " ";
            }

            if (adminPhoneInput.Text != "")
            {
                query += " AND phone LIKE '%" + adminPhoneInput.Text + "%' ";
            }

            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt = dBHelper.QueryDataTable(query);
                adminGrid.DataSource = dt.DefaultView;
            }
        }

        private void adminGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)adminGrid.Rows[e.RowIndex].Cells[0].Value;
            MiscHelpers.ShowForm(this, new EditAdmin(id), false);
        }

        private void adminGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int? id = (int?)e.Row.Cells[0].Value;
            Console.WriteLine("UserDeletedRow: " + id + ", " + e.Row.Index);
            if (id != null)
            {
                using (DBHelper db = new DBHelper())
                {
                    if (db.SimpleQuery("DELETE FROM Persons.Admin WHERE id = " + id) >= 1)
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
