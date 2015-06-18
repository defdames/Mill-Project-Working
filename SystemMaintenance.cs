using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mill_Project
{
    public partial class SystemMaintenance : Form
    {
        BindingSource bs = new BindingSource();

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
        }

        private void btnGetSystems_Click(object sender, EventArgs e)
        {
            string company = cmbCompany.Text;
            string plant = cmbPlant.Text;


            context.mill_Mills.ToList();
            // bs.DataSource = context.mill_Mills.Local.ToBindingList();


            var query = from ml in context.mill_Sys_Mills_Combo
                        where ml.gl_cmp_key == company && ml.sf_plant_key == plant
                        select ml;

            bs.DataSource = query.ToList();
            this.dgvSystems.DataSource = bs;
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text);
        }
    }
}
