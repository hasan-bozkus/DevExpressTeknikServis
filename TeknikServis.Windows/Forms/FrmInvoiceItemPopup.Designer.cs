namespace TeknikServis.Windows.Forms
{
    partial class FrmInvoiceItemPopup
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
            this.GrdInvoiceDetail = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GrdInvoice = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.PictureBtnPdf = new DevExpress.XtraEditors.PictureEdit();
            this.PictureBtnXlsx = new DevExpress.XtraEditors.PictureEdit();
            this.PictureBtnClose = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoiceDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBtnPdf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBtnXlsx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBtnClose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdInvoiceDetail
            // 
            this.GrdInvoiceDetail.Location = new System.Drawing.Point(1, 191);
            this.GrdInvoiceDetail.MainView = this.GrdViewItems;
            this.GrdInvoiceDetail.Name = "GrdInvoiceDetail";
            this.GrdInvoiceDetail.Size = new System.Drawing.Size(799, 258);
            this.GrdInvoiceDetail.TabIndex = 37;
            this.GrdInvoiceDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdInvoiceDetail;
            this.GrdViewItems.Name = "GrdViewItems";
            this.GrdViewItems.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.GrdInvoice);
            this.groupControl1.Location = new System.Drawing.Point(1, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(799, 138);
            this.groupControl1.TabIndex = 38;
            this.groupControl1.Text = "Fatura Bilgileri";
            // 
            // GrdInvoice
            // 
            this.GrdInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdInvoice.Location = new System.Drawing.Point(2, 28);
            this.GrdInvoice.MainView = this.gridView1;
            this.GrdInvoice.Name = "GrdInvoice";
            this.GrdInvoice.Size = new System.Drawing.Size(795, 108);
            this.GrdInvoice.TabIndex = 37;
            this.GrdInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.GridControl = this.GrdInvoice;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(57, 153);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 24);
            this.labelControl1.TabIndex = 39;
            this.labelControl1.Text = "Faturaya Ait Kalemler";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::TeknikServis.Windows.Properties.Resources.QuarentinedItems1;
            this.pictureEdit1.Location = new System.Drawing.Point(1, 140);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(50, 50);
            this.pictureEdit1.TabIndex = 40;
            // 
            // PictureBtnPdf
            // 
            this.PictureBtnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBtnPdf.EditValue = global::TeknikServis.Windows.Properties.Resources.documentpdf;
            this.PictureBtnPdf.Location = new System.Drawing.Point(636, 141);
            this.PictureBtnPdf.Name = "PictureBtnPdf";
            this.PictureBtnPdf.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PictureBtnPdf.Properties.Appearance.Options.UseBackColor = true;
            this.PictureBtnPdf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PictureBtnPdf.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureBtnPdf.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PictureBtnPdf.Size = new System.Drawing.Size(50, 50);
            this.PictureBtnPdf.TabIndex = 40;
            this.PictureBtnPdf.Click += new System.EventHandler(this.PictureBtnPdf_Click);
            // 
            // PictureBtnXlsx
            // 
            this.PictureBtnXlsx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBtnXlsx.EditValue = global::TeknikServis.Windows.Properties.Resources.exporttoxls;
            this.PictureBtnXlsx.Location = new System.Drawing.Point(692, 141);
            this.PictureBtnXlsx.Name = "PictureBtnXlsx";
            this.PictureBtnXlsx.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PictureBtnXlsx.Properties.Appearance.Options.UseBackColor = true;
            this.PictureBtnXlsx.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PictureBtnXlsx.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureBtnXlsx.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PictureBtnXlsx.Size = new System.Drawing.Size(50, 50);
            this.PictureBtnXlsx.TabIndex = 40;
            this.PictureBtnXlsx.Click += new System.EventHandler(this.PictureBtnXlsx_Click);
            // 
            // PictureBtnClose
            // 
            this.PictureBtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBtnClose.EditValue = global::TeknikServis.Windows.Properties.Resources.Cancel2;
            this.PictureBtnClose.Location = new System.Drawing.Point(748, 141);
            this.PictureBtnClose.Name = "PictureBtnClose";
            this.PictureBtnClose.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PictureBtnClose.Properties.Appearance.Options.UseBackColor = true;
            this.PictureBtnClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PictureBtnClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PictureBtnClose.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PictureBtnClose.Size = new System.Drawing.Size(50, 50);
            this.PictureBtnClose.TabIndex = 40;
            this.PictureBtnClose.Click += new System.EventHandler(this.PictureBtnClose_Click);
            // 
            // FrmInvoiceItemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PictureBtnClose);
            this.Controls.Add(this.PictureBtnXlsx);
            this.Controls.Add(this.PictureBtnPdf);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GrdInvoiceDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInvoiceItemPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInvoiceItemPopup";
            this.Load += new System.EventHandler(this.FrmInvoiceItemPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoiceDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBtnPdf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBtnXlsx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBtnClose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdInvoiceDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GrdInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit PictureBtnPdf;
        private DevExpress.XtraEditors.PictureEdit PictureBtnXlsx;
        private DevExpress.XtraEditors.PictureEdit PictureBtnClose;
    }
}