namespace TeknikServis.Windows.Forms
{
    partial class FrmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductList));
            this.GrdProducts = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrpCtrlProductProcess = new DevExpress.XtraEditors.GroupControl();
            this.TxtProductId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SmpBtnClear = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnList = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.LkUpCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtStock = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSalePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPurchasePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBrand = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtProductName = new DevExpress.XtraEditors.TextEdit();
            this.LblTextProductName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrdProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlProductProcess)).BeginInit();
            this.GrpCtrlProductProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProductId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkUpCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProductName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdProducts
            // 
            this.GrdProducts.Location = new System.Drawing.Point(1, 0);
            this.GrdProducts.MainView = this.GrdViewItems;
            this.GrdProducts.Name = "GrdProducts";
            this.GrdProducts.Size = new System.Drawing.Size(1009, 550);
            this.GrdProducts.TabIndex = 0;
            this.GrdProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdProducts;
            this.GrdViewItems.Name = "GrdViewItems";
            this.GrdViewItems.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GrdViewItems_FocusedRowChanged);
            // 
            // GrpCtrlProductProcess
            // 
            this.GrpCtrlProductProcess.Controls.Add(this.TxtProductId);
            this.GrpCtrlProductProcess.Controls.Add(this.labelControl6);
            this.GrpCtrlProductProcess.Controls.Add(this.SmpBtnClear);
            this.GrpCtrlProductProcess.Controls.Add(this.SmpBtnList);
            this.GrpCtrlProductProcess.Controls.Add(this.SmpBtnUpdate);
            this.GrpCtrlProductProcess.Controls.Add(this.SmpBtnRemove);
            this.GrpCtrlProductProcess.Controls.Add(this.SmpBtnSave);
            this.GrpCtrlProductProcess.Controls.Add(this.LkUpCategory);
            this.GrpCtrlProductProcess.Controls.Add(this.labelControl5);
            this.GrpCtrlProductProcess.Controls.Add(this.TxtStock);
            this.GrpCtrlProductProcess.Controls.Add(this.labelControl4);
            this.GrpCtrlProductProcess.Controls.Add(this.TxtSalePrice);
            this.GrpCtrlProductProcess.Controls.Add(this.labelControl3);
            this.GrpCtrlProductProcess.Controls.Add(this.TxtPurchasePrice);
            this.GrpCtrlProductProcess.Controls.Add(this.labelControl2);
            this.GrpCtrlProductProcess.Controls.Add(this.TxtBrand);
            this.GrpCtrlProductProcess.Controls.Add(this.labelControl1);
            this.GrpCtrlProductProcess.Controls.Add(this.TxtProductName);
            this.GrpCtrlProductProcess.Controls.Add(this.LblTextProductName);
            this.GrpCtrlProductProcess.Location = new System.Drawing.Point(1007, 0);
            this.GrpCtrlProductProcess.Name = "GrpCtrlProductProcess";
            this.GrpCtrlProductProcess.Size = new System.Drawing.Size(358, 537);
            this.GrpCtrlProductProcess.TabIndex = 1;
            this.GrpCtrlProductProcess.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // TxtProductId
            // 
            this.TxtProductId.Enabled = false;
            this.TxtProductId.Location = new System.Drawing.Point(99, 48);
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.Size = new System.Drawing.Size(171, 22);
            this.TxtProductId.TabIndex = 20;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(28, 51);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "ÜRÜN ID: ";
            // 
            // SmpBtnClear
            // 
            this.SmpBtnClear.ImageOptions.Image = global::TeknikServis.Windows.Properties.Resources.clear_32x32;
            this.SmpBtnClear.Location = new System.Drawing.Point(99, 465);
            this.SmpBtnClear.Name = "SmpBtnClear";
            this.SmpBtnClear.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnClear.TabIndex = 18;
            this.SmpBtnClear.Text = "TEMİZLE";
            this.SmpBtnClear.Click += new System.EventHandler(this.SmpBtnClear_Click);
            // 
            // SmpBtnList
            // 
            this.SmpBtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnList.ImageOptions.Image")));
            this.SmpBtnList.Location = new System.Drawing.Point(99, 427);
            this.SmpBtnList.Name = "SmpBtnList";
            this.SmpBtnList.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnList.TabIndex = 18;
            this.SmpBtnList.Text = "LİSTELE";
            this.SmpBtnList.Click += new System.EventHandler(this.SmpBtnList_Click);
            // 
            // SmpBtnUpdate
            // 
            this.SmpBtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnUpdate.ImageOptions.Image")));
            this.SmpBtnUpdate.Location = new System.Drawing.Point(99, 389);
            this.SmpBtnUpdate.Name = "SmpBtnUpdate";
            this.SmpBtnUpdate.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnUpdate.TabIndex = 17;
            this.SmpBtnUpdate.Text = "GÜNCELLE";
            this.SmpBtnUpdate.Click += new System.EventHandler(this.SmpBtnUpdate_Click);
            // 
            // SmpBtnRemove
            // 
            this.SmpBtnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnRemove.ImageOptions.Image")));
            this.SmpBtnRemove.Location = new System.Drawing.Point(99, 351);
            this.SmpBtnRemove.Name = "SmpBtnRemove";
            this.SmpBtnRemove.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnRemove.TabIndex = 16;
            this.SmpBtnRemove.Text = "SİL";
            this.SmpBtnRemove.Click += new System.EventHandler(this.SmpBtnRemove_Click);
            // 
            // SmpBtnSave
            // 
            this.SmpBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnSave.ImageOptions.Image")));
            this.SmpBtnSave.Location = new System.Drawing.Point(99, 313);
            this.SmpBtnSave.Name = "SmpBtnSave";
            this.SmpBtnSave.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnSave.TabIndex = 15;
            this.SmpBtnSave.Text = "KAYDET";
            this.SmpBtnSave.Click += new System.EventHandler(this.SmpBtnSave_Click);
            // 
            // LkUpCategory
            // 
            this.LkUpCategory.Location = new System.Drawing.Point(99, 285);
            this.LkUpCategory.Name = "LkUpCategory";
            this.LkUpCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkUpCategory.Properties.DisplayMember = "CategoryName";
            this.LkUpCategory.Properties.NullText = "--- Lütfen Seçiniz ---";
            this.LkUpCategory.Properties.ValueMember = "CategoryId";
            this.LkUpCategory.Size = new System.Drawing.Size(171, 22);
            this.LkUpCategory.TabIndex = 14;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 291);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(68, 16);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "KATEGORİ: ";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(99, 246);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(171, 22);
            this.TxtStock.TabIndex = 12;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(52, 249);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "STOK: ";
            // 
            // TxtSalePrice
            // 
            this.TxtSalePrice.Location = new System.Drawing.Point(99, 204);
            this.TxtSalePrice.Name = "TxtSalePrice";
            this.TxtSalePrice.Size = new System.Drawing.Size(171, 22);
            this.TxtSalePrice.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 207);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 16);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "SATIŞ FİYATI: ";
            // 
            // TxtPurchasePrice
            // 
            this.TxtPurchasePrice.Location = new System.Drawing.Point(99, 162);
            this.TxtPurchasePrice.Name = "TxtPurchasePrice";
            this.TxtPurchasePrice.Size = new System.Drawing.Size(171, 22);
            this.TxtPurchasePrice.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 165);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 16);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "ALIŞ FİYATI: ";
            // 
            // TxtBrand
            // 
            this.TxtBrand.Location = new System.Drawing.Point(99, 124);
            this.TxtBrand.Name = "TxtBrand";
            this.TxtBrand.Size = new System.Drawing.Size(171, 22);
            this.TxtBrand.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 127);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "MARKA: ";
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(99, 85);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(171, 22);
            this.TxtProductName.TabIndex = 4;
            // 
            // LblTextProductName
            // 
            this.LblTextProductName.Location = new System.Drawing.Point(28, 88);
            this.LblTextProductName.Name = "LblTextProductName";
            this.LblTextProductName.Size = new System.Drawing.Size(65, 16);
            this.LblTextProductName.TabIndex = 3;
            this.LblTextProductName.Text = "ÜRÜN ADI: ";
            // 
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.GrpCtrlProductProcess);
            this.Controls.Add(this.GrdProducts);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmProductList";
            this.Text = "FrmProductList";
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlProductProcess)).EndInit();
            this.GrpCtrlProductProcess.ResumeLayout(false);
            this.GrpCtrlProductProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProductId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkUpCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtProductName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private DevExpress.XtraEditors.GroupControl GrpCtrlProductProcess;
        private DevExpress.XtraEditors.TextEdit TxtStock;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtSalePrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtPurchasePrice;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtBrand;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtProductName;
        private DevExpress.XtraEditors.LabelControl LblTextProductName;
        private DevExpress.XtraEditors.LookUpEdit LkUpCategory;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton SmpBtnSave;
        private DevExpress.XtraEditors.SimpleButton SmpBtnUpdate;
        private DevExpress.XtraEditors.SimpleButton SmpBtnRemove;
        private DevExpress.XtraEditors.SimpleButton SmpBtnList;
        private DevExpress.XtraEditors.TextEdit TxtProductId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton SmpBtnClear;
    }
}