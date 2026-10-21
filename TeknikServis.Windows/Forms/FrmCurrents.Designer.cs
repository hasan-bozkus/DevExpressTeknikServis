namespace TeknikServis.Windows.Forms
{
    partial class FrmCurrents
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
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D4 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView4 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GrdCurrents = new DevExpress.XtraGrid.GridControl();
            this.ChartCtrlCurrentStatistics = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCurrents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCtrlCurrentStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView4)).BeginInit();
            this.SuspendLayout();
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdCurrents;
            this.GrdViewItems.Name = "GrdViewItems";
            this.GrdViewItems.OptionsView.ShowGroupPanel = false;
            // 
            // GrdCurrents
            // 
            this.GrdCurrents.Location = new System.Drawing.Point(-3, 0);
            this.GrdCurrents.MainView = this.GrdViewItems;
            this.GrdCurrents.Name = "GrdCurrents";
            this.GrdCurrents.Size = new System.Drawing.Size(402, 537);
            this.GrdCurrents.TabIndex = 4;
            this.GrdCurrents.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // ChartCtrlCurrentStatistics
            // 
            simpleDiagram3D4.RotationMatrixSerializable = "-0.520491087930203;0.716796492564723;-0.463995490961004;0;0.765105799543006;0.632" +
    "765138494126;0.119253490565975;0;0.379080654862382;-0.292935262051909;-0.8777737" +
    "68892467;0;0;0;0;1";
            this.ChartCtrlCurrentStatistics.Diagram = simpleDiagram3D4;
            this.ChartCtrlCurrentStatistics.Location = new System.Drawing.Point(400, 0);
            this.ChartCtrlCurrentStatistics.Name = "ChartCtrlCurrentStatistics";
            series4.LegendTextPattern = "{A}";
            series4.Name = "Series 1";
            series4.SeriesID = 1;
            series4.View = pie3DSeriesView4;
            this.ChartCtrlCurrentStatistics.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4};
            this.ChartCtrlCurrentStatistics.Size = new System.Drawing.Size(965, 537);
            this.ChartCtrlCurrentStatistics.TabIndex = 5;
            // 
            // FrmCurrents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 533);
            this.Controls.Add(this.ChartCtrlCurrentStatistics);
            this.Controls.Add(this.GrdCurrents);
            this.Name = "FrmCurrents";
            this.Text = "FrmCurrents";
            this.Load += new System.EventHandler(this.FrmCurrents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdCurrents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCtrlCurrentStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private DevExpress.XtraGrid.GridControl GrdCurrents;
        private DevExpress.XtraCharts.ChartControl ChartCtrlCurrentStatistics;
    }
}