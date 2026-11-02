namespace TeknikServis.Windows.Forms
{
    partial class FrmFaultProductDetails
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
            this.GrdFaultProductList = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFaultProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdFaultProductList
            // 
            this.GrdFaultProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdFaultProductList.Location = new System.Drawing.Point(0, 0);
            this.GrdFaultProductList.MainView = this.GrdViewItems;
            this.GrdFaultProductList.Name = "GrdFaultProductList";
            this.GrdFaultProductList.Size = new System.Drawing.Size(1368, 533);
            this.GrdFaultProductList.TabIndex = 31;
            this.GrdFaultProductList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdFaultProductList;
            this.GrdViewItems.Name = "GrdViewItems";
            this.GrdViewItems.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag;
            this.GrdViewItems.OptionsView.ShowAutoFilterRow = true;
            this.GrdViewItems.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // FrmFaultProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.GrdFaultProductList);
            this.Name = "FrmFaultProductDetails";
            this.Text = "FrmFaultProductDetails";
            this.Load += new System.EventHandler(this.FrmFaultProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdFaultProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdFaultProductList;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
    }
}