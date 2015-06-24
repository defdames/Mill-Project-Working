using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;
using System.Data.Linq;
using System.IO;
using System.Web;


namespace Mill_Project
{
    public partial class MillMaintenance : Form
    {
        BindingSource bs = new BindingSource();
        BindingSource systemcmb = new BindingSource();

        Model1 context = new Model1();


        public MillMaintenance()
        {
            InitializeComponent();
            lblUserName.Text = Program.GetUser();
            cmbCompany.DataSource = Program.User_cmp();
            
            
        }


       

        private void MillMaintenance_Load(object sender, EventArgs e)
        {
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text);

            

            
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text);
        }

        private void btnGetMills_Click(object sender, EventArgs e)
        {
            
  
        }


        public class Mills
        {
            public string Mill_ID { get; set; }
            public string Active { get; set; }
            public string gl_cmp_key { get; set; }
            public string sf_plant_key { get; set; }
            public int Mills_ID { get; set; }

        }

       

        private void dgvMills_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var list = new String[] { "Y", "N" };
            if (dgvMills.CurrentCell.ColumnIndex == 2)

            {
                if (!list.Contains(e.FormattedValue.ToString()))
                {
                        dgvMills.Rows[e.RowIndex].ErrorText =
                            "Active must Y or N";
                        e.Cancel = true; 
                }
                else
                {
                    dgvMills.Rows[e.RowIndex].ErrorText = "";
                    
                }

            }
            
        }

        private void cmbPlant_SelectedIndexChanged(object sender, EventArgs e)
        {
            string company = cmbCompany.Text;
            string plant = cmbPlant.Text;
            


            context.mill_Mills.ToList();
            // bs.DataSource = context.mill_Mills.Local.ToBindingList();


            var query = from ml in context.mill_Mills
                        where ml.gl_cmp_key == company && ml.sf_plant_key == plant
                        select ml;

            bs.DataSource = query.ToList();
            dgvMills.DataSource = bs;



            //#region Fills Mill Data Grid View Combo Box
            //var syscmb = Get_Mills(company, plant);
            //millcmb.DataSource = mlcmb.ToList();
            //Mill_ID.DataSource = millcmb;
            //#endregion
        }

        private void btnSaveChanges(object sender, EventArgs e)
        {
            context.SaveChanges();
        }

        public static string Get_Systems_Single(string company, string plant, string mill)//get list of systems in the company and plant the user has access to
        {
            using (var context = new Model1())
            {
                var systems = (from sys in context.mill_Systems
                               join sysc in context.mill_Sys_Mills_Combo on sys.System_Name equals sysc.System
                               where sys.gl_cmp_key == company && sys.sf_plant_key == plant && sys.Active == "Y" && sysc.Mill_ID == mill
                               select sysc.System.ToString()).SingleOrDefault();
                return systems;
            }
        }

   

  
        
       
      
    }
}
