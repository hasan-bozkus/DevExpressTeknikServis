namespace TeknikServis.Windows.Forms
{
    partial class FrmSales
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
            this.GrdSalesList = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdSalesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdSalesList
            // 
            this.GrdSalesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdSalesList.Location = new System.Drawing.Point(0, 0);
            this.GrdSalesList.MainView = this.GrdViewItems;
            this.GrdSalesList.Name = "GrdSalesList";
            this.GrdSalesList.Size = new System.Drawing.Size(1368, 548);
            this.GrdSalesList.TabIndex = 3;
            this.GrdSalesList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdSalesList;
            this.GrdViewItems.Name = "GrdViewItems";
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 548);
            this.Controls.Add(this.GrdSalesList);
            this.Name = "FrmSales";
            this.Text = "FrmSales";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdSalesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdSalesList;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
    }
}