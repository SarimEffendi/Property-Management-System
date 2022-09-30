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
    public partial class EditProperty : Form
    {
        private bool isEditing = false;
        private int editId;

        public EditProperty()
        {
            InitializeComponent();
            this.isEditing = false;
            checkEditing();
        }

        public EditProperty(int editId)
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
                DataTable dt = db.QueryDataTable("SELECT * FROM Property.Utilities");
                var cbitems = new List<ComboboxItem>();
                foreach (DataRow item in dt.Rows)
                {
                    cbitems.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
                utilityCombo.DisplayMember = "Text";
                utilityCombo.ValueMember = "Value";
                utilityCombo.DataSource = cbitems;

                DataTable dt2 = db.QueryDataTable("SELECT st.id, CONCAT(st.name,' (',t.name,')') as name FROM Property.SubTypes st JOIN Property.Types t ON st.typeId = t.id");
                foreach (DataRow item in dt2.Rows)
                {
                    subTypeInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
                DataTable dt3 = db.QueryDataTable("SELECT * FROM Locations.Countries");
                foreach (DataRow item in dt3.Rows)
                {
                    countryInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
                DataTable dt5 = db.QueryDataTable("SELECT * FROM Locations.Areas");
                foreach (DataRow item in dt5.Rows)
                {
                    areaInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
                areaInput.Enabled = false;
                DataTable dt4 = db.QueryDataTable("SELECT * FROM Persons.Seller");
                foreach (DataRow item in dt4.Rows)
                {
                    sellerInput.Items.Add(new ComboboxItem(item["first_name"].ToString() + " " + item["last_name"].ToString(), item["id"].ToString()));
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
                    DataRow dr = db.QueryDataRow("SELECT * FROM Property.Properties WHERE id = " + editId.ToString());
                    //(name, description, video, lat, long, price, sizeSqFt, sellerId, subTypeId, areaId)
                    nameInput.Text = dr["name"].ToString();
                    descriptionInput.Text = dr["description"].ToString();
                    videoUrlInput.Text = dr["video"].ToString();
                    latInput.Text = dr["lat"].ToString();
                    longInput.Text = dr["long"].ToString();
                    priceInput.Text = dr["price"].ToString();
                    areaSqftInput.Text = dr["sizeSqFt"].ToString();

                    foreach (ComboboxItem item in sellerInput.Items)
                    {
                        if (item.Value == dr["sellerId"].ToString())
                        {
                            sellerInput.SelectedItem = item;
                        }
                    }
                    foreach (ComboboxItem item in subTypeInput.Items)
                    {
                        if (item.Value == dr["subTypeId"].ToString())
                        {
                            subTypeInput.SelectedItem = item;
                        }
                    }
                    foreach (ComboboxItem item in areaInput.Items)
                    {
                        if (item.Value == dr["areaId"].ToString())
                        {
                            areaInput.SelectedItem = item;
                            areaInput.SelectedText = item.Text;
                            areaInput.SelectedValue = item.Value;
                        }
                    }

                    //Load Utilities Property.PropertyUtilities (propertyId, utilityId, value)
                    DataTable Udt = db.QueryDataTable("SELECT * FROM Property.PropertyUtilities WHERE propertyId = " + editId.ToString());

                    foreach (DataRow item in Udt.Rows)
                    {
                        utilitiesDataGrid.Rows.Add(item["utilityId"].ToString(), item["value"].ToString());
                    }

                    //Load Images Property.PropertyImages (propertyId, image, caption, order)
                    DataTable Idt = db.QueryDataTable("SELECT * FROM Property.PropertyImages WHERE propertyId = " + editId.ToString());
                    foreach (DataRow item in Idt.Rows)
                    {
                        imagesDataGrid.Rows.Add(item["image"].ToString(), item["caption"].ToString(), item["order"].ToString());
                    }


                }
            }
        }
        private bool validateUtils()
        {
            string addedUIds = "";
            foreach (DataGridViewRow r in utilitiesDataGrid.Rows)
            {
                if (r.Cells[0].Value != null && r.Cells[1].Value != null)
                {
                    if (addedUIds.Contains(r.Cells[0].Value + "|"))
                    {
                        MessageBox.Show("Utilities should not repeat!");
                        return false;
                    }
                    Console.WriteLine("Utility : " + r.Cells[0].Value + " , " + r.Cells[1].Value);
                    addedUIds = addedUIds + r.Cells[0].Value + "|";
                }
            }
            return true;
        }
        private bool validateImages()
        {
            string addedIOrders = "";
            foreach (DataGridViewRow r in imagesDataGrid.Rows)
            {
                if (r.Cells[0].Value != null && r.Cells[1].Value != null && r.Cells[2].Value != null)
                {
                    if (addedIOrders.Contains(r.Cells[2].Value + "|"))
                    {
                        MessageBox.Show("Images Orders should not repeat!");
                        return false;
                    }
                    Console.WriteLine("Images : " + r.Cells[0].Value + " , " + r.Cells[1].Value + " , " + r.Cells[2].Value);
                    addedIOrders = addedIOrders + r.Cells[2].Value + "|";
                }
            }
            return true;
        }


        private void addUpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateUtils() && validateImages())
                {
                    if (nameInput.Text != "" && descriptionInput.Text != "" && priceInput.Value != 0 && areaSqftInput.Value != 0 && ((ComboboxItem)sellerInput.SelectedItem) != null && ((ComboboxItem)areaInput.SelectedItem) != null && ((ComboboxItem)subTypeInput.SelectedItem) != null)
                    {
                        using (DBHelper db = new DBHelper())
                        {
                            if (!isEditing)
                            {
                                int? insertId = db.InsertQueryWID("INSERT INTO Property.Properties (name, description, video, lat, long, price, sizeSqFt, sellerId, subTypeId, areaId) " +
                                    "VALUES ('" + MiscHelpers.escapeSQL(nameInput.Text) + "', '" + MiscHelpers.escapeSQL(descriptionInput.Text) + "', '" + MiscHelpers.escapeSQL(videoUrlInput.Text) + "', '" + MiscHelpers.escapeSQL(latInput.Text) + "', '" + MiscHelpers.escapeSQL(longInput.Text) + "', '" + priceInput.Value + "', '" + areaSqftInput.Value + "', '" + ((ComboboxItem)sellerInput.SelectedItem).Value + "', '" + ((ComboboxItem)subTypeInput.SelectedItem).Value + "', '" + ((ComboboxItem)areaInput.SelectedItem).Value + "')");
                                if (insertId != null)
                                {
                                    MessageBox.Show("Property Created!");
                                    Console.WriteLine("Property Id: " + insertId);

                                    //! Insert Property UtilityFeatures
                                    foreach (DataGridViewRow r in utilitiesDataGrid.Rows)
                                    {
                                        if (r.Cells[0].Value != null && r.Cells[1].Value != null)
                                        {
                                            string uid = r.Cells[0].Value.ToString();
                                            string uValue = r.Cells[1].Value.ToString();

                                            if (db.SimpleQuery("INSERT INTO Property.PropertyUtilities (propertyId, utilityId, value) " +
                                                                "VALUES (" + insertId + ", '" + uid + "', '" + uValue + "')") >= 1)
                                            {
                                                Console.WriteLine("Inserted Utility : " + uid + " , " + uValue);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Failed Insert Utility : " + uid + " , " + uValue);
                                            }
                                        }
                                    }

                                    //! Insert Property Images
                                    foreach (DataGridViewRow r in imagesDataGrid.Rows)
                                    {
                                        if (r.Cells[0].Value != null && r.Cells[1].Value != null)
                                        {
                                            string image = r.Cells[0].Value.ToString();
                                            string caption = r.Cells[1].Value.ToString();
                                            string order = r.Cells[2].Value.ToString();

                                            if (db.SimpleQuery("INSERT INTO Property.PropertyImages (propertyId, image, caption, [order]) " +
                                                                "VALUES (" + insertId + ", '" + image + "', '" + caption + "', " + order + ")") >= 1)
                                            {
                                                Console.WriteLine("Inserted Image : " + image + " , " + caption);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Failed Insert Image : " + image + " , " + caption);
                                            }
                                        }
                                    }

                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Some Error Occured while Creating!");
                                }
                            }
                            else
                            {
                                if (db.SimpleQuery("UPDATE Property.Properties SET name = '" + MiscHelpers.escapeSQL(nameInput.Text) +
                                    "', description = '" + MiscHelpers.escapeSQL(descriptionInput.Text) +
                                    "', video = '" + MiscHelpers.escapeSQL(videoUrlInput.Text) +
                                    "', lat = '" + MiscHelpers.escapeSQL(latInput.Text) +
                                    "', long = '" + MiscHelpers.escapeSQL(longInput.Text) +
                                    "', price = '" + MiscHelpers.escapeSQL(priceInput.Text) +
                                    "', sizeSqFt = '" + MiscHelpers.escapeSQL(areaSqftInput.Text) +
                                    "', sellerId='" + ((ComboboxItem)sellerInput.SelectedItem).Value +
                                    "', subTypeId='" + ((ComboboxItem)subTypeInput.SelectedItem).Value +
                                    "', areaId='" + ((ComboboxItem)areaInput.SelectedItem).Value + "' WHERE id = " + editId) >= 1)
                                {
                                    MessageBox.Show("UPDATED!");

                                    // DELETE TO REINSERT
                                    db.SimpleQuery("DELETE FROM Property.PropertyUtilities WHERE propertyId =" + editId);

                                    // DELETE TO REINSERT
                                    db.SimpleQuery("DELETE FROM Property.PropertyImages WHERE propertyId =" + editId);

                                    //! Insert Property UtilityFeatures
                                    foreach (DataGridViewRow r in utilitiesDataGrid.Rows)
                                    {
                                        if (r.Cells[0].Value != null && r.Cells[1].Value != null)
                                        {
                                            string uid = r.Cells[0].Value.ToString();
                                            string uValue = r.Cells[1].Value.ToString();

                                            if (db.SimpleQuery("INSERT INTO Property.PropertyUtilities (propertyId, utilityId, value) " +
                                                                "VALUES (" + editId + ", '" + uid + "', '" + uValue + "')") >= 1)
                                            {
                                                Console.WriteLine("Inserted Utility : " + uid + " , " + uValue);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Failed Insert Utility : " + uid + " , " + uValue);
                                            }
                                        }
                                    }

                                    //! Insert Property Images
                                    foreach (DataGridViewRow r in imagesDataGrid.Rows)
                                    {
                                        if (r.Cells[0].Value != null && r.Cells[1].Value != null)
                                        {
                                            string image = r.Cells[0].Value.ToString();
                                            string caption = r.Cells[1].Value.ToString();
                                            string order = r.Cells[2].Value.ToString();

                                            if (db.SimpleQuery("INSERT INTO Property.PropertyImages (propertyId, image, caption, [order]) " +
                                                                "VALUES (" + editId + ", '" + image + "', '" + caption + "', " + order + ")") >= 1)
                                            {
                                                Console.WriteLine("Inserted Image : " + image + " , " + caption);
                                            }
                                            else
                                            {
                                                Console.WriteLine("Failed Insert Image : " + image + " , " + caption);
                                            }
                                        }
                                    }
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some Error Occured! "+ex.Message);
            }
        }

        private void countryInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            cityInput.Items.Clear();
            areaInput.Items.Clear();
            using (DBHelper db = new DBHelper())
            {
                DataTable dt = db.QueryDataTable("SELECT * FROM Locations.Cities WHERE countryId = " + ((ComboboxItem)countryInput.SelectedItem).Value);
                foreach (DataRow item in dt.Rows)
                {
                    cityInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }
        }

        private void cityInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            areaInput.Items.Clear();
            using (DBHelper db = new DBHelper())
            {
                DataTable dt = db.QueryDataTable("SELECT * FROM Locations.Areas WHERE cityId = " + ((ComboboxItem)cityInput.SelectedItem).Value);
                foreach (DataRow item in dt.Rows)
                {
                    areaInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }
            areaInput.Enabled = true;
        }
    }
}
