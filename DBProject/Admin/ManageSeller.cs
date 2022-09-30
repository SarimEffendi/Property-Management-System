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
    public partial class ManageSeller : Form
    {
        public ManageSeller()
        {
            InitializeComponent();
        }

        private void sellerSearchBtn_Click(object sender, EventArgs e)
        {
            //SEARCH BTN
            string query = "SELECT * from Persons.Seller WHERE 1=1 "; //1=1 for easy concatenation of AND/OR

            if (sellerNameInput.Text != "")
            {
                query += " AND first_name  LIKE '%" + sellerNameInput.Text + "%' or last_name  LIKE '%" + sellerNameInput.Text + "%' ";
            }

            if (sellerIdInput.Text != "")
            {
                query += " AND id = " + sellerIdInput.Text + " ";
            }

            if (sellerPhoneInput.Text != "")
            {
                query += " AND phone LIKE '%" + sellerPhoneInput.Text + "%' ";
            }
            if (sellerCompanyInput.Text != "")
            {
                query += " And company LIKE '%" + sellerCompanyInput + "%'";
            }

            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt = dBHelper.QueryDataTable(query);
                sellerGrid.DataSource = dt.DefaultView;
            }
        }

        private void sellerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)sellerGrid.Rows[e.RowIndex].Cells[0].Value;
            MiscHelpers.ShowForm(this, new EditSeller(id), false);
        }

        private void sellerGrid_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            int? id = (int?)e.Row.Cells[0].Value;
            Console.WriteLine("UserDeletedRow: " + id + ", " + e.Row.Index);
            if (id != null)
            {
                using (DBHelper db = new DBHelper())
                {
                    if (db.SimpleQuery("DELETE FROM Persons.Seller WHERE id = " + id) >= 1)
                    {
                        MessageBox.Show("DELETED!");
                    }
                    else
                    {
                        MessageBox.Show("Some Error Occured while Deleting!");
                    }
                }

            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private void sellerAddBtn_Click(object sender, EventArgs e)
        {
            //ADD BTN
            MiscHelpers.ShowForm(this, new EditSeller(), false);
        }
    }
}
