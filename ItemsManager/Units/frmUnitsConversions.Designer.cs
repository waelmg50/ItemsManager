namespace ItemsManager.Units
{
    partial class frmUnitsConversions
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
            this.cmbToUnitID = new System.Windows.Forms.ComboBox();
            this.lblToUnitID = new System.Windows.Forms.Label();
            this.cmbFromUnitID = new System.Windows.Forms.ComboBox();
            this.lblFromUnitID = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtnQuantity = new CustomControls.NumericTextBox();
            this.lblConversionExample = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(255, 23);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.txtnQuantity);
            this.pnlControls.Controls.Add(this.lblQuantity);
            this.pnlControls.Controls.Add(this.cmbFromUnitID);
            this.pnlControls.Controls.Add(this.lblFromUnitID);
            this.pnlControls.Controls.Add(this.cmbToUnitID);
            this.pnlControls.Controls.Add(this.lblToUnitID);
            this.pnlControls.Size = new System.Drawing.Size(426, 176);
            this.pnlControls.Controls.SetChildIndex(this.txtID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblToUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbToUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblFromUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.cmbFromUnitID, 0);
            this.pnlControls.Controls.SetChildIndex(this.lblQuantity, 0);
            this.pnlControls.Controls.SetChildIndex(this.txtnQuantity, 0);
            // 
            // lblID
            // 
            this.lblID.Location = new System.Drawing.Point(332, 23);
            // 
            // cmbToUnitID
            // 
            this.cmbToUnitID.FormattingEnabled = true;
            this.cmbToUnitID.Location = new System.Drawing.Point(31, 96);
            this.cmbToUnitID.Name = "cmbToUnitID";
            this.cmbToUnitID.Size = new System.Drawing.Size(279, 21);
            this.cmbToUnitID.TabIndex = 8;
            this.cmbToUnitID.Tag = "1";
            this.cmbToUnitID.SelectedIndexChanged += new System.EventHandler(this.cmbFromUnitID_SelectedIndexChanged);
            // 
            // lblToUnitID
            // 
            this.lblToUnitID.AutoSize = true;
            this.lblToUnitID.Location = new System.Drawing.Point(332, 97);
            this.lblToUnitID.Name = "lblToUnitID";
            this.lblToUnitID.Size = new System.Drawing.Size(63, 13);
            this.lblToUnitID.TabIndex = 7;
            this.lblToUnitID.Text = "إلى الوحدة :";
            // 
            // cmbFromUnitID
            // 
            this.cmbFromUnitID.FormattingEnabled = true;
            this.cmbFromUnitID.Location = new System.Drawing.Point(31, 59);
            this.cmbFromUnitID.Name = "cmbFromUnitID";
            this.cmbFromUnitID.Size = new System.Drawing.Size(279, 21);
            this.cmbFromUnitID.TabIndex = 10;
            this.cmbFromUnitID.Tag = "1";
            this.cmbFromUnitID.SelectedIndexChanged += new System.EventHandler(this.cmbFromUnitID_SelectedIndexChanged);
            // 
            // lblFromUnitID
            // 
            this.lblFromUnitID.AutoSize = true;
            this.lblFromUnitID.Location = new System.Drawing.Point(335, 60);
            this.lblFromUnitID.Name = "lblFromUnitID";
            this.lblFromUnitID.Size = new System.Drawing.Size(60, 13);
            this.lblFromUnitID.TabIndex = 9;
            this.lblFromUnitID.Text = "من الوحدة :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(316, 134);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 13);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "معامل التحويل :";
            // 
            // txtnQuantity
            // 
            this.txtnQuantity.IsInt = false;
            this.txtnQuantity.Location = new System.Drawing.Point(31, 133);
            this.txtnQuantity.Name = "txtnQuantity";
            this.txtnQuantity.Size = new System.Drawing.Size(279, 20);
            this.txtnQuantity.TabIndex = 13;
            this.txtnQuantity.Tag = "1";
            this.txtnQuantity.TextChanged += new System.EventHandler(this.cmbFromUnitID_SelectedIndexChanged);
            // 
            // lblConversionExample
            // 
            this.lblConversionExample.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblConversionExample.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConversionExample.Location = new System.Drawing.Point(0, 201);
            this.lblConversionExample.Name = "lblConversionExample";
            this.lblConversionExample.Size = new System.Drawing.Size(426, 42);
            this.lblConversionExample.TabIndex = 15;
            this.lblConversionExample.Tag = "1";
            this.lblConversionExample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUnitsConversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(426, 243);
            this.Controls.Add(this.lblConversionExample);
            this.Name = "frmUnitsConversions";
            this.Text = "مدير الأصناف - تحويلات الوحدات";
            this.Load += new System.EventHandler(this.frmUnitsConversions_Load);
            this.Controls.SetChildIndex(this.lblConversionExample, 0);
            this.Controls.SetChildIndex(this.pnlControls, 0);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprvForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFromUnitID;
        private System.Windows.Forms.Label lblFromUnitID;
        private System.Windows.Forms.ComboBox cmbToUnitID;
        private System.Windows.Forms.Label lblToUnitID;
        private CustomControls.NumericTextBox txtnQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblConversionExample;
    }
}
