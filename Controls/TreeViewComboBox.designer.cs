namespace CustomControls
{
    partial class ucTreeViewComboBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTreeViewComboBox));
            this.textBox = new System.Windows.Forms.TextBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnExDropDown = new CustomControls.ButtonEx();
            this.ilItems = new System.Windows.Forms.ImageList(this.components);
            this.treeviewList = new System.Windows.Forms.TreeView();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.White;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.textBox.HideSelection = false;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(255, 24);
            this.textBox.TabIndex = 1;
            this.textBox.Click += new System.EventHandler(this.imgComboButton_Click);
            this.textBox.DoubleClick += new System.EventHandler(this.imgComboButton_DoubleClick);
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Transparent;
            this.pnlControls.Controls.Add(this.textBox);
            this.pnlControls.Controls.Add(this.btnExDropDown);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(273, 24);
            this.pnlControls.TabIndex = 3;
            // 
            // btnExDropDown
            // 
            this.btnExDropDown.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExDropDown.Location = new System.Drawing.Point(255, 0);
            this.btnExDropDown.Name = "btnExDropDown";
            this.btnExDropDown.Size = new System.Drawing.Size(18, 24);
            this.btnExDropDown.TabIndex = 3;
            this.btnExDropDown.UseVisualStyleBackColor = true;
            this.btnExDropDown.Click += new System.EventHandler(this.imgComboButton_Click);
            // 
            // ilItems
            // 
            this.ilItems.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilItems.ImageStream")));
            this.ilItems.TransparentColor = System.Drawing.Color.Transparent;
            this.ilItems.Images.SetKeyName(0, "");
            this.ilItems.Images.SetKeyName(1, "");
            // 
            // treeviewList
            // 
            this.treeviewList.BackColor = System.Drawing.SystemColors.Window;
            this.treeviewList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeviewList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.treeviewList.HideSelection = false;
            this.treeviewList.ImageIndex = 0;
            this.treeviewList.ImageList = this.ilItems;
            this.treeviewList.Location = new System.Drawing.Point(0, 24);
            this.treeviewList.Name = "treeviewList";
            this.treeviewList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeviewList.RightToLeftLayout = true;
            this.treeviewList.SelectedImageIndex = 0;
            this.treeviewList.Size = new System.Drawing.Size(273, 213);
            this.treeviewList.TabIndex = 4;
            this.treeviewList.Visible = false;
            this.treeviewList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeviewList_MouseDoubleClick);
            this.treeviewList.MouseLeave += new System.EventHandler(this.ucTreeViewComboBox_MouseLeave);
            // 
            // ucTreeViewComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.treeviewList);
            this.Name = "ucTreeViewComboBox";
            this.Size = new System.Drawing.Size(273, 237);
            this.Load += new System.EventHandler(this.ucTreeViewComboBox_Load);
            this.SizeChanged += new System.EventHandler(this.ucTreeViewComboBox_SizeChanged);
            this.Leave += new System.EventHandler(this.ucTreeViewComboBox_MouseLeave);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        public System.Windows.Forms.TreeView treeviewList;
        public System.Windows.Forms.TextBox textBox;
        public System.Windows.Forms.ImageList ilItems;
        public ButtonEx btnExDropDown;
    }
}
