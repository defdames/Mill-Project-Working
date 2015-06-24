using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.Metadata.Edm;
using System.Globalization;
using System.Reflection;





namespace Mill_Project
{
    public partial class MainForm : Form
    {
        DateTimePicker oDateTimePicker;

        BindingSource bs = new BindingSource();
        BindingSource runcmb = new BindingSource(); //run code gridview combo box
        BindingSource shiftcmb = new BindingSource(); //shift category gridview combo box
        BindingSource millcmb = new BindingSource(); //mill category gridview combo box
        BindingSource systemcmb = new BindingSource(); //system category gridview combo box

        Model1 context = new Model1();
        public MainForm()
        {
            InitializeComponent();
            lblUserName.Text = Program.GetUser();
            cmbCompany.DataSource = Program.User_cmp(); 
            if (Program.GetUser().ToString() == "doland")
            {
                btnMillMaint.Enabled = true;
                btnMillMaint.Visible = true;
                btnSysMaint.Enabled = true;
                btnSysMaint.Visible = true;
            }
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
           
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text);
           

            #region autofill values
            mtxtD10.Mask = "0.00";
            mtxtD10.Text = "0.00";
            mtxtD50.Mask = "0.00";
            mtxtD50.Text = "0.00";
            mtxtD90.Mask = "0.00";
            mtxtD90.Text = "0.00";
            mtxtD98.Mask = "0.00";
            mtxtD98.Text = "0.00";
            mtxtTemp.Mask = "000.00";
            mtxtTemp.Text = "000.00";
            txtSONumber.Text = "0";
            #endregion

            #region validaion calls for Masked TextBoxes
            mtxtD10.MaskInputRejected += new MaskInputRejectedEventHandler(mtxtD10_MaskInputRejected);
            mtxtD10.ValidatingType = typeof(System.Decimal);
            mtxtD10.TypeValidationCompleted += new TypeValidationEventHandler(mtxtD10_TypeValidationCompleted);

            mtxtD50.MaskInputRejected += new MaskInputRejectedEventHandler(mtxtD50_MaskInputRejected);
            mtxtD50.ValidatingType = typeof(System.Decimal);
            mtxtD50.TypeValidationCompleted += new TypeValidationEventHandler(mtxtD50_TypeValidationCompleted);

            mtxtD90.MaskInputRejected += new MaskInputRejectedEventHandler(mtxtD90_MaskInputRejected);
            mtxtD90.ValidatingType = typeof(System.Decimal);
            mtxtD90.TypeValidationCompleted += new TypeValidationEventHandler(mtxtD90_TypeValidationCompleted);

            mtxtD98.MaskInputRejected += new MaskInputRejectedEventHandler(mtxtD98_MaskInputRejected);
            mtxtD98.ValidatingType = typeof(System.Decimal);
            mtxtD98.TypeValidationCompleted += new TypeValidationEventHandler(mtxtD98_TypeValidationCompleted);

            mtxtTemp.MaskInputRejected += new MaskInputRejectedEventHandler(mtxtTemp_MaskInputRejected);
            mtxtTemp.ValidatingType = typeof(System.Decimal);
            mtxtTemp.TypeValidationCompleted += new TypeValidationEventHandler(mtxtTemp_TypeValidationCompleted);
            #endregion
        }


        #region Validation methods for Masked Text Boxes
        public void mtxtD10_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                ttD10.ToolTipTitle = "Invalid Decimal Value";
                ttD10.Show("We're sorry, but the value you entered is not a valid deciaml. Please change the value.", mtxtD10, 0, 25);
                e.Cancel = true;
            }
        }
        
        void mtxtD10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttD10.ToolTipTitle = "Invalid Input";
            ttD10.Show("We're sorry, but only digits (0-9) are allowed in this control.", mtxtD10, 0, 25);
        }

        public void mtxtD50_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                ttD50.ToolTipTitle = "Invalid Decimal Value";
                ttD50.Show("We're sorry, but the value you entered is not a valid deciaml. Please change the value.", mtxtD50, 0, 25);
                e.Cancel = true;
            }
        }

        void mtxtD50_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttD50.ToolTipTitle = "Invalid Input";
            ttD50.Show("We're sorry, but only digits (0-9) are allowed in this control.", mtxtD50, 0, 25);
        }

        public void mtxtD90_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                ttD90.ToolTipTitle = "Invalid Decimal Value";
                ttD90.Show("We're sorry, but the value you entered is not a valid deciaml. Please change the value.", mtxtD90, 0, 25);
                e.Cancel = true;
            }
        }

        void mtxtD90_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttD90.ToolTipTitle = "Invalid Input";
            ttD90.Show("We're sorry, but only digits (0-9) are allowed in this control.", mtxtD90, 0, 25);
        }


        public void mtxtD98_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                ttD98.ToolTipTitle = "Invalid Decimal Value";
                ttD98.Show("We're sorry, but the value you entered is not a valid deciaml. Please change the value.", mtxtD98, 0, 25);
                e.Cancel = true;
            }
        }

        void mtxtD98_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttD98.ToolTipTitle = "Invalid Input";
            ttD98.Show("We're sorry, but only digits (0-9) are allowed in this control.", mtxtD98, 0, 25);
        }

        public void mtxtTemp_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                ttTemp.ToolTipTitle = "Invalid Decimal Value";
                ttTemp.Show("We're sorry, but the value you entered is not a valid deciaml. Please change the value.", mtxtTemp, 0, 25);
                e.Cancel = true;
            }
        }

        void mtxtTemp_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ttTemp.ToolTipTitle = "Invalid Input";
            ttTemp.Show("We're sorry, but only digits (0-9) are allowed in this control.", mtxtTemp, 0, 25);
        }
        #endregion

        private void txtSONumber_KeyPress(object sender, KeyPressEventArgs e)//Only allow one . in text box and is a digit
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void dgvMillUtil_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)//Handles validation datagridview columns Temp and D columns
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvMillUtil.CurrentCell.ColumnIndex == 16 || dgvMillUtil.CurrentCell.ColumnIndex == 17 || dgvMillUtil.CurrentCell.ColumnIndex == 18 || dgvMillUtil.CurrentCell.ColumnIndex == 19 || dgvMillUtil.CurrentCell.ColumnIndex == 20) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)//Handles validation datagridview columns Temp and D columns 
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbPlant.DataSource = Program.Cmp_plant(cmbCompany.Text); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Controls.ClearControls();
            mtxtD10.Mask = "0.00";
            mtxtD10.Text = "0.00";
            mtxtD50.Mask = "0.00";
            mtxtD50.Text = "0.00";
            mtxtD90.Mask = "0.00";
            mtxtD90.Text = "0.00";
            mtxtD98.Mask = "0.00";
            mtxtD98.Text = "0.00";
            mtxtTemp.Mask = "0.000";
            mtxtTemp.Text = "0.000";
            txtSONumber.Text = "0";
        }

        private void btnMillMaint_Click(object sender, EventArgs e)
        {
            MillMaintenance frm = new MillMaintenance();
            frm.Show();
        }

        private void cmbPlant_SelectedIndexChanged(object sender, EventArgs e)
        {   
           
            cmbMill.DataSource = Program.Get_Mills(cmbCompany.Text, cmbPlant.Text);
            
            cmbShift.DataSource = Get_Shift(cmbCompany.Text, cmbPlant.Text);
            cmbRunCode.DataSource = Program.Get_Run(cmbCompany.Text, cmbPlant.Text);
            //cmbCategory.DataSource = Program.Get_Category(cmbCompany.Text, cmbPlant.Text);

            cmbCategory.DataSource = Get_Category(cmbCompany.Text, cmbPlant.Text);

            context.mill_Mills_Utilization.ToList();
            string company = cmbCompany.Text;
            string plant = cmbPlant.Text;

            var query = from mu in context.mill_Mills_Utilization
                        where mu.gl_cmp_key == company && mu.sf_plant_key == plant
                        select mu;

            bs.DataSource = query.ToList();
            dgvMillUtil.DataSource = bs;

            #region fills Run Code Data Grid View Combo Box
            var cmb = Program.Get_Run(company, plant);
            runcmb.DataSource = cmb.ToList();
            Run_Code.DataSource = runcmb;
            #endregion

            #region Fills Shift Category Data Grid View Combo Box
            var shcmb = Get_Category(company, plant);
            shiftcmb.DataSource = shcmb.ToList();
            Shift_Category.DataSource = shiftcmb;
            #endregion

            #region Fills Mill Data Grid View Combo Box
            var mlcmb = Get_Mills(company, plant);
            millcmb.DataSource = mlcmb.ToList();
            Mill_ID.DataSource = millcmb;
            #endregion



        }

        private void cmbMill_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSystem.DataSource = Program.Get_Systems(cmbCompany.Text, cmbPlant.Text, cmbMill.Text);
        }


        
        private void btnPost_Click(object sender, EventArgs e)
        {
            string date = this.dtmShiftStart.Text.ToString();

            //string starttime = this.mtxtStartTime.Text.ToString();
            //string stoptime = this.mtxtStopTime.Text.ToString();

            string starttime = dtStart.Value.ToString();
            string stoptime = dtStop.Value.ToString();

            DateTime dts = DateTime.Parse(starttime);
            DateTime dtss = DateTime.Parse(stoptime);
            

            DateTime dtvstart = Convert.ToDateTime(date + " " + dts.TimeOfDay);
            DateTime dtvstop = Convert.ToDateTime(date + " " + dtss.TimeOfDay);

            TimeSpan hrbooked = dtss - dts;
            //DateTime dtStartTimeValue = dtStart.Text;
            
            var just_date = dtvstart.Date;
            //DateTime dt1start = DateTime.ParseExact(date + " " + starttime, "M/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            var timecheck = from mu in context.mill_Mills_Utilization
                            where cmbMill.Text == mu.Mill_ID && dtStart.Value < mu.Shift_Stop_Time && dtStop.Value > mu.Shift_Start_Time
                            select new { mu.Mills_Utilization_ID, mu.Mill_ID, mu.Shift_Start_Time, mu.Shift_Stop_Time };

            if (timecheck.Count() == 0)
            {
                if (dtStart.Value <= dtStop.Value)
                {
                    if (hrbooked.TotalHours <= 24)
                    {
                        if (cmbCategory.SelectedItem != null)
                        {
                            using (Model1 record = new Model1())
                            {
                                mill_Mills_Utilization rec = new mill_Mills_Utilization();
                                {



                                    rec.Mill_ID = cmbMill.Text;
                                    rec.gl_cmp_key = cmbCompany.Text;
                                    rec.sf_plant_key = cmbPlant.Text;
                                    rec.Start_Time = dts;
                                    rec.Stop_Time = dtss;
                                    rec.Memo = rtxtMemo.Text;
                                    rec.System = cmbSystem.Text;
                                    rec.Shift = cmbShift.Text;
                                    rec.Shift_Category = cmbCategory.Text;
                                    rec.Run_Code = cmbRunCode.Text;
                                    rec.Shift_Start_Date = dtStart.Value;
                                    rec.Shift_Start_Time = dtvstart;
                                    rec.Shift_Stop_Time = dtvstop;
                                    rec.Mill_temp = Decimal.Parse(mtxtTemp.Text);
                                    rec.D10 = Decimal.Parse(mtxtD10.Text);
                                    rec.D50 = Decimal.Parse(mtxtD50.Text);
                                    rec.D90 = Decimal.Parse(mtxtD90.Text);
                                    rec.D98 = Decimal.Parse(mtxtD98.Text);
                                    rec.Item_Number = txtItemNo.Text;
                                    
                                    rec.Mill_Hours_Booked = hrbooked;
                                    rec.SO_Number = Int32.Parse(txtSONumber.Text);
                                    rec.sa_user_key = Program.GetUser();
                                    rec.Created_by = Program.GetUser();
                                    rec.Created_date = DateTime.Now;

                                    record.mill_Mills_Utilization.Add(rec);
                                    record.SaveChanges();

                                    context.mill_Mills_Utilization.ToList();


                                    string company = cmbCompany.Text;
                                    string plant = cmbPlant.Text;

                                    var query = from mu in context.mill_Mills_Utilization
                                                where mu.gl_cmp_key == company && mu.sf_plant_key == plant
                                                select mu;

                                    bs.DataSource = query.ToList();
                                    dgvMillUtil.DataSource = bs;
                                }
                            }
                        }
                        else
                        {
                            ttCategory.Show("Category cannot be blank.  Please Pick a Category", cmbCategory, 0, 25);
                        }
                    }

                    else
                    {
                        tt24.Show("Time Span cannot be greater then 24 hours. Please check start and top time", dtStop, 0, 25);
                    }
                }

                else
                {
                    ttTime.Show("Start time cannot be greater then Stop Time", dtStart, 0, 25);
                }
            }
            else
            {
                ttDuplicateMillShift.Show("Shift for this Mill already exisits, please change time or mill", btnPost, 0, 25);
            }
        }



        public static List<String> Get_Category(string company, string plant)//get list of categories in the company and plant user has access to
        {
            using (var context = new Model1())
            {
                var c = (from cat in context.mill_Shift_Categories
                        where cat.gl_cmp_key == company && cat.sf_plant_key == plant
                        select cat.Category.ToString() + " - " + cat.Category_Description.ToString()).ToList();

                return c;
            }
        }

        public static List<String> Get_Shift(string company, string plant)//get list of Shifts in the campnay plant user has access to
        {
            using (var context = new Model1())
            {
                var shifts = (from shift in context.mill_Shift_Patterns
                              where shift.gl_cmp_key == company && shift.sf_plant_key == plant && shift.Shift_Active == "Y"
                              select shift.Shift_ID).ToList();
                return shifts;
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

        public class GetCat
        {
            public string Cat { get; set; }
            public string Desc { get; set; }
        }

        public class GetShiftPattern
        {
            public string Shift_ID { get; set; }
            public int Shift_Length { get; set; }
            public string Shift_Start { get; set; }
            public string Shift_Stop { get; set; }
            public string Comment { get; set; }

        }



        private void dgvMillUtil_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            #region Chanegs System value in data grid to match Mill
            int stoprowindex;
            stoprowindex = dgvMillUtil.CurrentCell.RowIndex;
            string company = cmbCompany.Text;
            string plant = cmbPlant.Text;
            if (dgvMillUtil.CurrentCell.ColumnIndex == 8)
            {
                stoprowindex = dgvMillUtil.CurrentCell.RowIndex;


                var syscmb = Get_Systems_Single(company, plant, dgvMillUtil[8, stoprowindex].Value.ToString());
                dgvMillUtil[7, stoprowindex].Value = syscmb;
                context.SaveChanges();

            }
            #endregion
            context.SaveChanges();
        }

        private void dgvMillUtil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dgvMillUtil.CurrentCell.ColumnIndex == 11 || dgvMillUtil.CurrentCell.ColumnIndex == 12)
            {
                
                //Initialized a new DateTimePicker Control  
                oDateTimePicker = new DateTimePicker();

                //Adding DateTimePicker control into DataGridView   
                dgvMillUtil.Controls.Add(oDateTimePicker);

                // Setting the format  
                oDateTimePicker.Format = DateTimePickerFormat.Custom;
                oDateTimePicker.CustomFormat = "MM/dd/yyyy HH:mm tt";
                oDateTimePicker.ShowUpDown = true;
                

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = dgvMillUtil.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);
                //Setting Value so it doesn't default to today
                oDateTimePicker.Value = DateTime.Parse(dgvMillUtil.CurrentCell.Value.ToString());
                

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                 
                // An event attached to dateTimePicker Control which is fired when any date is selected  
                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible  
                //oDateTimePicker.Visible = true;  
            }
        }
        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            oDateTimePicker.Visible = false;
            
        }
        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            dgvMillUtil.CurrentCell.Value = oDateTimePicker.Text.ToString();
           
            
        }

        private void dgvMillUtil_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            DateTime datetimestart;
            DateTime datetimestop;
            int stoprowindex;
            TimeSpan newhrsbooked;
            string millId;
           


            if (dgvMillUtil.CurrentCell.ColumnIndex == 11 || dgvMillUtil.CurrentCell.ColumnIndex == 12)
            {
                stoprowindex = dgvMillUtil.CurrentCell.RowIndex;

                datetimestart = DateTime.Parse(dgvMillUtil[11, stoprowindex].Value.ToString());
                datetimestop = DateTime.Parse(dgvMillUtil[12, stoprowindex].Value.ToString());
                millId = dgvMillUtil[8, stoprowindex].Value.ToString();

                var timecheckstart = from mu in context.mill_Mills_Utilization
                                where millId == mu.Mill_ID && datetimestart < mu.Shift_Stop_Time && datetimestop > mu.Shift_Start_Time
                                select new { mu.Mills_Utilization_ID, mu.Mill_ID, mu.Shift_Start_Time, mu.Shift_Stop_Time };

                if (timecheckstart.Count() <= 1 )//One record should only exist
                {
                    newhrsbooked = datetimestop - datetimestart;
                    dgvMillUtil[9, stoprowindex].Value = newhrsbooked;

                    if (newhrsbooked.TotalHours <= 24)
                    {
                        if (datetimestart <= datetimestop)
                        {
                            dgvMillUtil.Rows[e.RowIndex].ErrorText = "";
                            context.SaveChanges();
                        }
                        else
                        {
                            dgvMillUtil.Rows[e.RowIndex].ErrorText = "Start time cannot be greater then Stop Time";
                        }
                    }
                    else
                    {
                        dgvMillUtil.Rows[e.RowIndex].ErrorText = "Shift for this Mill already exisits, please change time or mill";
                    }
                }
                else
                {
                    dgvMillUtil.Rows[e.RowIndex].ErrorText = "Time Span cannot be greater then 24 hours. Please check start and top time";
                }
                oDateTimePicker.Visible = false;
            }

        }

        private void btnSysMaint_Click(object sender, EventArgs e)
        {
            SystemMaintenance frm = new SystemMaintenance();
            frm.Show();
        }
        }

}

       


     

        
       




       
       


    

    //public static class ObjectContextExtensions
    //{
    //    public static void SubmitChanges(this ObjectContext context)
    //    {
    //        context.SaveChanges();
    //    }

    //    public static void InsertOnSubmit<T>(this ObjectQuery<T> table, T entity)
    //    {
    //        table.Context.AddObject(GetEntitySetName(table.Context, entity.GetType()), entity);
    //    }

    //    public static void InsertAllOnSubmit<T>(this ObjectQuery<T> table, IEnumerable<T> entities)
    //    {
    //        var entitySetName = GetEntitySetName(table.Context, typeof(T));
    //        foreach (var entity in entities)
    //        {
    //            table.Context.AddObject(entitySetName, entity);
    //        }
    //    }

    //    public static void DeleteAllOnSubmit<T>(this ObjectQuery<T> table, IEnumerable<T> entities) where T : EntityObject, new()
    //    {
    //        var entitiesList = entities.ToList();
    //        foreach (var entity in entitiesList)
    //        {
    //            if (null == entity.EntityKey)
    //            {
    //                SetEntityKey(table.Context, entity);
    //            }

    //            var toDelete = (T)table.Context.GetObjectByKey(entity.EntityKey);
    //            if (null != toDelete)
    //            {
    //                table.Context.DeleteObject(toDelete);
    //            }
    //        }
    //    }

    //    public static void SetEntityKey<TEntity>(this ObjectContext context, TEntity entity) where TEntity : EntityObject, new()
    //    {
    //        entity.EntityKey = context.CreateEntityKey(GetEntitySetName(context, entity.GetType()), entity);
    //    }

    //    public static string GetEntitySetName(this ObjectContext context, Type entityType)
    //    {
    //        return EntityHelper.GetEntitySetName(entityType, context);
    //    }
    //}


    //public static class EntityHelper
    //{
    //    private static void LoadAssemblyIntoWorkspace(MetadataWorkspace workspace, Assembly assembly)
    //    {
    //        workspace.LoadFromAssembly(assembly);
    //    }

    //    #region GetEntitySetName

    //    public static string GetEntitySetName(Type entityType, ObjectContext context)
    //    {
    //        EntityType edmEntityType = GetEntityType(context, entityType);
    //        EntityContainer container = context.MetadataWorkspace.GetItems<EntityContainer>(DataSpace.CSpace).Single<EntityContainer>();
    //        EntitySet set = (EntitySet)container.BaseEntitySets.Single<EntitySetBase>(delegate(EntitySetBase p)
    //        {
    //            return (p.ElementType == edmEntityType);
    //        });
    //        return (container.Name + "." + set.Name);
    //    }

    //    #endregion

    //    #region GetEntityType
    //    public static EntityType GetEntityType(ObjectContext context, Type clrType)
    //    {
    //        if (context == null)
    //        {
    //            throw new ArgumentNullException("context");
    //        }
    //        if (clrType == null)
    //        {
    //            throw new ArgumentNullException("clrType");
    //        }
    //        EdmType type = null;
    //        try
    //        {
    //            type = context.MetadataWorkspace.GetType(clrType.Name, clrType.Namespace, DataSpace.OSpace);
    //        }
    //        catch (ArgumentException)
    //        {
    //            LoadAssemblyIntoWorkspace(context.MetadataWorkspace, clrType.Assembly);
    //            type = context.MetadataWorkspace.GetType(clrType.Name, clrType.Namespace, DataSpace.OSpace);
    //        }
    //        return (EntityType)context.MetadataWorkspace.GetEdmSpaceType((StructuralType)type);
    //    }

    //    public static bool TryGetEntityType(ObjectContext context, Type clrType, out EntityType entityType)
    //    {
    //        entityType = null;
    //        if (context == null)
    //        {
    //            throw new ArgumentNullException("context");
    //        }
    //        if (clrType == null)
    //        {
    //            throw new ArgumentNullException("clrType");
    //        }
    //        EdmType type = null;
    //        bool flag = context.MetadataWorkspace.TryGetType(clrType.Name, clrType.Namespace, DataSpace.OSpace, out type);
    //        if (!flag)
    //        {
    //            LoadAssemblyIntoWorkspace(context.MetadataWorkspace, clrType.Assembly);
    //            flag = context.MetadataWorkspace.TryGetType(clrType.Name, clrType.Namespace, DataSpace.OSpace, out type);
    //        }
    //        if (flag)
    //        {
    //            entityType = (EntityType)context.MetadataWorkspace.GetEdmSpaceType((StructuralType)type);
    //            return true;
    //        }
    //        return false;
    //    }
    //    #endregion

    //    #region GetReferenceProperty

    //    public static PropertyDescriptor GetReferenceProperty(PropertyDescriptor pd)
    //    {
    //        return GetReferenceProperty(pd, TypeDescriptor.GetProperties(pd.ComponentType).Cast<PropertyDescriptor>());
    //    }

    //    public static PropertyDescriptor GetReferenceProperty(PropertyDescriptor pd, IEnumerable<PropertyDescriptor> properties)
    //    {
    //        string refPropertyName = pd.Name + "Reference";
    //        return properties.SingleOrDefault<PropertyDescriptor>(delegate(PropertyDescriptor p)
    //        {
    //            return (p.Name == refPropertyName);
    //        });
    //    }
    //    #endregion

    //}

   

