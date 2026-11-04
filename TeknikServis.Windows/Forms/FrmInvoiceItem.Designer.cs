namespace TeknikServis.Windows.Forms
{
    partial class FrmInvoiceItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoiceItem));
            this.GrdInvoiceItems = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TxtInvoiceItemId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SmpBtnList = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtProduct = new DevExpress.XtraEditors.TextEdit();
            this.GrpCtrlCurrentProcess = new DevExpress.XtraEditors.GroupControl();
            this.LblTextSeriesNumber = new DevExpress.XtraEditors.LabelControl();
            this.TxtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.TxtPrice = new DevExpress.XtraEditors.TextEdit();
            this.TxtAmount = new DevExpress.XtraEditors.TextEdit();
            this.TxtInvoice = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceItemId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlCurrentProcess)).BeginInit();
            this.GrpCtrlCurrentProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdInvoiceItems
            // 
            this.GrdInvoiceItems.Location = new System.Drawing.Point(2, 0);
            this.GrdInvoiceItems.MainView = this.GrdViewItems;
            this.GrdInvoiceItems.Name = "GrdInvoiceItems";
            this.GrdInvoiceItems.Size = new System.Drawing.Size(1020, 537);
            this.GrdInvoiceItems.TabIndex = 38;
            this.GrdInvoiceItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdInvoiceItems;
            this.GrdViewItems.Name = "GrdViewItems";
            this.GrdViewItems.OptionsView.ShowGroupPanel = false;
            // 
            // TxtInvoiceItemId
            // 
            this.TxtInvoiceItemId.Enabled = false;
            this.TxtInvoiceItemId.Location = new System.Drawing.Point(71, 45);
            this.TxtInvoiceItemId.Name = "TxtInvoiceItemId";
            this.TxtInvoiceItemId.Size = new System.Drawing.Size(257, 22);
            this.TxtInvoiceItemId.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "KALEM ID: ";
            // 
            // SmpBtnList
            // 
            this.SmpBtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnList.ImageOptions.Image")));
            this.SmpBtnList.Location = new System.Drawing.Point(86, 339);
            this.SmpBtnList.Name = "SmpBtnList";
            this.SmpBtnList.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnList.TabIndex = 9;
            this.SmpBtnList.Text = "LİSTELE";
            this.SmpBtnList.Click += new System.EventHandler(this.SmpBtnList_Click);
            // 
            // SmpBtnUpdate
            // 
            this.SmpBtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnUpdate.ImageOptions.Image")));
            this.SmpBtnUpdate.Location = new System.Drawing.Point(86, 301);
            this.SmpBtnUpdate.Name = "SmpBtnUpdate";
            this.SmpBtnUpdate.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnUpdate.TabIndex = 8;
            this.SmpBtnUpdate.Text = "GÜNCELLE";
            // 
            // SmpBtnRemove
            // 
            this.SmpBtnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnRemove.ImageOptions.Image")));
            this.SmpBtnRemove.Location = new System.Drawing.Point(86, 263);
            this.SmpBtnRemove.Name = "SmpBtnRemove";
            this.SmpBtnRemove.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnRemove.TabIndex = 7;
            this.SmpBtnRemove.Text = "SİL";
            // 
            // SmpBtnSave
            // 
            this.SmpBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnSave.ImageOptions.Image")));
            this.SmpBtnSave.Location = new System.Drawing.Point(86, 225);
            this.SmpBtnSave.Name = "SmpBtnSave";
            this.SmpBtnSave.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnSave.TabIndex = 6;
            this.SmpBtnSave.Text = "KAYDET";
            this.SmpBtnSave.Click += new System.EventHandler(this.SmpBtnSave_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 188);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 16);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "FATURA: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(19, 160);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "TUTAR: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "FİYAT: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(40, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ADET: ";
            // 
            // TxtProduct
            // 
            this.TxtProduct.Location = new System.Drawing.Point(71, 73);
            this.TxtProduct.Name = "TxtProduct";
            this.TxtProduct.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtProduct.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.TxtProduct.Properties.MaskSettings.Set("mask", "(1?[1-9])|([12][0-4])");
            this.TxtProduct.Size = new System.Drawing.Size(257, 22);
            this.TxtProduct.TabIndex = 1;
            // 
            // GrpCtrlCurrentProcess
            // 
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtInvoiceItemId);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl6);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnList);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnUpdate);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnRemove);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnSave);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl5);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl4);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl3);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl2);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtInvoice);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtAmount);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtPrice);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtQuantity);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtProduct);
            this.GrpCtrlCurrentProcess.Controls.Add(this.LblTextSeriesNumber);
            this.GrpCtrlCurrentProcess.Location = new System.Drawing.Point(1028, 0);
            this.GrpCtrlCurrentProcess.Name = "GrpCtrlCurrentProcess";
            this.GrpCtrlCurrentProcess.Size = new System.Drawing.Size(338, 537);
            this.GrpCtrlCurrentProcess.TabIndex = 39;
            this.GrpCtrlCurrentProcess.Text = "FATURA KALEM İŞLEMLERİ";
            // 
            // LblTextSeriesNumber
            // 
            this.LblTextSeriesNumber.Location = new System.Drawing.Point(27, 76);
            this.LblTextSeriesNumber.Name = "LblTextSeriesNumber";
            this.LblTextSeriesNumber.Size = new System.Drawing.Size(41, 16);
            this.LblTextSeriesNumber.TabIndex = 3;
            this.LblTextSeriesNumber.Text = "ÜRÜN: ";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(71, 101);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtQuantity.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.TxtQuantity.Properties.MaskSettings.Set("mask", "(1?[1-9])|([12][0-4])");
            this.TxtQuantity.Size = new System.Drawing.Size(257, 22);
            this.TxtQuantity.TabIndex = 2;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(71, 129);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtPrice.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.TxtPrice.Properties.MaskSettings.Set("mask", "(1?[1-9])|([12][0-4])");
            this.TxtPrice.Size = new System.Drawing.Size(257, 22);
            this.TxtPrice.TabIndex = 3;
            // 
            // TxtAmount
            // 
            this.TxtAmount.Location = new System.Drawing.Point(71, 157);
            this.TxtAmount.Name = "TxtAmount";
            this.TxtAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtAmount.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.TxtAmount.Properties.MaskSettings.Set("mask", "(1?[1-9])|([12][0-4])");
            this.TxtAmount.Size = new System.Drawing.Size(257, 22);
            this.TxtAmount.TabIndex = 4;
            // 
            // TxtInvoice
            // 
            this.TxtInvoice.Location = new System.Drawing.Point(71, 185);
            this.TxtInvoice.Name = "TxtInvoice";
            this.TxtInvoice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtInvoice.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.TxtInvoice.Properties.MaskSettings.Set("mask", "(1?[1-9])|([12][0-4])");
            this.TxtInvoice.Size = new System.Drawing.Size(257, 22);
            this.TxtInvoice.TabIndex = 5;
            // 
            // FrmInvoiceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.GrdInvoiceItems);
            this.Controls.Add(this.GrpCtrlCurrentProcess);
            this.Name = "FrmInvoiceItem";
            this.Text = "FrmInvoiceItem";
            this.Load += new System.EventHandler(this.FrmInvoiceItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceItemId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlCurrentProcess)).EndInit();
            this.GrpCtrlCurrentProcess.ResumeLayout(false);
            this.GrpCtrlCurrentProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdInvoiceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private DevExpress.XtraEditors.TextEdit TxtInvoiceItemId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton SmpBtnList;
        private DevExpress.XtraEditors.SimpleButton SmpBtnUpdate;
        private DevExpress.XtraEditors.SimpleButton SmpBtnRemove;
        private DevExpress.XtraEditors.SimpleButton SmpBtnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtProduct;
        private DevExpress.XtraEditors.GroupControl GrpCtrlCurrentProcess;
        private DevExpress.XtraEditors.LabelControl LblTextSeriesNumber;
        private DevExpress.XtraEditors.TextEdit TxtInvoice;
        private DevExpress.XtraEditors.TextEdit TxtAmount;
        private DevExpress.XtraEditors.TextEdit TxtPrice;
        private DevExpress.XtraEditors.TextEdit TxtQuantity;
    }
}