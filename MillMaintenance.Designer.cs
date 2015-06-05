namespace Mill_Project
{
    partial class MillMaintenance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPlant = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.btnGetMills = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.dgvMills = new System.Windows.Forms.DataGridView();
            this.millMillsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.millsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glcmpkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfplantkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifieddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millMillsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(909, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(202, 23);
            this.lblUserName.TabIndex = 54;
            this.lblUserName.Text = "label1";
            // 
            // lblPlant
            // 
            this.lblPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlant.Location = new System.Drawing.Point(803, 63);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(100, 23);
            this.lblPlant.TabIndex = 53;
            this.lblPlant.Text = "Plant";
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(803, 35);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(100, 23);
            this.lblCompany.TabIndex = 52;
            this.lblCompany.Text = "Company";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(803, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 51;
            this.lblUser.Text = "User";
            // 
            // cmbPlant
            // 
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(909, 63);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(202, 21);
            this.cmbPlant.TabIndex = 50;
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(909, 35);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCompany.Size = new System.Drawing.Size(202, 21);
            this.cmbCompany.TabIndex = 49;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // btnGetMills
            // 
            this.btnGetMills.Location = new System.Drawing.Point(909, 91);
            this.btnGetMills.Name = "btnGetMills";
            this.btnGetMills.Size = new System.Drawing.Size(143, 37);
            this.btnGetMills.TabIndex = 55;
            this.btnGetMills.Text = "Get Mills";
            this.btnGetMills.UseVisualStyleBackColor = true;
            this.btnGetMills.Click += new System.EventHandler(this.btnGetMills_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(909, 134);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 37);
            this.btnSubmit.TabIndex = 56;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMills
            // 
            this.dgvMills.AutoGenerateColumns = false;
            this.dgvMills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.millsIDDataGridViewTextBoxColumn,
            this.millIDDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn,
            this.glcmpkeyDataGridViewTextBoxColumn,
            this.sfplantkeyDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.modifieddateDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.modifiedbyDataGridViewTextBoxColumn});
            this.dgvMills.DataSource = this.millMillsBindingSource2;
            this.dgvMills.Location = new System.Drawing.Point(12, 218);
            this.dgvMills.Name = "dgvMills";
            this.dgvMills.Size = new System.Drawing.Size(965, 150);
            this.dgvMills.TabIndex = 57;
            // 
            // millMillsBindingSource2
            // 
            this.millMillsBindingSource2.DataSource = typeof(Mill_Project.Data.mill_Mills);
            // 
            // millsIDDataGridViewTextBoxColumn
            // 
            this.millsIDDataGridViewTextBoxColumn.DataPropertyName = "Mills_ID";
            this.millsIDDataGridViewTextBoxColumn.HeaderText = "Mills_ID";
            this.millsIDDataGridViewTextBoxColumn.Name = "millsIDDataGridViewTextBoxColumn";
            this.millsIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // millIDDataGridViewTextBoxColumn
            // 
            this.millIDDataGridViewTextBoxColumn.DataPropertyName = "Mill_ID";
            this.millIDDataGridViewTextBoxColumn.HeaderText = "Mill_ID";
            this.millIDDataGridViewTextBoxColumn.Name = "millIDDataGridViewTextBoxColumn";
            this.millIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "Active";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            // 
            // glcmpkeyDataGridViewTextBoxColumn
            // 
            this.glcmpkeyDataGridViewTextBoxColumn.DataPropertyName = "gl_cmp_key";
            this.glcmpkeyDataGridViewTextBoxColumn.HeaderText = "gl_cmp_key";
            this.glcmpkeyDataGridViewTextBoxColumn.Name = "glcmpkeyDataGridViewTextBoxColumn";
            this.glcmpkeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sfplantkeyDataGridViewTextBoxColumn
            // 
            this.sfplantkeyDataGridViewTextBoxColumn.DataPropertyName = "sf_plant_key";
            this.sfplantkeyDataGridViewTextBoxColumn.HeaderText = "sf_plant_key";
            this.sfplantkeyDataGridViewTextBoxColumn.Name = "sfplantkeyDataGridViewTextBoxColumn";
            this.sfplantkeyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "Created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "Created_date";
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            this.createddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.createddateDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifieddateDataGridViewTextBoxColumn
            // 
            this.modifieddateDataGridViewTextBoxColumn.DataPropertyName = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn.HeaderText = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn.Name = "modifieddateDataGridViewTextBoxColumn";
            this.modifieddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.modifieddateDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "Created_by";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "Created_by";
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            this.createdbyDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdbyDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifiedbyDataGridViewTextBoxColumn
            // 
            this.modifiedbyDataGridViewTextBoxColumn.DataPropertyName = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn.HeaderText = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn.Name = "modifiedbyDataGridViewTextBoxColumn";
            this.modifiedbyDataGridViewTextBoxColumn.ReadOnly = true;
            this.modifiedbyDataGridViewTextBoxColumn.Visible = false;
            // 
            // MillMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 475);
            this.Controls.Add(this.dgvMills);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnGetMills);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPlant);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbPlant);
            this.Controls.Add(this.cmbCompany);
            this.Name = "MillMaintenance";
            this.Text = "MillMaintenance";
            this.Load += new System.EventHandler(this.MillMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millMillsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPlant;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbPlant;
        public System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Button btnGetMills;
        private System.Windows.Forms.Button btnSubmit;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dgvMills;
        private System.Windows.Forms.BindingSource millMillsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn millsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glcmpkeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfplantkeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifieddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedbyDataGridViewTextBoxColumn;
    }
}