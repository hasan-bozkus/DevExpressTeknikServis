namespace TeknikServis.Windows.Forms
{
    partial class FrmInvoiceItemsList
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
            this.GrdInvoiceItems = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSerialNo = new DevExpress.XtraEditors.TextEdit();
            this.SmpBtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtOrder = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtInvoiceId = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoiceItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerialNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdInvoiceItems
            // 
            this.GrdInvoiceItems.Location = new System.Drawing.Point(-5, 46);
            this.GrdInvoiceItems.MainView = this.GrdViewItems;
            this.GrdInvoiceItems.Name = "GrdInvoiceItems";
            this.GrdInvoiceItems.Size = new System.Drawing.Size(1371, 491);
            this.GrdInvoiceItems.TabIndex = 39;
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(233, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 22);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Seri No: ";
            // 
            // TxtSerialNo
            // 
            this.TxtSerialNo.Location = new System.Drawing.Point(308, 9);
            this.TxtSerialNo.Name = "TxtSerialNo";
            this.TxtSerialNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSerialNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSerialNo.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtSerialNo.Properties.MaskSettings.Set("mask", "AAAAA");
            this.TxtSerialNo.Size = new System.Drawing.Size(125, 28);
            this.TxtSerialNo.TabIndex = 2;
            // 
            // SmpBtnSearch
            // 
            this.SmpBtnSearch.ImageOptions.Image = global::TeknikServis.Windows.Properties.Resources.find_32x32;
            this.SmpBtnSearch.Location = new System.Drawing.Point(673, 9);
            this.SmpBtnSearch.Name = "SmpBtnSearch";
            this.SmpBtnSearch.Size = new System.Drawing.Size(126, 28);
            this.SmpBtnSearch.TabIndex = 4;
            this.SmpBtnSearch.Text = "Ara";
            this.SmpBtnSearch.Click += new System.EventHandler(this.SmpBtnSearch_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(458, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 22);
            this.labelControl2.TabIndex = 40;
            this.labelControl2.Text = "Sıra No: ";
            // 
            // TxtOrder
            // 
            this.TxtOrder.Location = new System.Drawing.Point(533, 9);
            this.TxtOrder.Name = "TxtOrder";
            this.TxtOrder.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtOrder.Properties.Appearance.Options.UseFont = true;
            this.TxtOrder.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.TxtOrder.Properties.MaskSettings.Set("mask", "00000");
            this.TxtOrder.Size = new System.Drawing.Size(125, 28);
            this.TxtOrder.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(9, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 22);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "Fatura ID: ";
            // 
            // TxtInvoiceId
            // 
            this.TxtInvoiceId.Location = new System.Drawing.Point(99, 9);
            this.TxtInvoiceId.Name = "TxtInvoiceId";
            this.TxtInvoiceId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtInvoiceId.Properties.Appearance.Options.UseFont = true;
            this.TxtInvoiceId.Size = new System.Drawing.Size(125, 28);
            this.TxtInvoiceId.TabIndex = 1;
            // 
            // FrmInvoiceItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.SmpBtnSearch);
            this.Controls.Add(this.TxtOrder);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TxtInvoiceId);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtSerialNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.GrdInvoiceItems);
            this.Name = "FrmInvoiceItemsList";
            this.Text = "FrmInvoiceItemsList";
            ((System.ComponentModel.ISupportInitialize)(this.GrdInvoiceItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSerialNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtInvoiceId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdInvoiceItems;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSerialNo;
        private DevExpress.XtraEditors.SimpleButton SmpBtnSearch;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtOrder;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtInvoiceId;
    }
}