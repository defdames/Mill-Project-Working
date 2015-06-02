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
            this.lbl = new System.Windows.Forms.Label();
            this.cmb_Cmp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(882, 1);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(284, 20);
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
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(366, 47);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(95, 18);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "SO Number";
            // 
            // cmb_Cmp
            // 
            this.cmb_Cmp.FormattingEnabled = true;
            this.cmb_Cmp.Location = new System.Drawing.Point(882, 28);
            this.cmb_Cmp.Name = "cmb_Cmp";
            this.cmb_Cmp.Size = new System.Drawing.Size(284, 21);
            this.cmb_Cmp.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 560);
            this.Controls.Add(this.cmb_Cmp);
            this.Controls.Add(this.lbl);
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
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cmb_Cmp;
    }
}

