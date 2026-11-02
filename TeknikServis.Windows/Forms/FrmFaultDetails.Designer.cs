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
            this.RichTxtDescription = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDate = new DevExpress.XtraEditors.TextEdit();
            this.TxtSerialNo = new DevExpress.XtraEditors.TextEdit();
            this.SmpBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerialNo.Properties)).BeginInit();
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
            // RichTxtDescription
            // 
            this.RichTxtDescription.Location = new System.Drawing.Point(25, 312);
            this.RichTxtDescription.Name = "RichTxtDescription";
            this.RichTxtDescription.Size = new System.Drawing.Size(376, 96);
            this.RichTxtDescription.TabIndex = 9;
            this.RichTxtDescription.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 111);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 23);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Seri No.";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 269);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(208, 23);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Arızalı Ürün Kaydı Açıklama";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(25, 186);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 23);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Tarih";
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(25, 215);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.TxtDate.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TxtDate.Properties.MaskSettings.Set("mask", "d");
            this.TxtDate.Size = new System.Drawing.Size(376, 22);
            this.TxtDate.TabIndex = 10;
            // 
            // TxtSerialNo
            // 
            this.TxtSerialNo.Location = new System.Drawing.Point(25, 140);
            this.TxtSerialNo.Name = "TxtSerialNo";
            this.TxtSerialNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSerialNo.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.TxtSerialNo.Properties.MaskSettings.Set("mask", "AAAAA");
            this.TxtSerialNo.Properties.MaskSettings.Set("placeholder", '\0');
            this.TxtSerialNo.Properties.MaskSettings.Set("culture", null);
            this.TxtSerialNo.Size = new System.Drawing.Size(376, 22);
            this.TxtSerialNo.TabIndex = 10;
            // 
            // SmpBtnUpdate
            // 
            this.SmpBtnUpdate.ImageOptions.Image = global::TeknikServis.Windows.Properties.Resources.apply_32x32;
            this.SmpBtnUpdate.Location = new System.Drawing.Point(117, 453);
            this.SmpBtnUpdate.Name = "SmpBtnUpdate";
            this.SmpBtnUpdate.Size = new System.Drawing.Size(143, 36);
            this.SmpBtnUpdate.TabIndex = 7;
            this.SmpBtnUpdate.Text = "Güncelle";
            this.SmpBtnUpdate.Click += new System.EventHandler(this.SmpBtnUpdate_Click);
            // 
            // FrmFaultDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(426, 513);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtSerialNo);
            this.Controls.Add(this.RichTxtDescription);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.SmpBtnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFaultDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFaultDetails";
            this.Load += new System.EventHandler(this.FrmFaultDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerialNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SmpBtnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RichTextBox RichTxtDescription;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtSerialNo;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtDate;
    }
}