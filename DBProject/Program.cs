using System;
using System.Windows.Forms;

namespace DBProject
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Admin.AdminForm());
            Application.Run(new Login());
        }
    }
}
