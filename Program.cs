using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

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
                var cmp = (from  sau in context.sa_user_tbl
                           join cm in context.sa_uentp_tbl on sau.sa_user_key equals cm.sa_user_key
                          where sau.sa_osuser_key == uname && cm.sa_uentp_entyp =="B"
                              select cm.gl_cmp_key.ToString()).ToList();
                return cmp;
            }
        }

        public static List<string> Cmp_plant(string company) //get list of plants in the company the user selects
        {
           using (var context = new Model1())
            {
                 var plant = (from pl in context.sf_plant_tbl
                             where pl.gl_cmp_key == company
                             select pl.sf_plant_key.ToString()).ToList();
                return plant;
            }
        }

        public static List<string> Get_Mills(string company, string plant)//get list of mills in the compnay and plant user has access to
        {
            using (var context = new Model1())
            {
                var mills = (from ml in context.mill_Mills
                             where ml.gl_cmp_key == company && ml.sf_plant_key == plant && ml.Active == "Y"
                             select ml.Mill_ID.ToString()).ToList();
                return mills;
            }
        }

        public static List<string>Get_Systems(string company, string plant, string mill)//get list of systems in the company and plant the user has access to
        {
            using (var context = new Model1())
            {
                var systems = (from sys in context.mill_Systems
                               join sysc in context.mill_Sys_Mills_Combo on sys.System_Name equals sysc.System 
                               where sys.gl_cmp_key == company && sys.sf_plant_key == plant && sys.Active == "Y"  && sysc.Mill_ID == mill 
                               select sysc.System.ToString()).ToList();
                return systems;
            }
        }

        public static List<String>Get_Shift(string company, string plant)//get list of Shifts in the campnay plant user has access to
        {
            using (var context = new Model1())
            {
                var shifts = (from shift in context.mill_Shift_Patterns
                               where shift.gl_cmp_key == company && shift.sf_plant_key == plant
                               select shift.Shift_ID).ToList();
                return shifts;
            }
        }

        public static List<string>Get_Run(string company, string plant)//get list of stoppage reasons in the company and plant user has acces to
        {
            using (var context = new Model1())
            {
                var stoppage = (from stop in context.mill_Stoppage_Reasons
                                where stop.gl_cmp_key == company && stop.sf_plant_key == plant
                                select stop.Stop_Reason.ToString()).ToList();
                return stoppage;
            }

        }

        public static List<GetCat> Get_Category(string company, string plant)//get list of categories in the company and plant user has access to
        {
            using (var context = new Model1())
            {
                var c = from cat in context.mill_Shift_Categories
                        where cat.gl_cmp_key == company && cat.sf_plant_key == plant
                        select new GetCat {Cat =  cat.Category, Desc = cat.Category_Description };
                
                return c.ToList();
               
            }
            
        }

        private static Dictionary<Type, Action<Control>> controldefaults = new Dictionary<Type, Action<Control>>() //Method to clear all controls instead of typping each one out
        {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(CheckBox), c => ((CheckBox)c).Checked = false},
            {typeof(ListBox), c => ((ListBox)c).Items.Clear()},
            {typeof(RadioButton), c => ((RadioButton)c).Checked = false},
            {typeof(GroupBox), c => ((GroupBox)c).Controls.ClearControls()},
            {typeof(Panel), c => ((Panel)c).Controls.ClearControls()},
            {typeof(MaskedTextBox), c => ((MaskedTextBox)c).Clear()},
            //{typeof(ComboBox), c => ((ComboBox)c).Items.Clear()},
            {typeof(RichTextBox), c => ((RichTextBox)c).Clear()}
        };

        private static void FindAndInvoke(Type type, Control control)
        {
            if (controldefaults.ContainsKey(type))
            {
                controldefaults[type].Invoke(control);
            }
        }

        public static void ClearControls(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                FindAndInvoke(control.GetType(), control);
            }
        }

        public static void ClearControls<T>(this Control.ControlCollection controls) where T : class
        {
            if (!controldefaults.ContainsKey(typeof(T))) return;

            foreach (Control control in controls)
            {
                if (control.GetType().Equals(typeof(T)))
                {
                    FindAndInvoke(typeof(T), control);
                }
            }

        }

        public class GetCat
        {
            public string Cat { get; set; }
            public string Desc { get; set; }


        }

       

        

    
    }



}
