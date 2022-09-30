using System.Data;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class PropertyStatistics : Form
    {
        public PropertyStatistics()
        {
            InitializeComponent();

            using (DBHelper dBHelper = new DBHelper())
            {
                DataTable dt1 = dBHelper.QueryDataTable(
                    " SELECT TOP 10 p.sellerId, CONCAT(s.first_name, s.last_name) as 'Top Seller Name', COUNT(*) as 'Property Count'" +
                    " FROM Property.Properties p" +
                    " JOIN Persons.Seller s ON p.sellerId = s.id" +
                    " GROUP BY p.sellerId, CONCAT(s.first_name, s.last_name)" +
                    " ORDER BY COUNT(*);");

                guna2DataGridView1.DataSource = dt1.DefaultView;

                DataTable dt2 = dBHelper.QueryDataTable(
                    " SELECT TOP 1 datename(month, createdAt) as 'Month', COUNT(*) as 'User Registrations'" +
                    " FROM Persons.Customer" +
                    " GROUP BY datename(month, createdAt)" +
                    " ORDER BY COUNT(*)");
                guna2DataGridView2.DataSource = dt2.DefaultView;

                DataTable dt3 = dBHelper.QueryDataTable(
                    " SELECT datename(month, createdAt) as 'Month', COUNT(*) as 'Users Registered Per Month'" +
                    " FROM Property.Properties" +
                    " WHERE YEAR(createdAt) = YEAR(getDate())" +
                    " GROUP BY datename(month, createdAt);");
                guna2DataGridView3.DataSource = dt3.DefaultView;


                DataTable dt4 = dBHelper.QueryDataTable(
                    " SELECT datename(month, createdAt) as 'Month', COUNT(*) as 'Properties Created Per Month'" +
                    " FROM Persons.Customer" +
                    " WHERE YEAR(createdAt) = YEAR(getDate())" +
                    " GROUP BY datename(month, createdAt);");
                guna2DataGridView4.DataSource = dt4.DefaultView;
            }
        }
    }
}
