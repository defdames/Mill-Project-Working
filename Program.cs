using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Data.OleDb;
using System.Data.Common;
using System.Globalization;

namespace Mill_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static string  GetUser()
        {
            int found = 0;

            string uName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            found = uName.IndexOf("\\");

            return uName.Substring(found + 1);

            


        }

        public static string Get_gl_cmp()
        {
           
            

            var cmp = from c in ds.
                      where c.sa_user_key == GetUser()
                      select c.gl_cmp_key.ToList();
            return cmp.ToString();
            
        }
    }

}
