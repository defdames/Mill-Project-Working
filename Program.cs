﻿using System;
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

        public static List<string>Get_Systems(string company, string plant)//get list of systems in the company and plant the user has access to
        {
            using (var context = new Model1())
            {
                var systems = (from sys in context.mill_Systems
                               where sys.gl_cmp_key == company && sys.sf_plant_key == plant && sys.Active == "Y"
                               select sys.System_Name.ToString()).ToList();
                return systems;
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

        public class Mills
        {
            public string Mill_ID { get; set; }
            public string Active { get; set; }
            public string Company { get; set; }
            public string Plant { get; set; }

        }

    
    }



}
