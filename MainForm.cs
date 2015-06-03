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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            txtUserName.Text = Program.GetUser();
            cmbCompany.DataSource = Program.User_cmp();
           
           
            
        }


       
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text);
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text);
            
        }

       




       
       


    }



   

}
