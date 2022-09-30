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
    public partial class EditPropertySubType : Form
    {
        private bool isEditing = false;
        private int editId;

        public EditPropertySubType()
        {
            InitializeComponent();
            this.isEditing = false;
            checkEditing();
        }

        public EditPropertySubType(int editId)
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
                DataTable dt = db.QueryDataTable("SELECT * FROM Property.Types");
                foreach (DataRow item in dt.Rows)
                {
                    typeInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }
            if (!isEditing)
            {
                idInput.Hide();
            }
            else
            {
                // is Editing Then
                idInput.Text = editId.ToString();
                using (DBHelper db = new DBHelper())
                {
                    DataRow dr = db.QueryDataRow("SELECT * FROM Property.SubTypes WHERE id = " + editId.ToString());
                    nameInput.Text = dr["name"].ToString();
                    descriptionInput.Text = dr["description"].ToString();

                    foreach (ComboboxItem item in typeInput.Items)
                    {
                        if (item.Value == dr["typeId"].ToString())
                        {
                            typeInput.SelectedItem = item;
                        }
                    }
                }
            }
        }
        private void addUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameInput.Text != "" && descriptionInput.Text != "" && ((ComboboxItem)typeInput.SelectedItem) != null)
                {
                    using (DBHelper db = new DBHelper())
                    {
                        if (!isEditing)
                        {
                            if (db.SimpleQuery("INSERT INTO Property.SubTypes (name, description, typeId) " +
                                              "VALUES ('" + nameInput.Text + "', '" + descriptionInput.Text + "', '" + ((ComboboxItem)typeInput.SelectedItem).Value + "')") >= 1)
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
                            if (db.SimpleQuery("UPDATE Property.SubTypes SET name = '" + nameInput.Text + "', description = '" + descriptionInput.Text + "', typeId='" + ((ComboboxItem)typeInput.SelectedItem).Value + "' WHERE id = " + editId) >= 1)
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
