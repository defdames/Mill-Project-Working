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
            this.txtUserName = new System.Windows.Forms.TextBox();
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
            this.txtTemp = new System.Windows.Forms.TextBox();
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
            this.mtxtStartTime = new System.Windows.Forms.MaskedTextBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.mtxtStopTime = new System.Windows.Forms.MaskedTextBox();
            this.lblStopTime = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rtxtMemo = new System.Windows.Forms.RichTextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(964, 1);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(202, 20);
            this.txtUserName.TabIndex = 0;
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
            this.cmbPlant.FormattingEnabled = true;
            this.cmbPlant.Location = new System.Drawing.Point(964, 56);
            this.cmbPlant.Name = "cmbPlant";
            this.cmbPlant.Size = new System.Drawing.Size(202, 21);
            this.cmbPlant.TabIndex = 6;
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
            // txtTemp
            // 
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(435, 104);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 24);
            this.txtTemp.TabIndex = 16;
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
            this.lblD90.Location = new System.Drawing.Point(565, 138);
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
            this.mtxtD10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtD10.Location = new System.Drawing.Point(128, 141);
            this.mtxtD10.Mask = "0.00";
            this.mtxtD10.Name = "mtxtD10";
            this.mtxtD10.Size = new System.Drawing.Size(109, 24);
            this.mtxtD10.TabIndex = 29;
            // 
            // mtxtD98
            // 
            this.mtxtD98.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtD98.Location = new System.Drawing.Point(818, 141);
            this.mtxtD98.Mask = "0.00";
            this.mtxtD98.Name = "mtxtD98";
            this.mtxtD98.Size = new System.Drawing.Size(100, 24);
            this.mtxtD98.TabIndex = 30;
            // 
            // mtxtD90
            // 
            this.mtxtD90.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtD90.Location = new System.Drawing.Point(608, 141);
            this.mtxtD90.Mask = "0.00";
            this.mtxtD90.Name = "mtxtD90";
            this.mtxtD90.Size = new System.Drawing.Size(100, 24);
            this.mtxtD90.TabIndex = 31;
            // 
            // mtxtD50
            // 
            this.mtxtD50.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtD50.Location = new System.Drawing.Point(435, 141);
            this.mtxtD50.Mask = "0.00";
            this.mtxtD50.Name = "mtxtD50";
            this.mtxtD50.Size = new System.Drawing.Size(100, 24);
            this.mtxtD50.TabIndex = 32;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(500, 227);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(109, 26);
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
            // mtxtStartTime
            // 
            this.mtxtStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtStartTime.Location = new System.Drawing.Point(128, 333);
            this.mtxtStartTime.Mask = "00.00";
            this.mtxtStartTime.Name = "mtxtStartTime";
            this.mtxtStartTime.Size = new System.Drawing.Size(100, 24);
            this.mtxtStartTime.TabIndex = 40;
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
            // mtxtStopTime
            // 
            this.mtxtStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtStopTime.Location = new System.Drawing.Point(347, 333);
            this.mtxtStopTime.Mask = "00.00";
            this.mtxtStopTime.Name = "mtxtStopTime";
            this.mtxtStopTime.Size = new System.Drawing.Size(100, 24);
            this.mtxtStopTime.TabIndex = 42;
            // 
            // lblStopTime
            // 
            this.lblStopTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopTime.Location = new System.Drawing.Point(263, 333);
            this.lblStopTime.Name = "lblStopTime";
            this.lblStopTime.Size = new System.Drawing.Size(85, 24);
            this.lblStopTime.TabIndex = 41;
            this.lblStopTime.Text = "Stop Time";
            // 
            // btnPost
            // 
            this.btnPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(500, 333);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(75, 23);
            this.btnPost.TabIndex = 43;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(608, 334);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 395);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1085, 159);
            this.dataGridView1.TabIndex = 47;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMemo);
            this.Controls.Add(this.rtxtMemo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.mtxtStopTime);
            this.Controls.Add(this.lblStopTime);
            this.Controls.Add(this.mtxtStartTime);
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
            this.Controls.Add(this.txtTemp);
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
            this.Controls.Add(this.txtUserName);
            this.Name = "MainForm";
            this.Text = "Mill Utilization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
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
        private System.Windows.Forms.TextBox txtTemp;
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
        private System.Windows.Forms.MaskedTextBox mtxtStartTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.MaskedTextBox mtxtStopTime;
        private System.Windows.Forms.Label lblStopTime;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RichTextBox rtxtMemo;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

