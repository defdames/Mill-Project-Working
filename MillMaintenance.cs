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
using Mill_Project.Data;
using System.Data.Linq.SqlClient;
using System.Data.Linq;
using System.IO;
using System.Web;


namespace Mill_Project
{
    public partial class MillMaintenance : Form
    {
        BindingSource bs = new BindingSource();

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
            string company = cmbCompany.Text;
            string plant = cmbPlant.Text;


            context.mill_Mills.ToList();
           // bs.DataSource = context.mill_Mills.Local.ToBindingList();


            var query = from ml in context.mill_Mills
                                 where ml.gl_cmp_key == company && ml.sf_plant_key == plant
                                 select ml;

            bs.DataSource = query.ToList();
            this.dgvMills.DataSource = bs;
  
        }


        public class Mills
        {
            public string Mill_ID { get; set; }
            public string Active { get; set; }
            public string gl_cmp_key { get; set; }
            public string sf_plant_key { get; set; }
            public int Mills_ID { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            context.SaveChanges();
            
        }

   

  
        
       
      
    }
}
