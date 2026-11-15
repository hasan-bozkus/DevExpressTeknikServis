namespace TeknikServis.Windows.Forms
{
    partial class FrmInvoiceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoiceList));
            this.LblTextSeriesNumber = new DevExpress.XtraEditors.LabelControl();
            this.GrpCtrlCurrentProcess = new DevExpress.XtraEditors.GroupControl();
            this.LkUpEmployee = new DevExpress.XtraEditors.LookUpEdit();
            this.LkUpCurrent = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtInvoiceId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.SmpBtnList = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.SmpBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTaxOffice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtInvoiceTime = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtInvoiceDate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtOrderNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeriesNumber = new DevExpress.XtraEditors.TextEdit();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdInvoices = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlCurrentProcess)).BeginInit();
            this.GrpCtrlCurrentProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LkUpEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkUpCurrent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxOffice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOrderNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriesNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTextSeriesNumber
            // 
            this.LblTextSeriesNumber.Location = new System.Drawing.Point(24, 71);
            this.LblTextSeriesNumber.Name = "LblTextSeriesNumber";
            this.LblTextSeriesNumber.Size = new System.Drawing.Size(57, 16);
            this.LblTextSeriesNumber.TabIndex = 3;
            this.LblTextSeriesNumber.Text = "SERİ NO: ";
            // 
            // GrpCtrlCurrentProcess
            // 
            this.GrpCtrlCurrentProcess.Controls.Add(this.LkUpEmployee);
            this.GrpCtrlCurrentProcess.Controls.Add(this.LkUpCurrent);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl8);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtInvoiceId);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl6);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnList);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnUpdate);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnRemove);
            this.GrpCtrlCurrentProcess.Controls.Add(this.SmpBtnSave);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl7);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtTaxOffice);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl5);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtInvoiceTime);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl4);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtInvoiceDate);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl3);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtOrderNumber);
            this.GrpCtrlCurrentProcess.Controls.Add(this.labelControl2);
            this.GrpCtrlCurrentProcess.Controls.Add(this.TxtSeriesNumber);
            this.GrpCtrlCurrentProcess.Controls.Add(this.LblTextSeriesNumber);
            this.GrpCtrlCurrentProcess.Location = new System.Drawing.Point(1029, -9);
            this.GrpCtrlCurrentProcess.Name = "GrpCtrlCurrentProcess";
            this.GrpCtrlCurrentProcess.Size = new System.Drawing.Size(338, 537);
            this.GrpCtrlCurrentProcess.TabIndex = 37;
            this.GrpCtrlCurrentProcess.Text = "FATURA İŞLEMLERİ";
            // 
            // LkUpEmployee
            // 
            this.LkUpEmployee.Location = new System.Drawing.Point(85, 237);
            this.LkUpEmployee.Name = "LkUpEmployee";
            this.LkUpEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkUpEmployee.Properties.DisplayMember = "EmployeeFullName";
            this.LkUpEmployee.Properties.DropDownRows = 1;
            this.LkUpEmployee.Properties.NullText = "--- Lütfen Seçiniz ---";
            this.LkUpEmployee.Properties.ValueMember = "EmployeeId";
            this.LkUpEmployee.Size = new System.Drawing.Size(241, 22);
            this.LkUpEmployee.TabIndex = 8;
            // 
            // LkUpCurrent
            // 
            this.LkUpCurrent.Location = new System.Drawing.Point(84, 208);
            this.LkUpCurrent.Name = "LkUpCurrent";
            this.LkUpCurrent.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkUpCurrent.Properties.DisplayMember = "CurrentFullName";
            this.LkUpCurrent.Properties.DropDownRows = 1;
            this.LkUpCurrent.Properties.NullText = "--- Lütfen Seçiniz ---";
            this.LkUpCurrent.Properties.ValueMember = "CurrentId";
            this.LkUpCurrent.Size = new System.Drawing.Size(241, 22);
            this.LkUpCurrent.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 242);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(69, 16);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "PERSONEL: ";
            // 
            // TxtInvoiceId
            // 
            this.TxtInvoiceId.Enabled = false;
            this.TxtInvoiceId.Location = new System.Drawing.Point(86, 40);
            this.TxtInvoiceId.Name = "TxtInvoiceId";
            this.TxtInvoiceId.Size = new System.Drawing.Size(241, 22);
            this.TxtInvoiceId.TabIndex = 0;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 43);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(72, 16);
            this.labelControl6.TabIndex = 19;
            this.labelControl6.Text = "FATURA ID: ";
            // 
            // SmpBtnList
            // 
            this.SmpBtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnList.ImageOptions.Image")));
            this.SmpBtnList.Location = new System.Drawing.Point(86, 400);
            this.SmpBtnList.Name = "SmpBtnList";
            this.SmpBtnList.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnList.TabIndex = 12;
            this.SmpBtnList.Text = "LİSTELE";
            // 
            // SmpBtnUpdate
            // 
            this.SmpBtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnUpdate.ImageOptions.Image")));
            this.SmpBtnUpdate.Location = new System.Drawing.Point(86, 362);
            this.SmpBtnUpdate.Name = "SmpBtnUpdate";
            this.SmpBtnUpdate.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnUpdate.TabIndex = 11;
            this.SmpBtnUpdate.Text = "GÜNCELLE";
            // 
            // SmpBtnRemove
            // 
            this.SmpBtnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnRemove.ImageOptions.Image")));
            this.SmpBtnRemove.Location = new System.Drawing.Point(86, 324);
            this.SmpBtnRemove.Name = "SmpBtnRemove";
            this.SmpBtnRemove.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnRemove.TabIndex = 10;
            this.SmpBtnRemove.Text = "SİL";
            // 
            // SmpBtnSave
            // 
            this.SmpBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SmpBtnSave.ImageOptions.Image")));
            this.SmpBtnSave.Location = new System.Drawing.Point(86, 286);
            this.SmpBtnSave.Name = "SmpBtnSave";
            this.SmpBtnSave.Size = new System.Drawing.Size(171, 32);
            this.SmpBtnSave.TabIndex = 9;
            this.SmpBtnSave.Text = "KAYDET";
            this.SmpBtnSave.Click += new System.EventHandler(this.SmpBtnSave_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(44, 211);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 16);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "CARİ: ";
            // 
            // TxtTaxOffice
            // 
            this.TxtTaxOffice.Location = new System.Drawing.Point(86, 180);
            this.TxtTaxOffice.Name = "TxtTaxOffice";
            this.TxtTaxOffice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.TimeOnlyMaskManager));
            this.TxtTaxOffice.Properties.MaskSettings.Set("mask", "t");
            this.TxtTaxOffice.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.TxtTaxOffice.Size = new System.Drawing.Size(241, 22);
            this.TxtTaxOffice.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 183);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 16);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "VERGİ D.: ";
            // 
            // TxtInvoiceTime
            // 
            this.TxtInvoiceTime.Location = new System.Drawing.Point(86, 152);
            this.TxtInvoiceTime.Name = "TxtInvoiceTime";
            this.TxtInvoiceTime.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtInvoiceTime.Properties.MaskSettings.Set("mask", "(0?\\d|1\\d|2[0-3])\\:[0-5]\\d");
            this.TxtInvoiceTime.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.TxtInvoiceTime.Size = new System.Drawing.Size(241, 22);
            this.TxtInvoiceTime.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "SAAT: ";
            // 
            // TxtInvoiceDate
            // 
            this.TxtInvoiceDate.Location = new System.Drawing.Point(86, 124);
            this.TxtInvoiceDate.Name = "TxtInvoiceDate";
            this.TxtInvoiceDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.TxtInvoiceDate.Properties.MaskSettings.Set("mask", "d");
            this.TxtInvoiceDate.Size = new System.Drawing.Size(241, 22);
            this.TxtInvoiceDate.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "TARİH: ";
            // 
            // TxtOrderNumber
            // 
            this.TxtOrderNumber.Location = new System.Drawing.Point(86, 96);
            this.TxtOrderNumber.Name = "TxtOrderNumber";
            this.TxtOrderNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtOrderNumber.Properties.MaskSettings.Set("mask", "00000");
            this.TxtOrderNumber.Size = new System.Drawing.Size(241, 22);
            this.TxtOrderNumber.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "SIRA NO: ";
            // 
            // TxtSeriesNumber
            // 
            this.TxtSeriesNumber.Location = new System.Drawing.Point(86, 68);
            this.TxtSeriesNumber.Name = "TxtSeriesNumber";
            this.TxtSeriesNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TxtSeriesNumber.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.TxtSeriesNumber.Properties.MaskSettings.Set("mask", "(1?[1-9])|([12][0-4])");
            this.TxtSeriesNumber.Size = new System.Drawing.Size(241, 22);
            this.TxtSeriesNumber.TabIndex = 2;
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdInvoices;
            this.GrdViewItems.Name = "GrdViewItems";
            this.GrdViewItems.OptionsView.ShowGroupPanel = false;
            // 
            // GrdInvoices
            // 
            this.GrdInvoices.Location = new System.Drawing.Point(3, -9);
            this.GrdInvoices.MainView = this.GrdViewItems;
            this.GrdInvoices.Name = "GrdInvoices";
            this.GrdInvoices.Size = new System.Drawing.Size(1020, 550);
            this.GrdInvoices.TabIndex = 36;
            this.GrdInvoices.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // FrmInvoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.GrpCtrlCurrentProcess);
            this.Controls.Add(this.GrdInvoices);
            this.Name = "FrmInvoiceList";
            this.Text = "Fatura Listesi";
            this.Load += new System.EventHandler(this.FrmInvoiceList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrpCtrlCurrentProcess)).EndInit();
            this.GrpCtrlCurrentProcess.ResumeLayout(false);
            this.GrpCtrlCurrentProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LkUpEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkUpCurrent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTaxOffice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOrderNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriesNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblTextSeriesNumber;
        private DevExpress.XtraEditors.GroupControl GrpCtrlCurrentProcess;
        private DevExpress.XtraEditors.TextEdit TxtInvoiceId;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton SmpBtnList;
        private DevExpress.XtraEditors.SimpleButton SmpBtnUpdate;
        private DevExpress.XtraEditors.SimpleButton SmpBtnRemove;
        private DevExpress.XtraEditors.SimpleButton SmpBtnSave;
        private DevExpress.XtraEditors.TextEdit TxtSeriesNumber;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private DevExpress.XtraGrid.GridControl GrdInvoices;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TxtTaxOffice;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtInvoiceTime;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtInvoiceDate;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtOrderNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LookUpEdit LkUpCurrent;
        private DevExpress.XtraEditors.LookUpEdit LkUpEmployee;
    }
}