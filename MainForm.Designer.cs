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
            this.lblShiftStart.Location = new System.Drawing.Point(46, 45);
            this.lblShiftStart.Name = "lblShiftStart";
            this.lblShiftStart.Size = new System.Drawing.Size(76, 20);
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
            this.lblMill.AutoSize = true;
            this.lblMill.Location = new System.Drawing.Point(49, 103);
            this.lblMill.Name = "lblMill";
            this.lblMill.Size = new System.Drawing.Size(35, 13);
            this.lblMill.TabIndex = 13;
            this.lblMill.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 560);
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
    }
}

