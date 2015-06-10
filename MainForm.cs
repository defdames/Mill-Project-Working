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
            
            cmbShift.DataSource = Get_Shift(cmbCompany.Text, cmbPlant.Text);
            cmbRunCode.DataSource = Program.Get_Run(cmbCompany.Text, cmbPlant.Text);
            //cmbCategory.DataSource = Program.Get_Category(cmbCompany.Text, cmbPlant.Text);

            cmbCategory.DataSource = Get_Category(cmbCompany.Text, cmbPlant.Text);

        }

        private void cmbMill_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSystem.DataSource = Program.Get_Systems(cmbCompany.Text, cmbPlant.Text, cmbMill.Text);
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string date = this.dtmShiftStart.Text.ToString();
            string starttime = this.mtxtStartTime.Text.ToString();
            string stoptime = this.mtxtStopTime.Text.ToString();


            DateTime dtstart = Convert.ToDateTime(date + " " + starttime);
            DateTime dtstop = Convert.ToDateTime(date + " " + stoptime);
            
            var just_date = dtstart.Date;
            //DateTime dt1start = DateTime.ParseExact(date + " " + starttime, "M/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);

            
            using (Model1 record = new Model1())
            {
                mill_Mills_Utilization rec = new mill_Mills_Utilization();
                {

                    
                    
                    rec.Mill_ID = cmbMill.Text;
                    rec.gl_cmp_key = cmbCompany.Text;
                    rec.sf_plant_key = cmbPlant.Text;
                    rec.Start_Time = dtstart;
                    rec.Stop_Time = dtstop;
                    rec.Memo = rtxtMemo.Text;
                    rec.System = cmbSystem.Text;
                    rec.Shift = cmbCategory.Text;
                    rec.Shift_Category = cmbCategory.Text;
                    rec.Run_Code = cmbRunCode.Text;
                    rec.Shift_Start_Date = just_date;
                    rec.Mill_temp = Decimal.Parse(txtTemp.Text);
                    rec.D10 = Decimal.Parse(mtxtD10.Text);
                    rec.D50 = Decimal.Parse(mtxtD50.Text);
                    rec.D90 = Decimal.Parse(mtxtD90.Text);
                    rec.D98 = Decimal.Parse(mtxtD98.Text);
                    rec.Item_Number = txtItemNo.Text;
                    rec.SO_Number = Int32.Parse(txtSONumber.Text);

                    record.mill_Mills_Utilization.Add(rec);
                    record.SaveChanges();


                }
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

        
       




       
       


    }

    public static class ObjectContextExtensions
    {
        public static void SubmitChanges(this ObjectContext context)
        {
            context.SaveChanges();
        }

        public static void InsertOnSubmit<T>(this ObjectQuery<T> table, T entity)
        {
            table.Context.AddObject(GetEntitySetName(table.Context, entity.GetType()), entity);
        }

        public static void InsertAllOnSubmit<T>(this ObjectQuery<T> table, IEnumerable<T> entities)
        {
            var entitySetName = GetEntitySetName(table.Context, typeof(T));
            foreach (var entity in entities)
            {
                table.Context.AddObject(entitySetName, entity);
            }
        }

        public static void DeleteAllOnSubmit<T>(this ObjectQuery<T> table, IEnumerable<T> entities) where T : EntityObject, new()
        {
            var entitiesList = entities.ToList();
            foreach (var entity in entitiesList)
            {
                if (null == entity.EntityKey)
                {
                    SetEntityKey(table.Context, entity);
                }

                var toDelete = (T)table.Context.GetObjectByKey(entity.EntityKey);
                if (null != toDelete)
                {
                    table.Context.DeleteObject(toDelete);
                }
            }
        }

        public static void SetEntityKey<TEntity>(this ObjectContext context, TEntity entity) where TEntity : EntityObject, new()
        {
            entity.EntityKey = context.CreateEntityKey(GetEntitySetName(context, entity.GetType()), entity);
        }

        public static string GetEntitySetName(this ObjectContext context, Type entityType)
        {
            return EntityHelper.GetEntitySetName(entityType, context);
        }
    }


    public static class EntityHelper
    {
        private static void LoadAssemblyIntoWorkspace(MetadataWorkspace workspace, Assembly assembly)
        {
            workspace.LoadFromAssembly(assembly);
        }

        #region GetEntitySetName

        public static string GetEntitySetName(Type entityType, ObjectContext context)
        {
            EntityType edmEntityType = GetEntityType(context, entityType);
            EntityContainer container = context.MetadataWorkspace.GetItems<EntityContainer>(DataSpace.CSpace).Single<EntityContainer>();
            EntitySet set = (EntitySet)container.BaseEntitySets.Single<EntitySetBase>(delegate(EntitySetBase p)
            {
                return (p.ElementType == edmEntityType);
            });
            return (container.Name + "." + set.Name);
        }

        #endregion

        #region GetEntityType
        public static EntityType GetEntityType(ObjectContext context, Type clrType)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (clrType == null)
            {
                throw new ArgumentNullException("clrType");
            }
            EdmType type = null;
            try
            {
                type = context.MetadataWorkspace.GetType(clrType.Name, clrType.Namespace, DataSpace.OSpace);
            }
            catch (ArgumentException)
            {
                LoadAssemblyIntoWorkspace(context.MetadataWorkspace, clrType.Assembly);
                type = context.MetadataWorkspace.GetType(clrType.Name, clrType.Namespace, DataSpace.OSpace);
            }
            return (EntityType)context.MetadataWorkspace.GetEdmSpaceType((StructuralType)type);
        }

        public static bool TryGetEntityType(ObjectContext context, Type clrType, out EntityType entityType)
        {
            entityType = null;
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (clrType == null)
            {
                throw new ArgumentNullException("clrType");
            }
            EdmType type = null;
            bool flag = context.MetadataWorkspace.TryGetType(clrType.Name, clrType.Namespace, DataSpace.OSpace, out type);
            if (!flag)
            {
                LoadAssemblyIntoWorkspace(context.MetadataWorkspace, clrType.Assembly);
                flag = context.MetadataWorkspace.TryGetType(clrType.Name, clrType.Namespace, DataSpace.OSpace, out type);
            }
            if (flag)
            {
                entityType = (EntityType)context.MetadataWorkspace.GetEdmSpaceType((StructuralType)type);
                return true;
            }
            return false;
        }
        #endregion

        #region GetReferenceProperty

        public static PropertyDescriptor GetReferenceProperty(PropertyDescriptor pd)
        {
            return GetReferenceProperty(pd, TypeDescriptor.GetProperties(pd.ComponentType).Cast<PropertyDescriptor>());
        }

        public static PropertyDescriptor GetReferenceProperty(PropertyDescriptor pd, IEnumerable<PropertyDescriptor> properties)
        {
            string refPropertyName = pd.Name + "Reference";
            return properties.SingleOrDefault<PropertyDescriptor>(delegate(PropertyDescriptor p)
            {
                return (p.Name == refPropertyName);
            });
        }
        #endregion

    }

   

}
