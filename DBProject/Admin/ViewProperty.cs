using System.Data;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class ViewProperty : Form
    {
        public ViewProperty()
        {
            InitializeComponent();


        }

        //Search Button
        private void guna2GradientButton1_Click(object sender, System.EventArgs e)
        {
            string query = "SELECT * from Property.Properties WHERE 1=1"; //1=1 for easy concatenation of logical statements

            if (propertyNameInput.Text != "")
            {
                query += " AND name LIKE '%"+propertyNameInput.Text+ "%' ";
            }
            if (minPriceInput.Text != "")
            {
                query += " AND price >= " + minPriceInput.Text + " ";
            }
            if (maxPriceInput.Text != "")
            {
                query += " AND price <= " + maxPriceInput.Text + " ";
            }
            if (areaCInput.SelectedValue != null)
            {
                query += " AND areaId = " + areaCInput.SelectedValue + " ";
            }
            if (propertyTypeInput.SelectedValue != null)
            {
                query += " AND subTypeId = " + propertyTypeInput.SelectedValue + " ";
            }

            //TODO: Still needs testing after adding some properties
            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt = dBHelper.QueryDataTable(query);

                //for (int i = 0; i < dt.Columns.Count; i++)
                //{
                //    var temp = new DataGridViewColumn();
                //    temp.HeaderText =  dt.Columns[i].ColumnName;
                //    guna2DataGridView1.Columns.Add(temp);
                //    //guna2DataGridView1.Columns[i].DataPropertyName = dt.Columns[i].ColumnName;
                //}

                guna2DataGridView1.DataSource = dt.DefaultView;
            }

        }
    }
}
