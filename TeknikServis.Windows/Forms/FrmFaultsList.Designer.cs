namespace TeknikServis.Windows.Forms
{
    partial class FrmFaultsList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaultsList));
            DevExpress.XtraCharts.SimpleDiagram3D simpleDiagram3D1 = new DevExpress.XtraCharts.SimpleDiagram3D();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView1 = new DevExpress.XtraCharts.Pie3DSeriesView();
            DevExpress.XtraCharts.Pie3DSeriesView pie3DSeriesView2 = new DevExpress.XtraCharts.Pie3DSeriesView();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ChartBrandAndValue = new DevExpress.XtraCharts.ChartControl();
            this.GrdFaultsList = new DevExpress.XtraGrid.GridControl();
            this.GrdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LblTotalBrandCount = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LblMaxProductCountByBrand = new DevExpress.XtraEditors.LabelControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.LblMaxPricedBrand = new DevExpress.XtraEditors.LabelControl();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.panel8 = new System.Windows.Forms.Panel();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBrandAndValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFaultsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(14, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(63, 50);
            this.pictureEdit1.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(83, 16);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(232, 28);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Arızalı Ürün İstatistikleri";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(3, 50);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(625, 34);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Projemizin bu bölümünde markalar ve bu markalara ait istatistik değerlerine grafi" +
    "k alanı üzerinden güçlü bir \r\narayüzle ulaşabilirsiniz.";
            // 
            // ChartBrandAndValue
            // 
            simpleDiagram3D1.RotationMatrixSerializable = "0.810740653830928;0.313214395603366;-0.494566815114618;0;-0.585404076680073;0.435" +
    "635238285001;-0.683757271384167;0;0.0012881118543125;0.843871247022428;0.5365441" +
    "81980069;0;0;0;0;1";
            this.ChartBrandAndValue.Diagram = simpleDiagram3D1;
            this.ChartBrandAndValue.IndicatorsPaletteName = "Office 2013";
            this.ChartBrandAndValue.Location = new System.Drawing.Point(3, 90);
            this.ChartBrandAndValue.Name = "ChartBrandAndValue";
            this.ChartBrandAndValue.PaletteName = "Pastel Kit";
            series1.LegendTextPattern = "(A)";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            series1.View = pie3DSeriesView1;
            this.ChartBrandAndValue.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ChartBrandAndValue.SeriesTemplate.View = pie3DSeriesView2;
            this.ChartBrandAndValue.Size = new System.Drawing.Size(624, 161);
            this.ChartBrandAndValue.TabIndex = 0;
            // 
            // GrdFaultsList
            // 
            this.GrdFaultsList.Location = new System.Drawing.Point(1, -9);
            this.GrdFaultsList.MainView = this.GrdViewItems;
            this.GrdFaultsList.Name = "GrdFaultsList";
            this.GrdFaultsList.Size = new System.Drawing.Size(763, 550);
            this.GrdFaultsList.TabIndex = 5;
            this.GrdFaultsList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrdViewItems});
            // 
            // GrdViewItems
            // 
            this.GrdViewItems.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(156)))), ((int)(((byte)(218)))));
            this.GrdViewItems.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(209)))), ((int)(((byte)(245)))));
            this.GrdViewItems.Appearance.Row.Options.UseBackColor = true;
            this.GrdViewItems.Appearance.Row.Options.UseBorderColor = true;
            this.GrdViewItems.GridControl = this.GrdFaultsList;
            this.GrdViewItems.Name = "GrdViewItems";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.labelControl2);
            this.panel2.Controls.Add(this.LblTotalBrandCount);
            this.panel2.Location = new System.Drawing.Point(975, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 137);
            this.panel2.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(14, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(172, 21);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Tadilatı Biten Ürün Sayısı";
            // 
            // LblTotalBrandCount
            // 
            this.LblTotalBrandCount.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblTotalBrandCount.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblTotalBrandCount.Appearance.Options.UseFont = true;
            this.LblTotalBrandCount.Appearance.Options.UseForeColor = true;
            this.LblTotalBrandCount.Location = new System.Drawing.Point(45, 48);
            this.LblTotalBrandCount.Name = "LblTotalBrandCount";
            this.LblTotalBrandCount.Size = new System.Drawing.Size(75, 59);
            this.LblTotalBrandCount.TabIndex = 0;
            this.LblTotalBrandCount.Text = "584";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(14, 21);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(181, 21);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Mevcut Arızalı Ürün Sayısı";
            // 
            // LblMaxProductCountByBrand
            // 
            this.LblMaxProductCountByBrand.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LblMaxProductCountByBrand.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblMaxProductCountByBrand.Appearance.Options.UseFont = true;
            this.LblMaxProductCountByBrand.Appearance.Options.UseForeColor = true;
            this.LblMaxProductCountByBrand.Location = new System.Drawing.Point(43, 59);
            this.LblMaxProductCountByBrand.Name = "LblMaxProductCountByBrand";
            this.LblMaxProductCountByBrand.Size = new System.Drawing.Size(57, 45);
            this.LblMaxProductCountByBrand.TabIndex = 0;
            this.LblMaxProductCountByBrand.Text = "584";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(101)))), ((int)(((byte)(116)))));
            this.panel4.Controls.Add(this.labelControl6);
            this.panel4.Controls.Add(this.LblMaxPricedBrand);
            this.panel4.Location = new System.Drawing.Point(1183, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 137);
            this.panel4.TabIndex = 8;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(19, 21);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(187, 21);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Parça Bekleyen Ürün Sayısı";
            // 
            // LblMaxPricedBrand
            // 
            this.LblMaxPricedBrand.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.LblMaxPricedBrand.Appearance.ForeColor = System.Drawing.Color.White;
            this.LblMaxPricedBrand.Appearance.Options.UseFont = true;
            this.LblMaxPricedBrand.Appearance.Options.UseForeColor = true;
            this.LblMaxPricedBrand.Location = new System.Drawing.Point(42, 59);
            this.LblMaxPricedBrand.Name = "LblMaxPricedBrand";
            this.LblMaxPricedBrand.Size = new System.Drawing.Size(57, 45);
            this.LblMaxPricedBrand.TabIndex = 0;
            this.LblMaxPricedBrand.Text = "584";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureEdit1);
            this.panel5.Controls.Add(this.labelControl5);
            this.panel5.Controls.Add(this.labelControl3);
            this.panel5.Controls.Add(this.ChartBrandAndValue);
            this.panel5.Location = new System.Drawing.Point(767, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(630, 254);
            this.panel5.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(227)))));
            this.panel3.Controls.Add(this.labelControl4);
            this.panel3.Controls.Add(this.LblMaxProductCountByBrand);
            this.panel3.Location = new System.Drawing.Point(767, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 137);
            this.panel3.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.panel6.Controls.Add(this.labelControl7);
            this.panel6.Controls.Add(this.labelControl8);
            this.panel6.Location = new System.Drawing.Point(767, 145);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 137);
            this.panel6.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(27, 21);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(136, 21);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Arızalı Ürünler Kasa";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(43, 59);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(57, 45);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "584";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(202)))), ((int)(((byte)(87)))));
            this.panel7.Controls.Add(this.labelControl9);
            this.panel7.Controls.Add(this.labelControl10);
            this.panel7.Location = new System.Drawing.Point(1183, 145);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(214, 137);
            this.panel7.TabIndex = 8;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(19, 21);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(181, 21);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "En Fazla Arızalanan Marka";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Appearance.Options.UseForeColor = true;
            this.labelControl10.Location = new System.Drawing.Point(42, 59);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(57, 45);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "584";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(104)))), ((int)(((byte)(224)))));
            this.panel8.Controls.Add(this.labelControl11);
            this.panel8.Controls.Add(this.labelControl12);
            this.panel8.Location = new System.Drawing.Point(975, 145);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(202, 137);
            this.panel8.TabIndex = 7;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl11.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Appearance.Options.UseForeColor = true;
            this.labelControl11.Location = new System.Drawing.Point(27, 21);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(135, 21);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Toplam Ürün Sayısı";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl12.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Appearance.Options.UseForeColor = true;
            this.labelControl12.Location = new System.Drawing.Point(45, 48);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(75, 59);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "584";
            // 
            // FrmFaultsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 545);
            this.Controls.Add(this.GrdFaultsList);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Name = "FrmFaultsList";
            this.Text = "FrmFaultsList";
            this.Load += new System.EventHandler(this.FrmFaultsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(simpleDiagram3D1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pie3DSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBrandAndValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdFaultsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrdViewItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraCharts.ChartControl ChartBrandAndValue;
        private DevExpress.XtraGrid.GridControl GrdFaultsList;
        private DevExpress.XtraGrid.Views.Grid.GridView GrdViewItems;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl LblTotalBrandCount;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl LblMaxProductCountByBrand;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl LblMaxPricedBrand;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Panel panel7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}