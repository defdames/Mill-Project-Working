namespace Mill_Project
{
    partial class SystemMaintenance
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
            this.dgvSystems = new System.Windows.Forms.DataGridView();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPlant = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbMill = new System.Windows.Forms.ComboBox();
            this.cmbSystem = new System.Windows.Forms.ComboBox();
            this.lblMill = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.sysMillsComboIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MillSystem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mill_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glcmpkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfplantkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifieddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millSysMillsComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millSysMillsComboBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSystems
            // 
            this.dgvSystems.AllowUserToAddRows = false;
            this.dgvSystems.AllowUserToDeleteRows = false;
            this.dgvSystems.AutoGenerateColumns = false;
            this.dgvSystems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sysMillsComboIDDataGridViewTextBoxColumn,
            this.MillSystem,
            this.Mill_ID,
            this.activeDataGridViewTextBoxColumn,
            this.glcmpkeyDataGridViewTextBoxColumn,
            this.sfplantkeyDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.modifieddateDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.modifiedbyDataGridViewTextBoxColumn});
            this.dgvSystems.DataSource = this.millSysMillsComboBindingSource;
            this.dgvSystems.Location = new System.Drawing.Point(27, 12);
            this.dgvSystems.Name = "dgvSystems";
            this.dgvSystems.Size = new System.Drawing.Size(610, 399);
            this.dgvSystems.TabIndex = 0;
            this.dgvSystems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSystems_CellEndEdit);
            this.dgvSystems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvSystems_CellValidating_1);
            // 
            // cmbPlant
            // 
            this.cmbPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(751, 67);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(202, 21);
            this.cmbPlant.TabIndex = 52;
            this.cmbPlant.SelectedIndexChanged += new System.EventHandler(this.cmbPlant_SelectedIndexChanged_1);
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(751, 39);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCompany.Size = new System.Drawing.Size(202, 21);
            this.cmbCompany.TabIndex = 51;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(751, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(202, 23);
            this.lblUserName.TabIndex = 55;
            this.lblUserName.Text = "label1";
            // 
            // lblPlant
            // 
            this.lblPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlant.Location = new System.Drawing.Point(645, 64);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(100, 23);
            this.lblPlant.TabIndex = 58;
            this.lblPlant.Text = "Plant";
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(645, 36);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(100, 23);
            this.lblCompany.TabIndex = 57;
            this.lblCompany.Text = "Company";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(645, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 56;
            this.lblUser.Text = "User";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(810, 240);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 37);
            this.btnSubmit.TabIndex = 59;
            this.btnSubmit.Text = "Add New System Combo";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbMill
            // 
            this.cmbMill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMill.FormattingEnabled = true;
            this.cmbMill.Location = new System.Drawing.Point(751, 171);
            this.cmbMill.Name = "cmbMill";
            this.cmbMill.Size = new System.Drawing.Size(202, 21);
            this.cmbMill.TabIndex = 60;
            this.cmbMill.SelectedIndexChanged += new System.EventHandler(this.cmbMill_SelectedIndexChanged);
            // 
            // cmbSystem
            // 
            this.cmbSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSystem.FormattingEnabled = true;
            this.cmbSystem.Location = new System.Drawing.Point(751, 198);
            this.cmbSystem.Name = "cmbSystem";
            this.cmbSystem.Size = new System.Drawing.Size(202, 21);
            this.cmbSystem.TabIndex = 61;
            // 
            // lblMill
            // 
            this.lblMill.AutoSize = true;
            this.lblMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMill.Location = new System.Drawing.Point(645, 174);
            this.lblMill.Name = "lblMill";
            this.lblMill.Size = new System.Drawing.Size(30, 18);
            this.lblMill.TabIndex = 62;
            this.lblMill.Text = "Mill";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(645, 201);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(58, 18);
            this.lblSystem.TabIndex = 63;
            this.lblSystem.Text = "System";
            // 
            // sysMillsComboIDDataGridViewTextBoxColumn
            // 
            this.sysMillsComboIDDataGridViewTextBoxColumn.DataPropertyName = "Sys_Mills_Combo_ID";
            this.sysMillsComboIDDataGridViewTextBoxColumn.HeaderText = "Sys_Mills_Combo_ID";
            this.sysMillsComboIDDataGridViewTextBoxColumn.Name = "sysMillsComboIDDataGridViewTextBoxColumn";
            this.sysMillsComboIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MillSystem
            // 
            this.MillSystem.DataPropertyName = "System";
            this.MillSystem.HeaderText = "System";
            this.MillSystem.Name = "MillSystem";
            this.MillSystem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MillSystem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Mill_ID
            // 
            this.Mill_ID.DataPropertyName = "Mill_ID";
            this.Mill_ID.HeaderText = "Mill_ID";
            this.Mill_ID.Name = "Mill_ID";
            this.Mill_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mill_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.glcmpkeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // sfplantkeyDataGridViewTextBoxColumn
            // 
            this.sfplantkeyDataGridViewTextBoxColumn.DataPropertyName = "sf_plant_key";
            this.sfplantkeyDataGridViewTextBoxColumn.HeaderText = "sf_plant_key";
            this.sfplantkeyDataGridViewTextBoxColumn.Name = "sfplantkeyDataGridViewTextBoxColumn";
            this.sfplantkeyDataGridViewTextBoxColumn.Visible = false;
            // 
            // createddateDataGridViewTextBoxColumn
            // 
            this.createddateDataGridViewTextBoxColumn.DataPropertyName = "Created_date";
            this.createddateDataGridViewTextBoxColumn.HeaderText = "Created_date";
            this.createddateDataGridViewTextBoxColumn.Name = "createddateDataGridViewTextBoxColumn";
            this.createddateDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifieddateDataGridViewTextBoxColumn
            // 
            this.modifieddateDataGridViewTextBoxColumn.DataPropertyName = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn.HeaderText = "Modified_date";
            this.modifieddateDataGridViewTextBoxColumn.Name = "modifieddateDataGridViewTextBoxColumn";
            this.modifieddateDataGridViewTextBoxColumn.Visible = false;
            // 
            // createdbyDataGridViewTextBoxColumn
            // 
            this.createdbyDataGridViewTextBoxColumn.DataPropertyName = "Created_by";
            this.createdbyDataGridViewTextBoxColumn.HeaderText = "Created_by";
            this.createdbyDataGridViewTextBoxColumn.Name = "createdbyDataGridViewTextBoxColumn";
            this.createdbyDataGridViewTextBoxColumn.Visible = false;
            // 
            // modifiedbyDataGridViewTextBoxColumn
            // 
            this.modifiedbyDataGridViewTextBoxColumn.DataPropertyName = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn.HeaderText = "Modified_by";
            this.modifiedbyDataGridViewTextBoxColumn.Name = "modifiedbyDataGridViewTextBoxColumn";
            this.modifiedbyDataGridViewTextBoxColumn.Visible = false;
            // 
            // millSysMillsComboBindingSource
            // 
            this.millSysMillsComboBindingSource.DataSource = typeof(Mill_Project.mill_Sys_Mills_Combo);
            // 
            // SystemMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 423);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.lblMill);
            this.Controls.Add(this.cmbSystem);
            this.Controls.Add(this.cmbMill);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPlant);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.cmbPlant);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.dgvSystems);
            this.Name = "SystemMaintenance";
            this.Text = "SystemMaintenance";
            this.Load += new System.EventHandler(this.SystemMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millSysMillsComboBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSystems;
        private System.Windows.Forms.ComboBox cmbPlant;
        public System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPlant;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.BindingSource millSysMillsComboBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sysMillsComboIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn MillSystem;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mill_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn glcmpkeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfplantkeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifieddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbMill;
        private System.Windows.Forms.ComboBox cmbSystem;
        private System.Windows.Forms.Label lblMill;
        private System.Windows.Forms.Label lblSystem;
    }
}