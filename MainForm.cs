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
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            mill_Mills_Utilization record = new mill_Mills_Utilization
            {

                Mill_ID = this.cmbMill.Text,



            }; 
        }

       




       
       


    }



   

}
