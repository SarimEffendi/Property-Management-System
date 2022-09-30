using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            using (DBHelper dBHelper = new DBHelper())
            {
                string username = AUsernameTxt.Text;
                string password = MiscHelpers.CreateMD5(APasswordTxt.Text);
                Console.WriteLine("Hashed Pass: " + password);

                bool userExists = dBHelper.DataExists("Select * FROM Persons.Admin WHERE login = '" + username + "' AND password='" + password + "'");
                Console.WriteLine("UserFound: " + userExists);
                if (userExists)
                {
                    AUsernameTxt.Text = "";
                    APasswordTxt.Text = "";
                    MiscHelpers.ShowForm(this, new Admin.AdminForm(), false);
                }
                else
                {
                    MessageBox.Show("Incorrect Admin Username or Password!");
                    Console.WriteLine("User Not Found!! ");
                }
            }
        }

        private void buyerLoginBtn_Click(object sender, EventArgs e)
        {
            using (DBHelper dBHelper = new DBHelper())
            {
                string username = BUsernameTxt.Text;
                string password = MiscHelpers.CreateMD5(BPasswordTxt.Text);
                Console.WriteLine("Hashed Pass: " + password);

                bool userExists = dBHelper.DataExists("Select * FROM Persons.Customer WHERE login = '" + username + "' AND password='" + password + "'");
                Console.WriteLine("UserFound: " + userExists);
                if (userExists)
                {
                    BUsernameTxt.Text = "";
                    BPasswordTxt.Text = "";
                    MiscHelpers.ShowForm(this, new Buyer.BuyerForm(), false);
                }
                else
                {
                    MessageBox.Show("Incorrect Customer Username or Password!");
                    Console.WriteLine("User Not Found!! ");
                }
            }
        }

        private void customerRegisterBtn_Click(object sender, EventArgs e)
        {
            MiscHelpers.ShowForm(this, new SignUp());
        }
    }
}
