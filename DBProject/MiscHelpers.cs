using System;
using System.Text;
using System.Windows.Forms;

namespace DBProject
{
    class MiscHelpers
    {
        public static string escapeSQL (string input)
        {
            return input.Replace('\'', ' ').Replace('"',' ').Replace("--", " ");
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToBase64String(hashBytes);
            }
        }


        public static void ShowForm(Form that, Form form)
        {
            form.FormClosing += delegate { that.Show(); };
            form.Show();
            that.Hide();
        }
        public static void ShowForm(Form that, Form form, bool hide)
        {
            if (hide)
            {
                form.FormClosing += delegate { that.Show(); };
                that.Hide();
            }
            form.Show();
        }
    }
}
