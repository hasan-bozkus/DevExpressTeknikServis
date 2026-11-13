namespace TeknikServis.Windows.Forms
{
    partial class FrmQRCode
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
            this.SmpBtnCreateQR = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SmpBtnClose = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSerialNo = new DevExpress.XtraEditors.TextEdit();
            this.PictureEditQRCodeImage = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerialNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditQRCodeImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SmpBtnCreateQR
            // 
            this.SmpBtnCreateQR.ImageOptions.SvgImage = global::TeknikServis.Windows.Properties.Resources.QRCode1;
            this.SmpBtnCreateQR.Location = new System.Drawing.Point(12, 140);
            this.SmpBtnCreateQR.Name = "SmpBtnCreateQR";
            this.SmpBtnCreateQR.Size = new System.Drawing.Size(135, 47);
            this.SmpBtnCreateQR.TabIndex = 0;
            this.SmpBtnCreateQR.Text = "QR Oluştur";
            this.SmpBtnCreateQR.Click += new System.EventHandler(this.SmpBtnCreateQR_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(66, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(313, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Seri No İçin QR Kod Oluştur";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 1);
            this.panel1.TabIndex = 4;
            // 
            // SmpBtnClose
            // 
            this.SmpBtnClose.ImageOptions.SvgImage = global::TeknikServis.Windows.Properties.Resources.Cancel1;
            this.SmpBtnClose.Location = new System.Drawing.Point(307, 140);
            this.SmpBtnClose.Name = "SmpBtnClose";
            this.SmpBtnClose.Size = new System.Drawing.Size(135, 47);
            this.SmpBtnClose.TabIndex = 0;
            this.SmpBtnClose.Text = "Vazgeç";
            this.SmpBtnClose.Click += new System.EventHandler(this.SmpBtnClose_Click);
            // 
            // TxtSerialNo
            // 
            this.TxtSerialNo.EditValue = "Seri No.";
            this.TxtSerialNo.Location = new System.Drawing.Point(12, 97);
            this.TxtSerialNo.Name = "TxtSerialNo";
            this.TxtSerialNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtSerialNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.TxtSerialNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtSerialNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSerialNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSerialNo.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSerialNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSerialNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSerialNo.Properties.MaskSettings.Set("mask", "AAAAA");
            this.TxtSerialNo.Size = new System.Drawing.Size(430, 26);
            this.TxtSerialNo.TabIndex = 3;
            this.TxtSerialNo.Click += new System.EventHandler(this.TxtSerialNo_Click);
            // 
            // PictureEditQRCodeImage
            // 
            this.PictureEditQRCodeImage.Location = new System.Drawing.Point(12, 202);
            this.PictureEditQRCodeImage.Name = "PictureEditQRCodeImage";
            this.PictureEditQRCodeImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureEditQRCodeImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PictureEditQRCodeImage.Size = new System.Drawing.Size(430, 249);
            this.PictureEditQRCodeImage.TabIndex = 2;
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(454, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtSerialNo);
            this.Controls.Add(this.PictureEditQRCodeImage);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.SmpBtnClose);
            this.Controls.Add(this.SmpBtnCreateQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Kod";
            this.Load += new System.EventHandler(this.FrmQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerialNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditQRCodeImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SmpBtnCreateQR;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit PictureEditQRCodeImage;
        private DevExpress.XtraEditors.TextEdit TxtSerialNo;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton SmpBtnClose;
    }
}