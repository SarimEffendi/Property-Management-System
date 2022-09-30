using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (fnameinput.Text != "" && lnameiNput.Text != "" && usernameInput.Text != "" && phoneInput.Text != "" && passwordInput.Text != "")
            {
                using (DBHelper db = new DBHelper())
                {
                    if (db.SimpleQuery("INSERT INTO Persons.Customer(first_name, last_name, login, password, phone) " +
                        " VALUES ('" + fnameinput.Text + "', '" + lnameiNput.Text + "', '" + usernameInput.Text + "', '" + MiscHelpers.CreateMD5(passwordInput.Text) + "', '" + phoneInput.Text + "')") >= 1)
                    {
                        MessageBox.Show("Created!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Some Error Occured while Creating!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please input correct values!");
            }
        }
    }
}
