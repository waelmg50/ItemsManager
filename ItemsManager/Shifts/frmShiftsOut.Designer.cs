namespace ItemsManager.Shifts
{
    partial class frmShiftsOut
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
            this.pnlControls = new System.Windows.Forms.Panel();
            this.txtnCashOut = new CustomControls.NumericTextBox();
            this.lblCashOut = new System.Windows.Forms.Label();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.btnCloseShift = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.txtnCashOut);
            this.pnlControls.Controls.Add(this.lblCashOut);
            this.pnlControls.Controls.Add(this.dtpDateOut);
            this.pnlControls.Controls.Add(this.lblDateOut);
            this.pnlControls.Controls.Add(this.btnCloseShift);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(351, 100);
            this.pnlControls.TabIndex = 8;
            // 
            // txtnCashOut
            // 
            this.txtnCashOut.IsInt = false;
            this.txtnCashOut.Location = new System.Drawing.Point(149, 39);
            this.txtnCashOut.MaxLength = 7;
            this.txtnCashOut.Name = "txtnCashOut";
            this.txtnCashOut.Size = new System.Drawing.Size(74, 20);
            this.txtnCashOut.TabIndex = 32;
            this.txtnCashOut.Tag = "1";
            // 
            // lblCashOut
            // 
            this.lblCashOut.AutoSize = true;
            this.lblCashOut.Location = new System.Drawing.Point(247, 39);
            this.lblCashOut.Name = "lblCashOut";
            this.lblCashOut.Size = new System.Drawing.Size(72, 13);
            this.lblCashOut.TabIndex = 31;
            this.lblCashOut.Text = "قيمة الصندوق";
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.CustomFormat = "dddd dd/MM/yyyy -- t ss:mm:hh";
            this.dtpDateOut.Enabled = false;
            this.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOut.Location = new System.Drawing.Point(27, 15);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.RightToLeftLayout = true;
            this.dtpDateOut.Size = new System.Drawing.Size(196, 20);
            this.dtpDateOut.TabIndex = 6;
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDateOut.Location = new System.Drawing.Point(229, 15);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(94, 13);
            this.lblDateOut.TabIndex = 1;
            this.lblDateOut.Text = "تاريخ ووقت الإغلاق";
            // 
            // btnCloseShift
            // 
            this.btnCloseShift.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCloseShift.Location = new System.Drawing.Point(130, 63);
            this.btnCloseShift.Name = "btnCloseShift";
            this.btnCloseShift.Size = new System.Drawing.Size(90, 23);
            this.btnCloseShift.TabIndex = 3;
            this.btnCloseShift.Text = "إغلاق الوردية";
            this.btnCloseShift.Click += new System.EventHandler(this.btnCloseShift_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Enabled = true;
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // frmShiftsOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(351, 100);
            this.Controls.Add(this.pnlControls);
            this.Name = "frmShiftsOut";
            this.Text = "مدير الأصناف - إغلاق الوردية";
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private CustomControls.NumericTextBox txtnCashOut;
        private System.Windows.Forms.Label lblCashOut;
        private System.Windows.Forms.DateTimePicker dtpDateOut;
        private System.Windows.Forms.Label lblDateOut;
        private System.Windows.Forms.Button btnCloseShift;
        private System.Windows.Forms.Timer tmrTime;
    }
}
