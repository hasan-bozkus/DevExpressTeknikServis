namespace TeknikServis.Windows.Forms
{
    partial class FrmNewCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SmpBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.TxtCategoryName = new DevExpress.XtraEditors.TextEdit();
            this.PcClose = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCategoryName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(72, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 23;
            // 
            // SmpBtnSave
            // 
            this.SmpBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnSave.ImageOptions.Image")));
            this.SmpBtnSave.Location = new System.Drawing.Point(94, 144);
            this.SmpBtnSave.Name = "SmpBtnSave";
            this.SmpBtnSave.Size = new System.Drawing.Size(143, 36);
            this.SmpBtnSave.TabIndex = 26;
            this.SmpBtnSave.Text = "KAYDET";
            this.SmpBtnSave.Click += new System.EventHandler(this.SmpBtnSave_Click);
            // 
            // TxtCategoryName
            // 
            this.TxtCategoryName.EditValue = "Kategori Adı";
            this.TxtCategoryName.Location = new System.Drawing.Point(72, 71);
            this.TxtCategoryName.Name = "TxtCategoryName";
            this.TxtCategoryName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtCategoryName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtCategoryName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtCategoryName.Properties.Appearance.Options.UseBackColor = true;
            this.TxtCategoryName.Properties.Appearance.Options.UseFont = true;
            this.TxtCategoryName.Properties.Appearance.Options.UseForeColor = true;
            this.TxtCategoryName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtCategoryName.Size = new System.Drawing.Size(177, 32);
            this.TxtCategoryName.TabIndex = 22;
            // 
            // PcClose
            // 
            this.PcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcClose.EditValue = global::TeknikServis.Windows.Properties.Resources.Cancel;
            this.PcClose.Location = new System.Drawing.Point(282, 12);
            this.PcClose.Name = "PcClose";
            this.PcClose.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PcClose.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.PcClose.Properties.Appearance.Options.UseBackColor = true;
            this.PcClose.Properties.Appearance.Options.UseForeColor = true;
            this.PcClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PcClose.Size = new System.Drawing.Size(32, 32);
            this.PcClose.TabIndex = 21;
            this.PcClose.Click += new System.EventHandler(this.PcClose_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::TeknikServis.Windows.Properties.Resources.Sorting;
            this.pictureEdit1.Location = new System.Drawing.Point(34, 73);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit1.TabIndex = 21;
            // 
            // FrmNewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(326, 223);
            this.Controls.Add(this.SmpBtnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtCategoryName);
            this.Controls.Add(this.PcClose);
            this.Controls.Add(this.pictureEdit1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewCategory";
            ((System.ComponentModel.ISupportInitialize)(this.TxtCategoryName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SmpBtnSave;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtCategoryName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit PcClose;
    }
}