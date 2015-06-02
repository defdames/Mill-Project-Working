using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;


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
            DataSet ds = new DataSet();
            string user = GetUser();
            //DataTable comp = ds.Tables["web_sa_cmp_tbl"];

            var cmp = from c in adage_45DataSet.web_sa_cmp_tblDataTable
                      where c.sa_user_key == GetUser()
                      select c.gl_cmp_key.ToList();
            return cmp.ToString();
            
        }
    }
}
