namespace TeknikServis.Windows.Forms
{
    partial class FrmFaultDetails
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SmpBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtSerialNo = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.PcClose = new DevExpress.XtraEditors.PictureEdit();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TxtDate = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.ComboStatusDetail = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerialNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcClose.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboStatusDetail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(70, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(300, 31);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Arızalı Ürün Kaydı Açıklama";
            // 
            // SmpBtnUpdate
            // 
            this.SmpBtnUpdate.ImageOptions.Image = global::TeknikServis.Windows.Properties.Resources.apply_32x32;
            this.SmpBtnUpdate.Location = new System.Drawing.Point(139, 472);
            this.SmpBtnUpdate.Name = "SmpBtnUpdate";
            this.SmpBtnUpdate.Size = new System.Drawing.Size(143, 36);
            this.SmpBtnUpdate.TabIndex = 7;
            this.SmpBtnUpdate.Text = "Güncelle";
            this.SmpBtnUpdate.Click += new System.EventHandler(this.SmpBtnUpdate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(50, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 3);
            this.panel3.TabIndex = 55;
            // 
            // TxtSerialNo
            // 
            this.TxtSerialNo.EditValue = "Seri No.";
            this.TxtSerialNo.Location = new System.Drawing.Point(50, 132);
            this.TxtSerialNo.Name = "TxtSerialNo";
            this.TxtSerialNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtSerialNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSerialNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtSerialNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSerialNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSerialNo.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSerialNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSerialNo.Size = new System.Drawing.Size(358, 32);
            this.TxtSerialNo.TabIndex = 53;
            this.TxtSerialNo.Click += new System.EventHandler(this.TxtSerialNo_Click);
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = global::TeknikServis.Windows.Properties.Resources.PartyLeader;
            this.pictureEdit3.Location = new System.Drawing.Point(12, 129);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit3.TabIndex = 54;
            // 
            // PcClose
            // 
            this.PcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcClose.EditValue = global::TeknikServis.Windows.Properties.Resources.Cancel;
            this.PcClose.Location = new System.Drawing.Point(392, 2);
            this.PcClose.Name = "PcClose";
            this.PcClose.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PcClose.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.PcClose.Properties.Appearance.Options.UseBackColor = true;
            this.PcClose.Properties.Appearance.Options.UseForeColor = true;
            this.PcClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PcClose.Size = new System.Drawing.Size(32, 32);
            this.PcClose.TabIndex = 66;
            this.PcClose.Click += new System.EventHandler(this.PcClose_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(50, 238);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(358, 3);
            this.panel4.TabIndex = 69;
            // 
            // TxtDate
            // 
            this.TxtDate.EditValue = "Tarih";
            this.TxtDate.Location = new System.Drawing.Point(50, 200);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtDate.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtDate.Properties.Appearance.Options.UseBackColor = true;
            this.TxtDate.Properties.Appearance.Options.UseFont = true;
            this.TxtDate.Properties.Appearance.Options.UseForeColor = true;
            this.TxtDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.TxtDate.Properties.MaskSettings.Set("mask", "d");
            this.TxtDate.Size = new System.Drawing.Size(358, 32);
            this.TxtDate.TabIndex = 67;
            this.TxtDate.Click += new System.EventHandler(this.TxtDate_Click);
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = global::TeknikServis.Windows.Properties.Resources.DateTime;
            this.pictureEdit4.Location = new System.Drawing.Point(12, 202);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit4.TabIndex = 68;
            // 
            // TxtDescription
            // 
            this.TxtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.ForeColor = System.Drawing.Color.White;
            this.TxtDescription.Location = new System.Drawing.Point(12, 344);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(396, 93);
            this.TxtDescription.TabIndex = 70;
            this.TxtDescription.Text = "Arıza Detayları";
            this.TxtDescription.Click += new System.EventHandler(this.TxtDescription_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 443);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 3);
            this.panel1.TabIndex = 69;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(50, 309);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 3);
            this.panel5.TabIndex = 72;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::TeknikServis.Windows.Properties.Resources.Category;
            this.pictureEdit1.Location = new System.Drawing.Point(12, 273);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(32, 32);
            this.pictureEdit1.TabIndex = 71;
            // 
            // ComboStatusDetail
            // 
            this.ComboStatusDetail.EditValue = "--- Lütfen Seçiniz ---";
            this.ComboStatusDetail.Location = new System.Drawing.Point(50, 269);
            this.ComboStatusDetail.Name = "ComboStatusDetail";
            this.ComboStatusDetail.Properties.AdvancedModeOptions.LabelAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ComboStatusDetail.Properties.AdvancedModeOptions.LabelAppearance.ForeColor = System.Drawing.Color.White;
            this.ComboStatusDetail.Properties.AdvancedModeOptions.LabelAppearance.Options.UseBackColor = true;
            this.ComboStatusDetail.Properties.AdvancedModeOptions.LabelAppearance.Options.UseForeColor = true;
            this.ComboStatusDetail.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.White;
            this.ComboStatusDetail.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ComboStatusDetail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ComboStatusDetail.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ComboStatusDetail.Properties.Appearance.Options.UseBackColor = true;
            this.ComboStatusDetail.Properties.Appearance.Options.UseFont = true;
            this.ComboStatusDetail.Properties.Appearance.Options.UseForeColor = true;
            this.ComboStatusDetail.Properties.AppearanceDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ComboStatusDetail.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.White;
            this.ComboStatusDetail.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.ComboStatusDetail.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.ComboStatusDetail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.ComboStatusDetail.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboStatusDetail.Properties.Items.AddRange(new object[] {
            "Fiyat Verlidi",
            "İptal Edlidi",
            "Mesaj Bekliyor",
            "Parça Bekliyor",
            "Ürün Kaydoldu"});
            this.ComboStatusDetail.Properties.Sorted = true;
            this.ComboStatusDetail.Size = new System.Drawing.Size(358, 32);
            this.ComboStatusDetail.TabIndex = 73;
            this.ComboStatusDetail.Click += new System.EventHandler(this.ComboStatusDetail_Click);
            // 
            // FrmFaultDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(426, 534);
            this.Controls.Add(this.ComboStatusDetail);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.PcClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtSerialNo);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.SmpBtnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFaultDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFaultDetails";
            this.Load += new System.EventHandler(this.FrmFaultDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerialNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcClose.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboStatusDetail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SmpBtnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit TxtSerialNo;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit PcClose;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.TextEdit TxtDate;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit ComboStatusDetail;
    }
}