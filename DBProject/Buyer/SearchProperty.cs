using System;
using System.Data;
using System.Windows.Forms;

namespace DBProject.Buyer
{
    public partial class SearchProperty : Form
    {
        public SearchProperty()
        {
            InitializeComponent();
            using (DBHelper db = new DBHelper())
            {
                DataTable dt = db.QueryDataTable("SELECT * FROM Locations.Countries");
                foreach (DataRow item in dt.Rows)
                {
                    countryCInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
                DataTable dt2 = db.QueryDataTable("SELECT st.id, CONCAT(st.name,' (',t.name,')') as name FROM Property.SubTypes st JOIN Property.Types t ON st.typeId = t.id");
                foreach (DataRow item in dt2.Rows)
                {
                    propertySubTypeInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
                DataTable dt3 = db.QueryDataTable("SELECT * FROM property.utilities");
                foreach (DataRow item in dt3.Rows)
                {
                    utilNameInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string query = "SELECT p.id, p.name, p.price, p.lat, p.long, p.description, p.sizeSqFt, CONCAT(lc.name,', ',la.name) as Location, ps.first_name as Seller, STRING_AGG(CONCAT(pu.[value], ' ', u.name), ',') as Features, p.createdAt from Property.Properties p" +
                " JOIN Locations.Areas la ON la.id = p.areaId " +
                " JOIN Locations.Cities lc ON la.cityId = lc.id " +
                " JOIN Persons.Seller ps ON ps.id = p.sellerId " +
                " LEFT JOIN Property.PropertyUtilities pu ON pu.propertyId = p.id " +
                " LEFT JOIN Property.Utilities u ON pu.utilityId = u.id" +
                " WHERE 1=1 "; //1=1 for easy concatenation of AND/OR

            if (propertyNameInput.Text != "")
            {
                query += " AND p.name LIKE '%" + propertyNameInput.Text + "%' ";
            }
            if (minPriceInput.Text != "")
            {
                query += " AND p.price >= " + minPriceInput.Text + " ";
            }
            if (maxPriceInput.Text != "")
            {
                query += " AND p.price <= " + maxPriceInput.Text + " ";
            }
            if (utilNameInput.SelectedItem != null && utilValueInput.Text != "")
            {
                query += " AND pu.utilityId = " + ((ComboboxItem)utilNameInput.SelectedItem).Value + " AND pu.value = '" + utilValueInput.Text + "' ";
            }
            //Location Filter
            if (areaCInput.SelectedItem != null)
            {
                query += " AND p.areaId = " + ((ComboboxItem)areaCInput.SelectedItem).Value + " ";
            }
            else if (cityCInput.SelectedItem != null)
            {
                query += " AND p.areaId IN (SELECT id FROM Locations.Areas Where cityid = " + ((ComboboxItem)cityCInput.SelectedItem).Value + ") ";
            }
            else if (countryCInput.SelectedItem != null)
            {
                query += " AND p.areaId IN (SELECT id FROM Locations.Areas Where cityid IN ( SELECT id FROM Locations.Cities WHERE countryId = " + ((ComboboxItem)countryCInput.SelectedItem).Value + ")) ";
            }

            if (propertySubTypeInput.SelectedItem != null)
            {
                query += " AND p.subTypeId = " + ((ComboboxItem)propertySubTypeInput.SelectedItem).Value + " ";
            }

            query += " GROUP BY p.id, p.name, p.price, p.lat, p.long, p.description, p.sizeSqFt, CONCAT(lc.name,', ',la.name) , ps.first_name , p.createdAt";

            //TODO: Still needs testing after adding some properties
            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt = dBHelper.QueryDataTable(query);
                guna2DataGridView1.DataSource = dt.DefaultView;
            }

        }
        private void countryCInput_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cityCInput.Items.Clear();
            areaCInput.Items.Clear();
            using (DBHelper db = new DBHelper())
            {
                DataTable dt = db.QueryDataTable("SELECT * FROM Locations.Cities WHERE countryId = " + ((ComboboxItem)countryCInput.SelectedItem).Value);
                foreach (DataRow item in dt.Rows)
                {
                    cityCInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }
        }

        private void cityCInput_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            areaCInput.Items.Clear();
            using (DBHelper db = new DBHelper())
            {
                DataTable dt = db.QueryDataTable("SELECT * FROM Locations.Areas WHERE cityId = " + ((ComboboxItem)cityCInput.SelectedItem).Value);
                foreach (DataRow item in dt.Rows)
                {
                    areaCInput.Items.Add(new ComboboxItem(item["name"].ToString(), item["id"].ToString()));
                }
            }
        }
    }
}
