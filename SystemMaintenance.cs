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
    public partial class SystemMaintenance : Form
    {
        BindingSource bs = new BindingSource();
        BindingSource systemcmb = new BindingSource();
        BindingSource millcmb = new BindingSource(); //mill category gridview combo box

        Model1 context = new Model1();
        public SystemMaintenance()
        {
            InitializeComponent();
            lblUserName.Text = Program.GetUser();
            cmbCompany.DataSource = Program.User_cmp();
        }

        private void SystemMaintenance_Load(object sender, EventArgs e)
        {
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text);
            btnSubmit.Enabled = false;
        }

        //private void btnGetSystems_Click(object sender, EventArgs e)
        //{
        //    string company = cmbCompany.Text;
        //    string plant = cmbPlant.Text;


        //    context.mill_Mills.ToList();
        //    // bs.DataSource = context.mill_Mills.Local.ToBindingList();


        //    var query = from ml in context.mill_Sys_Mills_Combo
        //                where ml.gl_cmp_key == company && ml.sf_plant_key == plant
        //                select ml;

        //    bs.DataSource = query.ToList();
        //    this.dgvSystems.DataSource = bs;
        //}

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text);
        }


        public static List<string> Get_Systems_Maint(string company, string plant)//get list of systems in the company and plant the user has access to
        {
            using (var context = new Model1())
            {
                var systems = (from sys in context.mill_Systems 
                                   where sys.gl_cmp_key == company && sys.sf_plant_key == plant && sys.Active == "Y"
                                   select sys.System_Name.ToString()).ToList();
                return systems;
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

        private void cmbPlant_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string company = cmbCompany.Text;
            string plant = cmbPlant.Text;
            //string mill = Mill_ID;


            context.mill_Mills.ToList();
            // bs.DataSource = context.mill_Mills.Local.ToBindingList();


            var query = from ml in context.mill_Sys_Mills_Combo
                        where ml.gl_cmp_key == company && ml.sf_plant_key == plant && ml.Active == "Y"
                        select ml;

            bs.DataSource = query.ToList();
            dgvSystems.DataSource = bs;

            cmbMill.DataSource = Get_Mills(company, plant);
           
            cmbMill.SelectedItem = null;
            cmbSystem.Enabled = false;


            //var systems = from sys in context.mill_Sys_Mills_Combo
            //              join ml in context.mill_Mills on sys.Mill_ID equals ml.Mill_ID
            //              where sys.gl_cmp_key == company && sys.sf_plant_key == plant && sys.Active == "Y" && sys.Mill_ID == mill
            //              select sys;

            #region Fills Systems Data Grid View Combo Box
            var syscmb = Get_Systems_Maint(company, plant);
            systemcmb.DataSource = syscmb.ToList();
            MillSystem.DataSource = systemcmb;
            #endregion

            #region Fills Mill Data Grid View Combo Box
            var mlcmb = Get_Mills(company, plant);
            millcmb.DataSource = mlcmb.ToList();
            Mill_ID.DataSource = millcmb;
            #endregion
        }

        private void dgvSystems_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var list = new String[] { "Y", "N" };
            if (dgvSystems.CurrentCell.ColumnIndex == 3)
            {
                if (!list.Contains(e.FormattedValue.ToString()))
                {
                    dgvSystems.Rows[e.RowIndex].ErrorText =
                        "Active must Y or N";
                    e.Cancel = true;
                }
                else
                {
                    dgvSystems.Rows[e.RowIndex].ErrorText = "";

                }

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           

            using (Model1 record = new Model1())
            {
                mill_Sys_Mills_Combo rec = new mill_Sys_Mills_Combo();
                {
                    rec.Active = "Y";
                    rec.gl_cmp_key = cmbCompany.Text;
                    rec.sf_plant_key = cmbPlant.Text;
                    rec.Mill_ID = cmbMill.Text;
                    rec.System = cmbSystem.Text;
                    rec.Created_by = Program.GetUser();
                    rec.Created_date = DateTime.Now;

                    record.mill_Sys_Mills_Combo.Add(rec);
                    record.SaveChanges();
                    context.SaveChanges();

                    context.mill_Sys_Mills_Combo.ToList();


                    string company = cmbCompany.Text;
                    string plant = cmbPlant.Text;

                    var query = from sys in context.mill_Sys_Mills_Combo
                                where sys.gl_cmp_key == company && sys.sf_plant_key == plant
                                select sys;

                    bs.DataSource = query.ToList();
                    dgvSystems.DataSource = bs;
                    
                }

            }
        }

        private void dgvSystems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            context.SaveChanges();
        }

        private void cmbMill_SelectedIndexChanged(object sender, EventArgs e)
        {
            string company = cmbCompany.Text;
            string plant = cmbPlant.Text;
            cmbSystem.DataSource = Get_Systems_Maint(company, plant);
            
            if (cmbMill.SelectedItem == null)
            {
                cmbSystem.Enabled = false;
                btnSubmit.Enabled = false;
            }
            else
            {
                cmbSystem.Enabled = true;
                btnSubmit.Enabled = true;
            }
        }
    }
}
