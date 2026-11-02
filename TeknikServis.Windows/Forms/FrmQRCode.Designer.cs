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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSerialNo = new DevExpress.XtraEditors.TextEdit();
            this.PictureEditQRCodeImage = new DevExpress.XtraEditors.PictureEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerialNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEditQRCodeImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SmpBtnCreateQR
            // 
            this.SmpBtnCreateQR.ImageOptions.SvgImage = global::TeknikServis.Windows.Properties.Resources.QRCode1;
            this.SmpBtnCreateQR.Location = new System.Drawing.Point(150, 149);
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
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Seri No: ";
            // 
            // TxtSerialNo
            // 
            this.TxtSerialNo.Location = new System.Drawing.Point(83, 109);
            this.TxtSerialNo.Name = "TxtSerialNo";
            this.TxtSerialNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.TxtSerialNo.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtSerialNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSerialNo.Properties.Appearance.Options.UseForeColor = true;
            this.TxtSerialNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSerialNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSerialNo.Properties.MaskSettings.Set("mask", "AAAAA");
            this.TxtSerialNo.Size = new System.Drawing.Size(296, 20);
            this.TxtSerialNo.TabIndex = 3;
            // 
            // PictureEditQRCodeImage
            // 
            this.PictureEditQRCodeImage.Location = new System.Drawing.Point(83, 202);
            this.PictureEditQRCodeImage.Name = "PictureEditQRCodeImage";
            this.PictureEditQRCodeImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureEditQRCodeImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PictureEditQRCodeImage.Size = new System.Drawing.Size(296, 249);
            this.PictureEditQRCodeImage.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(83, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 1);
            this.panel1.TabIndex = 4;
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
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.SmpBtnCreateQR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQRCode";
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
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.Panel panel1;
    }
}