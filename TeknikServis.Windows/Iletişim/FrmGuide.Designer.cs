namespace TeknikServis.Windows.Iletişim
{
    partial class FrmGuide
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
            this.GrdGuide = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrdGuide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdGuide
            // 
            this.GrdGuide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdGuide.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GrdGuide.Location = new System.Drawing.Point(0, 0);
            this.GrdGuide.MainView = this.GrdViewItems;
            this.GrdGuide.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GrdGuide.Name = "GrdGuide";
            this.GrdGuide.Size = new System.Drawing.Size(1368, 533);
            this.GrdGuide.TabIndex = 32;
            this.GrdGuide.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.DetailHeight = 546;
            this.GrdViewItems.GridControl = this.GrdGuide;
            this.GrdViewItems.Name = "GrdViewItems";
            this.GrdViewItems.OptionsEditForm.PopupEditFormWidth = 1250;
            this.GrdViewItems.OptionsView.ShowGroupPanel = false;
            // 
            // FrmGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 533);
            this.Controls.Add(this.GrdGuide);
            this.Name = "FrmGuide";
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.FrmGuide_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdGuide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrdGuide;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
    }
}