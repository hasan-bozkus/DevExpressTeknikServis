namespace TeknikServis.Windows.Forms
{
    partial class FrmNewDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewDepartment));
            this.SmpBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtDepartmentName = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SmpBtnSave
            // 
            this.SmpBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnSave.ImageOptions.Image")));
            this.SmpBtnSave.Location = new System.Drawing.Point(111, 97);
            this.SmpBtnSave.Name = "SmpBtnSave";
            this.SmpBtnSave.Size = new System.Drawing.Size(143, 36);
            this.SmpBtnSave.TabIndex = 30;
            this.SmpBtnSave.Text = "Kaydet";
            this.SmpBtnSave.Click += new System.EventHandler(this.SmpBtnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(89, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 3);
            this.panel1.TabIndex = 29;
            // 
            // TxtDepartmentName
            // 
            this.TxtDepartmentName.EditValue = "Departman Adı";
            this.TxtDepartmentName.Location = new System.Drawing.Point(89, 24);
            this.TxtDepartmentName.Name = "TxtDepartmentName";
            this.TxtDepartmentName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtDepartmentName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDepartmentName.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtDepartmentName.Properties.Appearance.Options.UseBackColor = true;
            this.TxtDepartmentName.Properties.Appearance.Options.UseFont = true;
            this.TxtDepartmentName.Properties.Appearance.Options.UseForeColor = true;
            this.TxtDepartmentName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtDepartmentName.Size = new System.Drawing.Size(177, 32);
            this.TxtDepartmentName.TabIndex = 28;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::TeknikServis.Windows.Properties.Resources.Sorting;
            this.pictureEdit1.Location = new System.Drawing.Point(51, 26);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit1.TabIndex = 27;
            // 
            // FrmNewDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(360, 157);
            this.Controls.Add(this.SmpBtnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtDepartmentName);
            this.Controls.Add(this.pictureEdit1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Departman";
            ((System.ComponentModel.ISupportInitialize)(this.TxtDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SmpBtnSave;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit TxtDepartmentName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}