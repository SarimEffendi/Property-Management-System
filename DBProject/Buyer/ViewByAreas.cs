using System;
using System.Data;
using System.Windows.Forms;

namespace DBProject.Buyer
{
    public partial class ViewByAreas : Form
    {
        public ViewByAreas()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (latInput.Text != "" && longInput.Text != "" && distanceInput.Text != "")
            {
                string query =   "DECLARE @latitude FLOAT, @longitude FLOAT, @distance FLOAT " +
                                 "SELECT @latitude = "+latInput.Text+ ", @longitude = " + longInput.Text + ", @distance = "+distanceInput.Text+"; " +
                                 "with PropertiesWithDistance as " +
                                 "(select " +
                                 "    [id], [name], [description],   " +
                                 "    ( 3959 * acos( cos( radians(@latitude) ) * cos( radians( [lat] ) ) * cos( radians( [long] ) " +
                                 "   - radians(@longitude) ) + sin( radians(@latitude) ) * sin( radians( [lat] ) ) ) )  As Distance " +
                                 "    FROM Property.Properties) " +
                                 "Select [id], [name], [description], Distance " +
                                 "From PropertiesWithDistance " +
                                 "Where Distance <= @distance ";
                //TODO: Still needs testing after adding some properties
                using (DBHelper dBHelper = new DBHelper())
                {
                    DataTable dt = dBHelper.QueryDataTable(query);
                    guna2DataGridView1.DataSource = dt.DefaultView;
                }
            }
            else
            {
                MessageBox.Show("Error! Please fill all boxes");
            }
        }
    }
}
