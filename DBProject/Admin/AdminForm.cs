using System;
using System.Windows.Forms;

namespace DBProject.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelMediaSubMenu.Visible = false;
            panelPlaylistSubMenu.Visible = false;
            locationsSubMenu.Visible = false;
        }

        private void toggleSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            //openChildForm(new EditProperty());
            toggleSubMenu(panelMediaSubMenu);
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Property());
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            toggleSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageSeller());
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageCustomer());
            hideSubMenu();
        }

        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            //   showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnUtility_Click(object sender, EventArgs e)
        {
            openChildForm(new Utilities());
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            toggleSubMenu(locationsSubMenu);
        }

        private void countriesBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Countries());
        }

        private void citiesBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Cities());
        }

        private void AreasBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Areas());
        }

        private void propertyTypesBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PropertyType());
        }

        private void propertySubTypesBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PropertySubType());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageAdmin());
            hideSubMenu();
        }

        private void propertyStatisticsBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new PropertyStatistics());
            hideSubMenu();
        }
    }
}
