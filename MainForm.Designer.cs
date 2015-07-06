namespace Mill_Project
{
    partial class MainForm
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.dtmShiftStart = new System.Windows.Forms.DateTimePicker();
            this.lblShiftStart = new System.Windows.Forms.Label();
            this.lblSONumber = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.cmbPlant = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblPlant = new System.Windows.Forms.Label();
            this.txtSONumber = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.lblMill = new System.Windows.Forms.Label();
            this.cmbMill = new System.Windows.Forms.ComboBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblD10 = new System.Windows.Forms.Label();
            this.lblD98 = new System.Windows.Forms.Label();
            this.lblD90 = new System.Windows.Forms.Label();
            this.lblD50 = new System.Windows.Forms.Label();
            this.cmbSystem = new System.Windows.Forms.ComboBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.mtxtD10 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtD98 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtD90 = new System.Windows.Forms.MaskedTextBox();
            this.mtxtD50 = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbRunCode = new System.Windows.Forms.ComboBox();
            this.lblRunCode = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblStopTime = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtxtMemo = new System.Windows.Forms.RichTextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.dgvMillUtil = new System.Windows.Forms.DataGridView();
            this.millMillsUtilizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnMillMaint = new System.Windows.Forms.Button();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtStop = new System.Windows.Forms.DateTimePicker();
            this.ttD10 = new System.Windows.Forms.ToolTip(this.components);
            this.mtxtTemp = new System.Windows.Forms.MaskedTextBox();
            this.ttD50 = new System.Windows.Forms.ToolTip(this.components);
            this.ttD90 = new System.Windows.Forms.ToolTip(this.components);
            this.ttD98 = new System.Windows.Forms.ToolTip(this.components);
            this.ttTemp = new System.Windows.Forms.ToolTip(this.components);
            this.ttTime = new System.Windows.Forms.ToolTip(this.components);
            this.tt24 = new System.Windows.Forms.ToolTip(this.components);
            this.ttCategory = new System.Windows.Forms.ToolTip(this.components);
            this.ttDuplicateMillShift = new System.Windows.Forms.ToolTip(this.components);
            this.btnSysMaint = new System.Windows.Forms.Button();
            this.millStoppageReasonsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.millStoppageReasonsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvcmbRun_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfplantkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifieddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millsUtilizationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.System_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mill_ID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Mill_Hours_Booked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Run_Code = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift_Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.milltempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d10DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d50DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d90DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d98DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sauserkeyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftStartDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftStopTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMillUtil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millMillsUtilizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStoppageReasonsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStoppageReasonsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(12, 1);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(171, 31);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "Mill Utilization";
            // 
            // dtmShiftStart
            // 
            this.dtmShiftStart.CustomFormat = "MM dd yyyy hh mm ss";
            this.dtmShiftStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmShiftStart.Location = new System.Drawing.Point(128, 45);
            this.dtmShiftStart.Name = "dtmShiftStart";
            this.dtmShiftStart.Size = new System.Drawing.Size(200, 20);
            this.dtmShiftStart.TabIndex = 2;
            // 
            // lblShiftStart
            // 
            this.lblShiftStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShiftStart.Location = new System.Drawing.Point(39, 45);
            this.lblShiftStart.Name = "lblShiftStart";
            this.lblShiftStart.Size = new System.Drawing.Size(83, 20);
            this.lblShiftStart.TabIndex = 3;
            this.lblShiftStart.Text = "Shift Start";
            // 
            // lblSONumber
            // 
            this.lblSONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSONumber.Location = new System.Drawing.Point(344, 47);
            this.lblSONumber.Name = "lblSONumber";
            this.lblSONumber.Size = new System.Drawing.Size(95, 18);
            this.lblSONumber.TabIndex = 4;
            this.lblSONumber.Text = "SO Number";
            // 
            // cmbCompany
            // 
            this.cmbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(964, 28);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCompany.Size = new System.Drawing.Size(202, 21);
            this.cmbCompany.TabIndex = 5;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // cmbPlant
            // 
            this.cmbPlant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(964, 56);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(202, 21);
            this.cmbPlant.TabIndex = 6;
            this.cmbPlant.SelectedIndexChanged += new System.EventHandler(this.cmbPlant_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(858, 1);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(100, 23);
            this.lblUser.TabIndex = 7;
            this.lblUser.Text = "User";
            // 
            // lblCompany
            // 
            this.lblCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompany.Location = new System.Drawing.Point(858, 28);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(100, 23);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "Company";
            // 
            // lblPlant
            // 
            this.lblPlant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlant.Location = new System.Drawing.Point(858, 56);
            this.lblPlant.Name = "lblPlant";
            this.lblPlant.Size = new System.Drawing.Size(100, 23);
            this.lblPlant.TabIndex = 9;
            this.lblPlant.Text = "Plant";
            // 
            // txtSONumber
            // 
            this.txtSONumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSONumber.Location = new System.Drawing.Point(435, 41);
            this.txtSONumber.Name = "txtSONumber";
            this.txtSONumber.Size = new System.Drawing.Size(100, 24);
            this.txtSONumber.TabIndex = 10;
            this.txtSONumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSONumber_KeyPress);
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNumber.Location = new System.Drawing.Point(565, 45);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(64, 18);
            this.lblItemNumber.TabIndex = 11;
            this.lblItemNumber.Text = "Item No.";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo.Location = new System.Drawing.Point(636, 44);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(100, 24);
            this.txtItemNo.TabIndex = 12;
            // 
            // lblMill
            // 
            this.lblMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMill.Location = new System.Drawing.Point(39, 107);
            this.lblMill.Name = "lblMill";
            this.lblMill.Size = new System.Drawing.Size(88, 18);
            this.lblMill.TabIndex = 13;
            this.lblMill.Text = "Mill";
            // 
            // cmbMill
            // 
            this.cmbMill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMill.FormattingEnabled = true;
            this.cmbMill.Location = new System.Drawing.Point(128, 99);
            this.cmbMill.Name = "cmbMill";
            this.cmbMill.Size = new System.Drawing.Size(109, 26);
            this.cmbMill.TabIndex = 14;
            this.cmbMill.SelectedIndexChanged += new System.EventHandler(this.cmbMill_SelectedIndexChanged);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(344, 107);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(61, 18);
            this.lblTemp.TabIndex = 15;
            this.lblTemp.Text = "Temp C";
            // 
            // lblD10
            // 
            this.lblD10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD10.Location = new System.Drawing.Point(39, 141);
            this.lblD10.Name = "lblD10";
            this.lblD10.Size = new System.Drawing.Size(90, 21);
            this.lblD10.TabIndex = 17;
            this.lblD10.Text = "D10";
            // 
            // lblD98
            // 
            this.lblD98.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD98.Location = new System.Drawing.Point(763, 138);
            this.lblD98.Name = "lblD98";
            this.lblD98.Size = new System.Drawing.Size(37, 21);
            this.lblD98.TabIndex = 18;
            this.lblD98.Text = "D98";
            // 
            // lblD90
            // 
            this.lblD90.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD90.Location = new System.Drawing.Point(592, 138);
            this.lblD90.Name = "lblD90";
            this.lblD90.Size = new System.Drawing.Size(37, 21);
            this.lblD90.TabIndex = 19;
            this.lblD90.Text = "D90";
            // 
            // lblD50
            // 
            this.lblD50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD50.Location = new System.Drawing.Point(344, 138);
            this.lblD50.Name = "lblD50";
            this.lblD50.Size = new System.Drawing.Size(37, 21);
            this.lblD50.TabIndex = 20;
            this.lblD50.Text = "D50";
            // 
            // cmbSystem
            // 
            this.cmbSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSystem.FormattingEnabled = true;
            this.cmbSystem.Location = new System.Drawing.Point(128, 181);
            this.cmbSystem.Name = "cmbSystem";
            this.cmbSystem.Size = new System.Drawing.Size(109, 26);
            this.cmbSystem.TabIndex = 26;
            // 
            // lblSystem
            // 
            this.lblSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.Location = new System.Drawing.Point(39, 189);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(88, 18);
            this.lblSystem.TabIndex = 25;
            this.lblSystem.Text = "System";
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Location = new System.Drawing.Point(128, 227);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(253, 26);
            this.cmbShift.TabIndex = 28;
            // 
            // lblShift
            // 
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(39, 235);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(104, 18);
            this.lblShift.TabIndex = 27;
            this.lblShift.Text = "Shift";
            // 
            // mtxtD10
            // 
            this.mtxtD10.BeepOnError = true;
            this.mtxtD10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtD10.Location = new System.Drawing.Point(128, 141);
            this.mtxtD10.Mask = "00.00";
            this.mtxtD10.Name = "mtxtD10";
            this.mtxtD10.Size = new System.Drawing.Size(109, 24);
            this.mtxtD10.TabIndex = 29;
            // 
            // mtxtD98
            // 
            this.mtxtD98.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtD98.Location = new System.Drawing.Point(818, 141);
            this.mtxtD98.Mask = "00.00";
            this.mtxtD98.Name = "mtxtD98";
            this.mtxtD98.Size = new System.Drawing.Size(100, 24);
            this.mtxtD98.TabIndex = 30;
            // 
            // mtxtD90
            // 
            this.mtxtD90.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtD90.Location = new System.Drawing.Point(636, 141);
            this.mtxtD90.Mask = "00.00";
            this.mtxtD90.Name = "mtxtD90";
            this.mtxtD90.Size = new System.Drawing.Size(100, 24);
            this.mtxtD90.TabIndex = 31;
            // 
            // mtxtD50
            // 
            this.mtxtD50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtD50.Location = new System.Drawing.Point(435, 141);
            this.mtxtD50.Mask = "00.00";
            this.mtxtD50.Name = "mtxtD50";
            this.mtxtD50.Size = new System.Drawing.Size(100, 24);
            this.mtxtD50.TabIndex = 32;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(500, 227);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(208, 26);
            this.cmbCategory.TabIndex = 34;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(421, 235);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 18);
            this.lblCategory.TabIndex = 33;
            this.lblCategory.Text = "Catergory";
            // 
            // cmbRunCode
            // 
            this.cmbRunCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRunCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRunCode.FormattingEnabled = true;
            this.cmbRunCode.Location = new System.Drawing.Point(128, 273);
            this.cmbRunCode.Name = "cmbRunCode";
            this.cmbRunCode.Size = new System.Drawing.Size(253, 26);
            this.cmbRunCode.TabIndex = 36;
            // 
            // lblRunCode
            // 
            this.lblRunCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunCode.Location = new System.Drawing.Point(39, 281);
            this.lblRunCode.Name = "lblRunCode";
            this.lblRunCode.Size = new System.Drawing.Size(52, 18);
            this.lblRunCode.TabIndex = 35;
            this.lblRunCode.Text = "Run Code";
            // 
            // lblStartTime
            // 
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(36, 333);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(93, 24);
            this.lblStartTime.TabIndex = 39;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblStopTime
            // 
            this.lblStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopTime.Location = new System.Drawing.Point(320, 331);
            this.lblStopTime.Name = "lblStopTime";
            this.lblStopTime.Size = new System.Drawing.Size(85, 24);
            this.lblStopTime.TabIndex = 41;
            this.lblStopTime.Text = "Stop Time";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(616, 333);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 43;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(708, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rtxtMemo
            // 
            this.rtxtMemo.Location = new System.Drawing.Point(789, 181);
            this.rtxtMemo.Name = "rtxtMemo";
            this.rtxtMemo.Size = new System.Drawing.Size(335, 144);
            this.rtxtMemo.TabIndex = 45;
            this.rtxtMemo.Text = "";
            // 
            // lblMemo
            // 
            this.lblMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemo.Location = new System.Drawing.Point(728, 189);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(55, 18);
            this.lblMemo.TabIndex = 46;
            this.lblMemo.Text = "Memo";
            // 
            // dgvMillUtil
            // 
            this.dgvMillUtil.AllowUserToAddRows = false;
            this.dgvMillUtil.AllowUserToDeleteRows = false;
            this.dgvMillUtil.AllowUserToOrderColumns = true;
            this.dgvMillUtil.AutoGenerateColumns = false;
            this.dgvMillUtil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMillUtil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcmbRun_Code,
            this.sfplantkeyDataGridViewTextBoxColumn,
            this.createddateDataGridViewTextBoxColumn,
            this.modifieddateDataGridViewTextBoxColumn,
            this.createdbyDataGridViewTextBoxColumn,
            this.modifiedbyDataGridViewTextBoxColumn,
            this.millsUtilizationIDDataGridViewTextBoxColumn,
            this.System_Column,
            this.Mill_ID,
            this.Mill_Hours_Booked,
            this.Run_Code,
            this.startTimeDataGridViewTextBoxColumn,
            this.stopTimeDataGridViewTextBoxColumn,
            this.memoDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.Shift_Category,
            this.milltempDataGridViewTextBoxColumn,
            this.d10DataGridViewTextBoxColumn,
            this.d50DataGridViewTextBoxColumn,
            this.d90DataGridViewTextBoxColumn,
            this.d98DataGridViewTextBoxColumn,
            this.itemNumberDataGridViewTextBoxColumn,
            this.sauserkeyDataGridViewTextBoxColumn,
            this.shiftStartDateDataGridViewTextBoxColumn,
            this.shiftStartTimeDataGridViewTextBoxColumn,
            this.shiftStopTimeDataGridViewTextBoxColumn,
            this.sONumberDataGridViewTextBoxColumn});
            this.dgvMillUtil.DataSource = this.millMillsUtilizationBindingSource;
            this.dgvMillUtil.Location = new System.Drawing.Point(17, 396);
            this.dgvMillUtil.Name = "dgvMillUtil";
            this.dgvMillUtil.Size = new System.Drawing.Size(1107, 238);
            this.dgvMillUtil.TabIndex = 47;
            this.dgvMillUtil.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMillUtil_CellContentClick);
            this.dgvMillUtil.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMillUtil_CellEndEdit);
            this.dgvMillUtil.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMillUtil_CellLeave);
            this.dgvMillUtil.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvMillUtil_EditingControlShowing);
            // 
            // millMillsUtilizationBindingSource
            // 
            this.millMillsUtilizationBindingSource.DataSource = typeof(Mill_Project.mill_Mills_Utilization);
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(964, 2);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(202, 23);
            this.lblUserName.TabIndex = 48;
            this.lblUserName.Text = "label1";
            // 
            // btnMillMaint
            // 
            this.btnMillMaint.Enabled = false;
            this.btnMillMaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMillMaint.Location = new System.Drawing.Point(789, 334);
            this.btnMillMaint.Name = "btnMillMaint";
            this.btnMillMaint.Size = new System.Drawing.Size(105, 56);
            this.btnMillMaint.TabIndex = 49;
            this.btnMillMaint.Text = "Mill Maintenance";
            this.btnMillMaint.UseVisualStyleBackColor = true;
            this.btnMillMaint.Visible = false;
            this.btnMillMaint.Click += new System.EventHandler(this.btnMillMaint_Click);
            // 
            // dtStart
            // 
            this.dtStart.CustomFormat = "MM/dd/yyyy HH:mm tt";
            this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStart.Location = new System.Drawing.Point(128, 331);
            this.dtStart.Name = "dtStart";
            this.dtStart.ShowUpDown = true;
            this.dtStart.Size = new System.Drawing.Size(186, 26);
            this.dtStart.TabIndex = 50;
            // 
            // dtStop
            // 
            this.dtStop.CustomFormat = "MM/dd/yyyy HH:mm tt";
            this.dtStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStop.Location = new System.Drawing.Point(411, 327);
            this.dtStop.Name = "dtStop";
            this.dtStop.ShowUpDown = true;
            this.dtStop.Size = new System.Drawing.Size(186, 26);
            this.dtStop.TabIndex = 51;
            // 
            // mtxtTemp
            // 
            this.mtxtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtTemp.Location = new System.Drawing.Point(435, 104);
            this.mtxtTemp.Mask = "00.0";
            this.mtxtTemp.Name = "mtxtTemp";
            this.mtxtTemp.Size = new System.Drawing.Size(100, 24);
            this.mtxtTemp.TabIndex = 52;
            // 
            // btnSysMaint
            // 
            this.btnSysMaint.Enabled = false;
            this.btnSysMaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSysMaint.Location = new System.Drawing.Point(900, 334);
            this.btnSysMaint.Name = "btnSysMaint";
            this.btnSysMaint.Size = new System.Drawing.Size(105, 56);
            this.btnSysMaint.TabIndex = 53;
            this.btnSysMaint.Text = "System Maintenance";
            this.btnSysMaint.UseVisualStyleBackColor = true;
            this.btnSysMaint.Visible = false;
            this.btnSysMaint.Click += new System.EventHandler(this.btnSysMaint_Click);
            // 
            // millStoppageReasonsBindingSource1
            // 
            this.millStoppageReasonsBindingSource1.DataSource = typeof(Mill_Project.mill_Stoppage_Reasons);
            // 
            // millStoppageReasonsBindingSource
            // 
            this.millStoppageReasonsBindingSource.DataSource = typeof(Mill_Project.mill_Stoppage_Reasons);
            // 
            // dgvcmbRun_Code
            // 
            this.dgvcmbRun_Code.DataPropertyName = "gl_cmp_key";
            this.dgvcmbRun_Code.HeaderText = "gl_cmp_key";
            this.dgvcmbRun_Code.Name = "dgvcmbRun_Code";
            this.dgvcmbRun_Code.Visible = false;
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
            // millsUtilizationIDDataGridViewTextBoxColumn
            // 
            this.millsUtilizationIDDataGridViewTextBoxColumn.DataPropertyName = "Mills_Utilization_ID";
            this.millsUtilizationIDDataGridViewTextBoxColumn.HeaderText = "Mills_Utilization_ID";
            this.millsUtilizationIDDataGridViewTextBoxColumn.Name = "millsUtilizationIDDataGridViewTextBoxColumn";
            this.millsUtilizationIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // System_Column
            // 
            this.System_Column.DataPropertyName = "System";
            this.System_Column.HeaderText = "System";
            this.System_Column.Name = "System_Column";
            this.System_Column.ReadOnly = true;
            this.System_Column.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Mill_ID
            // 
            this.Mill_ID.DataPropertyName = "Mill_ID";
            this.Mill_ID.HeaderText = "Mill_ID";
            this.Mill_ID.Name = "Mill_ID";
            this.Mill_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mill_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Mill_Hours_Booked
            // 
            this.Mill_Hours_Booked.DataPropertyName = "Mill_Hours_Booked";
            this.Mill_Hours_Booked.HeaderText = "Mill_Hours_Booked";
            this.Mill_Hours_Booked.Name = "Mill_Hours_Booked";
            this.Mill_Hours_Booked.ReadOnly = true;
            // 
            // Run_Code
            // 
            this.Run_Code.DataPropertyName = "Run_Code";
            this.Run_Code.HeaderText = "Run_Code";
            this.Run_Code.Name = "Run_Code";
            this.Run_Code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Run_Code.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "Start_Time";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // stopTimeDataGridViewTextBoxColumn
            // 
            this.stopTimeDataGridViewTextBoxColumn.DataPropertyName = "Stop_Time";
            this.stopTimeDataGridViewTextBoxColumn.HeaderText = "Stop_Time";
            this.stopTimeDataGridViewTextBoxColumn.Name = "stopTimeDataGridViewTextBoxColumn";
            this.stopTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.stopTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // memoDataGridViewTextBoxColumn
            // 
            this.memoDataGridViewTextBoxColumn.DataPropertyName = "Memo";
            this.memoDataGridViewTextBoxColumn.HeaderText = "Memo";
            this.memoDataGridViewTextBoxColumn.Name = "memoDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "Shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Shift";
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Shift_Category
            // 
            this.Shift_Category.DataPropertyName = "Shift_Category";
            this.Shift_Category.HeaderText = "Shift_Category";
            this.Shift_Category.Name = "Shift_Category";
            this.Shift_Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Shift_Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // milltempDataGridViewTextBoxColumn
            // 
            this.milltempDataGridViewTextBoxColumn.DataPropertyName = "Mill_temp";
            this.milltempDataGridViewTextBoxColumn.HeaderText = "Mill_temp";
            this.milltempDataGridViewTextBoxColumn.MaxInputLength = 6;
            this.milltempDataGridViewTextBoxColumn.Name = "milltempDataGridViewTextBoxColumn";
            // 
            // d10DataGridViewTextBoxColumn
            // 
            this.d10DataGridViewTextBoxColumn.DataPropertyName = "D10";
            this.d10DataGridViewTextBoxColumn.HeaderText = "D10";
            this.d10DataGridViewTextBoxColumn.MaxInputLength = 5;
            this.d10DataGridViewTextBoxColumn.Name = "d10DataGridViewTextBoxColumn";
            // 
            // d50DataGridViewTextBoxColumn
            // 
            this.d50DataGridViewTextBoxColumn.DataPropertyName = "D50";
            this.d50DataGridViewTextBoxColumn.HeaderText = "D50";
            this.d50DataGridViewTextBoxColumn.MaxInputLength = 5;
            this.d50DataGridViewTextBoxColumn.Name = "d50DataGridViewTextBoxColumn";
            // 
            // d90DataGridViewTextBoxColumn
            // 
            this.d90DataGridViewTextBoxColumn.DataPropertyName = "D90";
            this.d90DataGridViewTextBoxColumn.HeaderText = "D90";
            this.d90DataGridViewTextBoxColumn.MaxInputLength = 5;
            this.d90DataGridViewTextBoxColumn.Name = "d90DataGridViewTextBoxColumn";
            // 
            // d98DataGridViewTextBoxColumn
            // 
            this.d98DataGridViewTextBoxColumn.DataPropertyName = "D98";
            this.d98DataGridViewTextBoxColumn.HeaderText = "D98";
            this.d98DataGridViewTextBoxColumn.MaxInputLength = 5;
            this.d98DataGridViewTextBoxColumn.Name = "d98DataGridViewTextBoxColumn";
            // 
            // itemNumberDataGridViewTextBoxColumn
            // 
            this.itemNumberDataGridViewTextBoxColumn.DataPropertyName = "Item_Number";
            this.itemNumberDataGridViewTextBoxColumn.HeaderText = "Item_Number";
            this.itemNumberDataGridViewTextBoxColumn.Name = "itemNumberDataGridViewTextBoxColumn";
            // 
            // sauserkeyDataGridViewTextBoxColumn
            // 
            this.sauserkeyDataGridViewTextBoxColumn.DataPropertyName = "sa_user_key";
            this.sauserkeyDataGridViewTextBoxColumn.HeaderText = "sa_user_key";
            this.sauserkeyDataGridViewTextBoxColumn.Name = "sauserkeyDataGridViewTextBoxColumn";
            // 
            // shiftStartDateDataGridViewTextBoxColumn
            // 
            this.shiftStartDateDataGridViewTextBoxColumn.DataPropertyName = "Shift_Start_Date";
            this.shiftStartDateDataGridViewTextBoxColumn.HeaderText = "Shift_Start_Date";
            this.shiftStartDateDataGridViewTextBoxColumn.Name = "shiftStartDateDataGridViewTextBoxColumn";
            this.shiftStartDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // shiftStartTimeDataGridViewTextBoxColumn
            // 
            this.shiftStartTimeDataGridViewTextBoxColumn.DataPropertyName = "Shift_Start_Time";
            this.shiftStartTimeDataGridViewTextBoxColumn.HeaderText = "Shift_Start_Time";
            this.shiftStartTimeDataGridViewTextBoxColumn.Name = "shiftStartTimeDataGridViewTextBoxColumn";
            this.shiftStartTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // shiftStopTimeDataGridViewTextBoxColumn
            // 
            this.shiftStopTimeDataGridViewTextBoxColumn.DataPropertyName = "Shift_Stop_Time";
            this.shiftStopTimeDataGridViewTextBoxColumn.HeaderText = "Shift_Stop_Time";
            this.shiftStopTimeDataGridViewTextBoxColumn.Name = "shiftStopTimeDataGridViewTextBoxColumn";
            this.shiftStopTimeDataGridViewTextBoxColumn.Visible = false;
            // 
            // sONumberDataGridViewTextBoxColumn
            // 
            this.sONumberDataGridViewTextBoxColumn.DataPropertyName = "SO_Number";
            this.sONumberDataGridViewTextBoxColumn.HeaderText = "SO_Number";
            this.sONumberDataGridViewTextBoxColumn.Name = "sONumberDataGridViewTextBoxColumn";
            this.sONumberDataGridViewTextBoxColumn.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 657);
            this.Controls.Add(this.btnSysMaint);
            this.Controls.Add(this.mtxtTemp);
            this.Controls.Add(this.dtStop);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.btnMillMaint);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.dgvMillUtil);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.rtxtMemo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblStopTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.cmbRunCode);
            this.Controls.Add(this.lblRunCode);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.mtxtD50);
            this.Controls.Add(this.mtxtD90);
            this.Controls.Add(this.mtxtD98);
            this.Controls.Add(this.mtxtD10);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.cmbSystem);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.lblD50);
            this.Controls.Add(this.lblD90);
            this.Controls.Add(this.lblD98);
            this.Controls.Add(this.lblD10);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.cmbMill);
            this.Controls.Add(this.lblMill);
            this.Controls.Add(this.txtItemNo);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.txtSONumber);
            this.Controls.Add(this.lblPlant);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbPlant);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.lblSONumber);
            this.Controls.Add(this.lblShiftStart);
            this.Controls.Add(this.dtmShiftStart);
            this.Controls.Add(this.lblFormTitle);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Mill Utilization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMillUtil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millMillsUtilizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStoppageReasonsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.millStoppageReasonsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.DateTimePicker dtmShiftStart;
        private System.Windows.Forms.Label lblShiftStart;
        private System.Windows.Forms.Label lblSONumber;
        private System.Windows.Forms.ComboBox cmbPlant;
        public System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblPlant;
        private System.Windows.Forms.TextBox txtSONumber;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label lblMill;
        private System.Windows.Forms.ComboBox cmbMill;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblD10;
        private System.Windows.Forms.Label lblD98;
        private System.Windows.Forms.Label lblD90;
        private System.Windows.Forms.Label lblD50;
        private System.Windows.Forms.ComboBox cmbSystem;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.MaskedTextBox mtxtD10;
        private System.Windows.Forms.MaskedTextBox mtxtD98;
        private System.Windows.Forms.MaskedTextBox mtxtD90;
        private System.Windows.Forms.MaskedTextBox mtxtD50;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbRunCode;
        private System.Windows.Forms.Label lblRunCode;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblStopTime;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox rtxtMemo;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.DataGridView dgvMillUtil;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnMillMaint;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.DateTimePicker dtStop;
        private System.Windows.Forms.ToolTip ttD10;
        private System.Windows.Forms.MaskedTextBox mtxtTemp;
        private System.Windows.Forms.ToolTip ttD50;
        private System.Windows.Forms.ToolTip ttD90;
        private System.Windows.Forms.ToolTip ttD98;
        private System.Windows.Forms.ToolTip ttTemp;
        private System.Windows.Forms.ToolTip ttTime;
        private System.Windows.Forms.ToolTip tt24;
        private System.Windows.Forms.BindingSource millMillsUtilizationBindingSource;
        private System.Windows.Forms.ToolTip ttCategory;
        private System.Windows.Forms.BindingSource millStoppageReasonsBindingSource1;
        private System.Windows.Forms.BindingSource millStoppageReasonsBindingSource;
        private System.Windows.Forms.ToolTip ttDuplicateMillShift;
        private System.Windows.Forms.Button btnSysMaint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcmbRun_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfplantkeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifieddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedbyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millsUtilizationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn System_Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mill_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mill_Hours_Booked;
        private System.Windows.Forms.DataGridViewComboBoxColumn Run_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Shift_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn milltempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d10DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d50DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d90DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn d98DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sauserkeyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftStartDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftStopTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONumberDataGridViewTextBoxColumn;
    }
}

