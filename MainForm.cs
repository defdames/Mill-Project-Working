using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mill_Project.Data;



namespace Mill_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            lblUserName.Text = Program.GetUser();
            cmbCompany.DataSource = Program.User_cmp(); 
            if (Program.GetUser().ToString() == "doland")
            {
                btnMillMaint.Enabled = true;
                btnMillMaint.Visible = true;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text);
        }

              
            
               
                
               
        

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Controls.ClearControls();
        }

        private void btnMillMaint_Click(object sender, EventArgs e)
        {
            MillMaintenance frm = new MillMaintenance();
            frm.Show();
        }

        private void cmbPlant_SelectedIndexChanged(object sender, EventArgs e)
        {   
            cmbMill.DataSource = Program.Get_Mills(cmbCompany.Text, cmbPlant.Text);
            cmbSystem.DataSource = Program.Get_Systems(cmbCompany.Text, cmbPlant.Text);
            cmbShift.DataSource = Program.Get_Shift(cmbCompany.Text, cmbPlant.Text);
            cmbRunCode.DataSource = Program.Get_Run(cmbCompany.Text, cmbPlant.Text);
            //cmbCategory.DataSource = Program.Get_Category(cmbCompany.Text, cmbPlant.Text);

            cmbCategory.DataSource = Get_Category(cmbCompany.Text, cmbPlant.Text);
           

            


        }

        private void btnPost_Click(object sender, EventArgs e)
        {
           

           
        }


        public static List<GetCat> Get_Category(string company, string plant)//get list of categories in the company and plant user has access to
        {
            using (var context = new Model1())
            {
                var c = from cat in context.mill_Shift_Categories
                        where cat.gl_cmp_key == company && cat.sf_plant_key == plant
                        select new GetCat { Cat = cat.Category, Desc = cat.Category_Description };

                return c.ToList();

            }

        }

        public class GetCat
        {
            public string Cat { get; set; }
            public string Desc { get; set; }


        }

       




       
       


    }



   

}
