using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Mill_Project.Data;


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

        public static string  GetUser() //Get user name for user plugged in
        {
            int found = 0;

            string uName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            found = uName.IndexOf("\\");

            return uName.Substring(found + 1);

            


        }

        public static List<string> User_cmp() //Get list of companies for user logged in
        {
            string uname = "midasc";
            using (var context = new Model1())
            
            {
                var cmp = (from cm in context.web_sa_cmp_tbl
                          where cm.sa_user_key == uname
                              select cm.gl_cmp_key.ToString()).ToList();
                return cmp;
            }
        }

        public static List<string> Cmp_plant(string company)
        {

            
           using (var context = new Model1())
            {
                 var plant = (from pl in context.sf_plant_tbl
                             where pl.gl_cmp_key == company
                             select pl.sf_plant_key.ToString()).ToList();
                return plant;
            }
        }

    
    }



}
